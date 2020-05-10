using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RefillManager
{
    public partial class SftpSettings : UBTStandardLibrary.Forms.N1Form
    {
        public SftpSettings()
        {
            InitializeComponent();
            cbAuthenticationType.DataSource = Enum.GetValues(typeof(AuthenticationType));

            if (!Properties.Settings.Default.SftpSettings.Trim().Equals(""))
            {
                SftpSetting sftpSetting =
                    JsonConvert.DeserializeObject<SftpSetting>(Properties.Settings.Default.SftpSettings);

                txtPassword.Text = sftpSetting.Password;
                txtHostName.Text = sftpSetting.HostName;
                txtUsername.Text = sftpSetting.Username;
                txtPrivateKey.Text = sftpSetting.PrivateKey.Trim().Equals("")?"Private Key": sftpSetting.PrivateKey;
                txtPublicKey.Text = sftpSetting.PublicKey.Trim().Equals("")? "Public Key":sftpSetting.PublicKey;
                txtPort.Text = sftpSetting.Port.ToString();

                cbAuthenticationType.SelectedItem = sftpSetting.AuthenticationType;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHostName.isEmptyOrHint())
            {
                txtHostName.Focus();
                return;
            }

            if (!IsInt(txtPort.Text.Trim()))
            {
                txtPort.Focus();
                return;
            }

            if (txtUsername.isEmptyOrHint())
            {
                txtUsername.Focus();
                return;
            }

            //if(txtPassword.isEmptyOrHint()&&
            //   (txtPrivateKey.Text.Equals("Private Key", StringComparison.CurrentCultureIgnoreCase) ||
            //    txtPublicKey.Text.Equals("Public Key", StringComparison.CurrentCultureIgnoreCase)))
            //{
            //    txtPassword.Focus();
            //    return;
            //}

            SftpSetting newSetting = new SftpSetting
            {
                Username = txtUsername.Text.Trim(),
                Port = Convert.ToInt16(txtPort.Text),
                HostName = txtHostName.Text.Trim(),
                Password = txtPassword.isEmptyOrHint()?"":txtPassword.Text,
                PrivateKey = txtPrivateKey.Text.Trim().Equals("Private Key", StringComparison.CurrentCultureIgnoreCase) ?"":txtPrivateKey.Text.Trim(),
                PublicKey = txtPublicKey.Text.Trim().Equals("Public Key", StringComparison.CurrentCultureIgnoreCase) ? "" : txtPublicKey.Text.Trim(),
                AuthenticationType = (AuthenticationType)cbAuthenticationType.SelectedItem
            };

            Properties.Settings.Default.SftpSettings = JsonConvert.SerializeObject(newSetting);
            Properties.Settings.Default.Save();
            MessageBox.Show("Setting Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsInt(string i)
        {
            try
            {
                Convert.ToInt16(i);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
