using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RefillManager
{
    public class UpdateManager
    {

        private const int Version = 1;

        public void StartService(Form f)
        {
            CheckForUpdate(f);
        }

        private void CheckForUpdate(Form f)
        {
            Task.Run(() =>
            {
                string outputPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
                UpdateSetting s =
                    JsonConvert.DeserializeObject<UpdateSetting>(Properties.Settings.Default.SoftwareUpdateSettings);
                try
                {
                    FileManager.DownloadFile(s.Version, outputPath);
                    int version = Convert.ToInt16(File.ReadAllText(outputPath).Trim());

                    if (version > Version)
                    {
                        f.Invoke(new Action(() =>
                        {
                            var r = MessageBox.Show("New Update Available\nUpdate Now?", "Update",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (r == DialogResult.Yes)
                                DownloadUpdatedSoftware(s.Software);

                            Environment.Exit(Environment.ExitCode);
                        }));
                    }
                }
                catch (Exception e)
                {

                }
            });
        }

        private void DownloadUpdatedSoftware(string path)
        {
            using (WebClient wc = new WebClient())
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Executable File(*.exe)|*.exe;";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        wc.DownloadFile(path, dialog.FileName);
                        MessageBox.Show("File Downloaded! Please uninstall previous version and install new one!",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }
    }
}
