using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Bunifu.Framework.UI;
using Newtonsoft.Json;
using UBTStandardLibrary;
using UBTStandardLibrary.Dialog;
using UBTStandardLibrary.Forms;

namespace RefillManager
{
    public partial class MainWindow : UBTStandardLibrary.Forms.N1Form
    {
        public MainWindow()
        {
            //new WebClient().DownloadFile("https://www.n1developer.com/version.txt", "file.txt");
            //MessageBox.Show(FileManager.IsTimeOver().ToString());
            InitializeComponent();
            KeyPreview = true;
            KeyDown += OnKeyDown;
            UpdateManager m = new UpdateManager();
            m.StartService(this);
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt)
            {
                if (e.KeyCode == Keys.A)
                {
                    if (Authenticate())
                        ShowSettings_V2();
                }
                else if (e.KeyCode == Keys.U)
                {
                    if (Authenticate())
                        HandelSoftwareUpdateSettings();
                }
            }
        }

        private void HandelSoftwareUpdateSettings()
        {
            string jsonSetting = Properties.Settings.Default.SoftwareUpdateSettings;
            List<Input> inputs;

            var vf = new Input()
            {
                Hint = "Version File",
                Index = 0,
                Length = 0,
                IsMandatory = false,
                Name = "vf"
            };
            var sf = new Input()
            {
                Hint = "Software File",
                Index = 1,
                Length = 0,
                IsMandatory = false,
                Name = "sf"
            };
            if (!jsonSetting.Equals(""))
            {
                UpdateSetting s = JsonConvert.DeserializeObject<UpdateSetting>(jsonSetting);
                sf.Value = s.Software;
                vf.Value = s.Version;
            }
            inputs = new List<Input>() { vf, sf };

            InputDialog dialog = new InputDialog("Software Update Settings", inputs, this);

            if (dialog.ShowIt() == ResultType.OK)
            {
                var result = dialog.Output;

                UpdateSetting newSetting = new UpdateSetting();
                newSetting.Version = result.Find(x => x.Name.Equals(vf.Name)).Value;
                newSetting.Software = result.Find(x => x.Name.Equals(sf.Name)).Value;
                Properties.Settings.Default.SoftwareUpdateSettings =
                    JsonConvert.SerializeObject(newSetting);
                Properties.Settings.Default.Save();
            }

        }
        private bool Authenticate()
        {
            using (InputDialog dx = new InputDialog("Enter Password",
                new List<Input>()
                    {new Input() {Name = "pwd", Index = 0, Hint = "Password", Type = InputType.Password}}, this))
            {
                if (dx.ShowIt() == ResultType.OK)
                {
                    if (dx.Output[0].Value.Equals("n1developer"))
                    {
                        dx.Dispose();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct Password", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }

            return false;
        }
        private void ShowSettings_V2()
        {
            using (SftpSettings s = new SftpSettings())
            {
                s.ShowDialog();
            }
        }
        private void ShowSettings_V1()
        {
            Settings settings;

            string data = Properties.Settings.Default.Data.Trim();

            if (data.Equals(""))
            {
                settings = new Settings();
            }
            else
            {
                settings = JsonConvert.DeserializeObject<Settings>(data);
            }

            List<Input> inputs = new List<Input>
                {
                    new Input()
                    {
                        Name = "sh",
                        Index = 0,
                        IsMandatory = true,
                        Hint = "SMTP Host",
                        Type = InputType.Text,
                        Value = settings.SMTPHost
                    },
                    new Input()
                    {
                        Name = "port",
                        Index = 1,
                        IsMandatory = true,
                        Hint = "Port",
                        Type = InputType.Integer,
                        Value = settings.Port.ToString()
                    },
                    new Input()
                    {
                        Name = "uid",
                        Index = 2,
                        IsMandatory = true,
                        Hint = "Username",
                        Type = InputType.Text,
                        Value = settings.Username
                    },
                    new Input()
                    {
                        Name = "pwd",
                        Index = 3,
                        IsMandatory = true,
                        Hint = "Password",
                        Type = InputType.Password,
                        Value = settings.Password
                    },
                    new Input()
                    {
                        Name="fn",
                        Index = 5,
                        IsMandatory = true,
                        Type = InputType.Text,
                        Hint = "Facility Name",
                        Value = settings.FacilityName
                    },
                    new Input()
                    {
                        Name="sb",
                        Index = 4,
                        IsMandatory = true,
                        Type = InputType.Text,
                        Hint = "Subject",
                        Value = settings.Subject
                    },
                    new Input()
                    {
                        Name="to",
                        Index = 6,
                        IsMandatory = true,
                        Type = InputType.Text,
                        Hint = "To",
                        Value = settings.To
                    }
                };

            InputDialog d = new InputDialog("Settings", inputs, this);
            ResultType t = d.ShowIt();

            if (t == ResultType.OK)
            {
                Settings s = new Settings();
                s.Password = d.Output.Find(x => x.Name.Equals("pwd")).Value;
                s.Username = d.Output.Find(x => x.Name.Equals("uid")).Value;
                s.FacilityName = d.Output.Find(x => x.Name.Equals("fn")).Value;
                s.Port = Convert.ToInt16(d.Output.Find(x => x.Name.Equals("port")).Value);
                s.Subject = d.Output.Find(x => x.Name.Equals("sb")).Value;
                s.SMTPHost = d.Output.Find(x => x.Name.Equals("sh")).Value;
                s.To = d.Output.Find(x => x.Name.Equals("to")).Value;
                Properties.Settings.Default.Data = JsonConvert.SerializeObject(s);
                Properties.Settings.Default.Save();
                MessageBox.Show("Settings Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRxNumbers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender is UBTTextBox b)
                {
                    if (b.isEmptyOrHint())
                        return;

                    switch (b.AccessibleName)
                    {
                        case "sr":
                            dgvSubmitRefillsData.Rows.Add(b.Text.Trim(), "Delete");
                            b.Text = "";
                            break;
                        case "red":
                            dgvRequestExtraDoseData.Rows.Add(b.Text.Trim(), "1", "Delete");
                            b.Text = "";
                            break;
                        case "rd":
                            AddRefillDmeRow(b.Text.Trim());
                            b.Text = "";
                            break;
                    }

                }
                
            }
        }

        private string[] RefillDmeItems = new[] {"Test strips", "Lancets", "Control solution"};
        private void AddRefillDmeRow(string b)
        {
            int num = dgvRefillDME.Rows.Add(b, "0");
            dgvRefillDME.Rows[num].Cells[3].Value = "Delete";
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            cell.Items.AddRange(RefillDmeItems);
            dgvRefillDME.Rows[num].Cells[2] = cell;
            dgvRefillDME.Rows[num].Cells[2].Value = (dgvRefillDME.Rows[num].Cells[2] as DataGridViewComboBoxCell).Items[0];
        }

        private void dgvSubmitRefillsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is BunifuCustomDataGrid d)
            {
                if (e.ColumnIndex == d.ColumnCount-1)
                {
                    d.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private async void btnSubmitRefills_Click(object sender, EventArgs e)
        {
            if (dgvSubmitRefillsData.RowCount == 0)
            {
                MessageBox.Show("Please enter at least one RX Number.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            InputDialog dialog = new InputDialog("Enter Initials", new List<Input>() { new Input() { Name = "Initials", Hint = "Initials", IsMandatory = true, Index = 0, Type = InputType.Text }}, parentForm: this);
            ResultType t = dialog.ShowIt();

            if (t == ResultType.OK)
            {
                Output initials = dialog.Output.Find(x => x.Name == "Initials");

                if (initials != null)
                {
                    string fileName = $"Refill_{DateTime.Now.ToString("MMddyy")}_{DateTime.Now.ToString("hhmmss")}.txt";


                    var s = JsonConvert.DeserializeObject<SftpSetting>(Properties.Settings.Default.SftpSettings);

                    if (s.FacilityName == null)
                        s.FacilityName = "";

                    string content = $"Source: Refill Manager\r\n" +
                                     $"Facility: {s.FacilityName}\r\n" +
                                     $"Type: Refill\r\n" +
                                     $"Initials: {initials.Value}\n" +
                                     $"Date/Time Requested: {DateTime.Now.ToString("s").Replace("T", " ")}\r\n" +
                                     $"Rx-Number\n";

                    foreach (DataGridViewRow row in dgvSubmitRefillsData.Rows)
                    {

                        content += $"{row.Cells[0].Value}\n";

                    }

                    File.WriteAllText(Path.Combine(Application.StartupPath, fileName), content);
                    Enable(false);
                    //bool result = await Notification.Alert(fileName);
                    string successMessage = $"Your Response is sent! Thank You {initials.Value}!";
                    bool result = await UploadFile(fileName, successMessage);
                    
                    if(result)
                        dgvSubmitRefillsData.Rows.Clear();
                    
                    File.Delete(fileName);
                    Enable(true);
                }
            }
        }

        private async Task<bool> UploadFile(string fileName, string successMessage)
        {
            UploadStatus status = await FileManager.UploadFile(fileName);
            switch (status)
            {
                case UploadStatus.Spam:
                    MessageBox.Show("A request was recently submitted. Please try again shortly.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                case UploadStatus.ConnectionError:
                    MessageBox.Show("Error In Connection! Try again later", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                case UploadStatus.Succeed:
                    MessageBox.Show(successMessage, "Response Sent!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            return true;
        }

        private bool IsInt(string x)
        {
            try
            {
                Convert.ToInt32(x);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private async void btnSubmitRefillDME_Click(object sender, EventArgs e)
        {
            if (dgvRefillDME.RowCount == 0)
            {
                MessageBox.Show("Please enter at least one RX Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            bool isOkay = true;
            foreach (DataGridViewRow row in dgvRefillDME.Rows)
            {
                if (!IsInt(row.Cells[1].Value.ToString()))
                {
                    row.Selected = true;
                    isOkay = false;
                }
            }

            if (!isOkay)
            {
                MessageBox.Show("Quantity Should Be Integer!\nRefer To Selected Rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DmeInput input = new DmeInput();
            input.ShowDialog();

            if (input.ResultType == ResultType.OK)
            {
                if (input.Result.Replace(" ","").Trim().Length < 2)
                {
                    MessageBox.Show("Please enter full name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = input.Result;
                string fileName = $"DME_{DateTime.Now.ToString("MMddyy")}_{DateTime.Now.ToString("hhmmss")}.txt";


                var s = JsonConvert.DeserializeObject<SftpSetting>(Properties.Settings.Default.SftpSettings);

                if (s.FacilityName == null)
                    s.FacilityName = "";

                string content = $"Source: Refill Manager\r\n" +
                                 $"Facility: {s.FacilityName}\r\n" +
                                 $"Type: DME\r\n" +
                                 $"Date/Time Requested: {DateTime.Now.ToString("s").Replace("T"," ")}\r\n" +
                                 $"Agent Authorizing Refill: {name}\r\n" +
                                 $"Rx-Number\tQty Rem\tDescription\n";

                foreach (DataGridViewRow row in dgvRefillDME.Rows)
                {
                    content += $"{row.Cells[0].Value}\t{row.Cells[1].Value}\t{row.Cells[2].Value}\n";
                }

                File.WriteAllText(fileName,content);

                Enable(false);
                //bool result = await Notification.Alert(fileName);
                string successMessage = $"Your Response is sent! Thank You {name}!";
                bool result = await UploadFile(fileName, successMessage);
                if (result)
                    dgvRefillDME.Rows.Clear();

                File.Delete(fileName);

                Enable(true);
            }
        }

        private async void btnRED_Click(object sender, EventArgs e)
        {
            if (dgvRequestExtraDoseData.RowCount == 0)
            {
                MessageBox.Show("Please enter at least one RX Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isOkay = true;
            foreach (DataGridViewRow row in dgvRequestExtraDoseData.Rows)
            {
                if (!IsInt(row.Cells[1].Value.ToString()))
                {
                    row.Selected = true;
                    isOkay = false;
                }
            }

            if (!isOkay)
            {
                MessageBox.Show("Quantity Should Be Integer!\nRefer To Selected Rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InputDialog dialog = new InputDialog("Enter Initials", new List<Input>() { new Input() { Name = "Initials", Hint = "Initials", IsMandatory = true, Index = 0, Type = InputType.Text } }, parentForm: this);
            ResultType t = dialog.ShowIt();

            if (t == ResultType.OK)
            {
                Output initials = dialog.Output.Find(x => x.Name == "Initials");

                string fileName = $"Extra_{DateTime.Now.ToString("MMddyy")}_{DateTime.Now.ToString("hhmmss")}.txt";


                var s = JsonConvert.DeserializeObject<SftpSetting>(Properties.Settings.Default.SftpSettings);

                if (s.FacilityName == null)
                    s.FacilityName = "";

                string content = $"Source: Refill Manager\r\n" +
                                 $"Facility: {s.FacilityName}\r\n" +
                                 $"Type: Extra Dose\r\n" +
                                 $"Initials: {initials.Value}\n" +
                                 $"Date/Time Requested: {DateTime.Now.ToString("s").Replace("T", " ")}\r\n" +
                                 $"Rx-Number\tQty\n";

                foreach (DataGridViewRow row in dgvRequestExtraDoseData.Rows)
                {

                    content += $"{row.Cells[0].Value}\t{row.Cells[1].Value}\n";

                }

                File.WriteAllText(fileName, content);
                Enable(false);
                //bool result = await Notification.Alert(fileName);
                string successMessage = $"Your Response is sent! Thank You {initials.Value}!";
                
                bool result = await  UploadFile(fileName, successMessage);

                if(result)
                    dgvRequestExtraDoseData.Rows.Clear();
                
                File.Delete(fileName);
                Enable(true);
            }
        }

        private void Enable(bool enable)
        {
            btnRED.Enabled = enable;
            btnSubmitRefillDME.Enabled = enable;
            btnSubmitRefills.Enabled = enable;
        }
    }
}
