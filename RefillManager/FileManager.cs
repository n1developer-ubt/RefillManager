using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Renci.SshNet;

namespace RefillManager
{
    public class FileManager
    {
        public static bool IsTimeOver()
        {
            DateTime lastUploaded = Properties.Settings.Default.LastUploaded;

            TimeSpan s = DateTime.Now.Subtract(lastUploaded);

            if (s.Minutes > 2)
                return true;

            return false;
        }
        public static async Task<UploadStatus> UploadFile(string fileName)
        {
            if (!IsTimeOver())
                return UploadStatus.Spam;
            try
            {
                SftpClient client = GetUpdatedClient();

                await Task.Run(() =>
                {
                    client.Connect();
                    client.BufferSize = 1024;
                    var fileStream = new FileStream(fileName, FileMode.Open);
                    client.UploadFile(fileStream, Path.GetFileName(fileName));

                    Properties.Settings.Default.LastUploaded = DateTime.Now;
                    Properties.Settings.Default.Save();
                    fileStream.Close();
                    client.Dispose();
                });
                return UploadStatus.Succeed;
            }
            catch (Exception e)
            {
                return UploadStatus.ConnectionError;
            }
        }

        public static void DownloadFile(string fileName, string outputFile)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(fileName, outputFile);
            }
        }
        private static SftpClient GetUpdatedClient()
        {
            SftpSetting s =
                JsonConvert.DeserializeObject<SftpSetting>(Properties.Settings.Default.SftpSettings);
            //MessageBox.Show(Properties.Settings.Default.SftpSettings);

            switch (s.AuthenticationType)
            {
                case AuthenticationType.Password:
                    return new SftpClient(s.HostName, s.Port, s.Username, s.Password);
                case AuthenticationType.PrivateKey:
                    return new SftpClient(new ConnectionInfo(s.HostName, s.Port, s.Username, GetPrivateKey(s.Username, GetFileName(s.PrivateKey))));
                case AuthenticationType.PublicKey:
                    return new SftpClient(new ConnectionInfo(s.HostName, s.Port, s.Username, GetPrivateKey(s.Username, GetFileName(s.PrivateKey))));
            }

            return null;
        }

        private static string GetFileName(string content)
        {
            string path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            File.WriteAllText(path, content);
            return path;
        }

        private static AuthenticationMethod[] GetPrivateKey(string username, string publicKeyPath)
        {
            PrivateKeyFile privateKeyFile = new PrivateKeyFile(publicKeyPath);
            PrivateKeyAuthenticationMethod privateKeyAuthenticationMethod =
                new PrivateKeyAuthenticationMethod(username, privateKeyFile);
            return new AuthenticationMethod[] { privateKeyAuthenticationMethod };
        }
    }

    public enum UploadStatus
    {
        Succeed,
        Spam,
        ConnectionError
    }

}
