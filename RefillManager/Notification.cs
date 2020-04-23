using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RefillManager
{
    public static class Notification
    {
        public static async Task<bool> Alert(string f)
        {
            Settings s = JsonConvert.DeserializeObject<Settings>(Properties.Settings.Default.Data);
            using (SmtpClient client = new SmtpClient())
            {
                client.Credentials = new NetworkCredential(s.Username, s.Password);
                client.Port = s.Port;
                client.Host = s.SMTPHost;
                client.EnableSsl = true;
                //client.UseDefaultCredentials = true;

                MailMessage sms = new MailMessage(s.Username, s.To);
                sms.Subject = s.Subject;
                sms.Attachments.Add(new Attachment(f));
                bool result = false;
                await Task.Run(() => {
                    try
                    {
                        client.Send(sms);
                        result = true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        result = false;
                    }
                });

                return result;
            }
        }
    }
}
