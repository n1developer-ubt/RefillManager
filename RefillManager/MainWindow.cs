using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            InitializeComponent();
            KeyPreview = true;
            KeyDown += OnKeyDown;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.A)
            {
                using (InputDialog dx = new InputDialog("Enter Password",
                    new List<Input>()
                        {new Input() {Name = "pwd", Index = 0, Hint = "Password", Type = InputType.Password}}, this))
                {
                    if (dx.ShowIt() == ResultType.OK)
                    {
                        if (dx.Output[0].Value.Equals("n1developer"))
                        {
                            ShowSettings();
                        }
                        else
                        {
                            MessageBox.Show("Enter Correct Password", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ShowSettings()
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
                            dgvRefillDME.Rows.Add(b.Text.Trim(), "0", "Delete");
                            b.Text = "";
                            break;
                    }

                }
                
            }
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
            InputDialog dialog = new InputDialog("Enter Initials", new List<Input>() { new Input() { Name = "Initials", Hint = "Initials", IsMandatory = true, Index = 0, Type = InputType.Text }}, parentForm: this);
            ResultType t = dialog.ShowIt();

            if (t == ResultType.OK)
            {
                Output initials = dialog.Output.Find(x => x.Name == "Initials");

                if (initials != null)
                {
                    string fileName = $"Refill_{DateTime.Now.ToString("MMddyy")}_{DateTime.Now.ToString("hhmmss")}.txt";


                    Settings s = JsonConvert.DeserializeObject<Settings>(Properties.Settings.Default.Data);

                    if (s.FacilityName == null)
                        s.FacilityName = "";

                    string content = $"Source: Refill Manager\r\n" +
                                     $"Facility: {s.FacilityName}\r\n" +
                                     $"Type: Refill\r\n" +
                                     $"Initials: {initials.Value}\n" +
                                     $"Rx-Number\n";

                    foreach (DataGridViewRow row in dgvRequestExtraDoseData.Rows)
                    {

                        content += $"{row.Cells[0].Value}\n";

                    }

                    File.WriteAllText(fileName, content);
                    Enable(false);
                    bool result = await Notification.Alert(fileName);

                    if (result)
                    {
                        MessageBox.Show($"Your Response is sent! Thank You {initials.Value}!", "Response Sent!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Unable to send response!\nPlease contact admin!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    Enable(true);
                }
            }
        }

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Please Enter Atleast One Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            InputDialog dialog = new InputDialog("Agent Name", new List<Input>() { new Input() { Name = "FN", Hint = "First Name", IsMandatory = true, Index = 0, Type = InputType.Text }, new Input() { Name = "LN", Hint = "Last Name", IsMandatory = true, Index = 1, Type = InputType.Text } }, parentForm: this);
            ResultType t = dialog.ShowIt();

            if (t == ResultType.OK)
            {
                string fn = dialog.Output.Find(x => x.Name.Equals("FN")).Value;
                string ln = dialog.Output.Find(x => x.Name.Equals("LN")).Value;

                string fileName = $"DME_{DateTime.Now.ToString("MMddyy")}_{DateTime.Now.ToString("hhmmss")}.txt";


                Settings s = JsonConvert.DeserializeObject<Settings>(Properties.Settings.Default.Data);

                if (s.FacilityName == null)
                    s.FacilityName = "";

                string content = $"Source: Refill Manager\r\n" +
                                 $"Facility: {s.FacilityName}\r\n" +
                                 $"Type: DME\r\n" +
                                 $"Rx-Number\tQty\tAgent_Name\n";

                foreach (DataGridViewRow row in dgvRefillDME.Rows)
                {

                    content += $"{row.Cells[0].Value}\t{row.Cells[1].Value}\t{fn} {ln}\n";

                }

                File.WriteAllText(fileName,content);

                Enable(false);
                bool result = await Notification.Alert(fileName);

                if (result)
                {
                    MessageBox.Show($"Your Response is sent! Thank You {fn} {ln}!", "Response Sent!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Unable to send response!\nPlease contact admin!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                Enable(true);
            }
        }

        private async void btnRED_Click(object sender, EventArgs e)
        {
            if (dgvRequestExtraDoseData.RowCount == 0)
            {
                MessageBox.Show("Please Enter Atleast One Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                Settings s = JsonConvert.DeserializeObject<Settings>(Properties.Settings.Default.Data);

                if (s.FacilityName == null)
                    s.FacilityName = "";

                string content = $"Source: Refill Manager\r\n" +
                                 $"Facility: {s.FacilityName}\r\n" +
                                 $"Type: Extra\r\n" +
                                 $"Initials: {initials.Value}\n" +
                                 $"Rx-Number\tQty\n";

                foreach (DataGridViewRow row in dgvRequestExtraDoseData.Rows)
                {

                    content += $"{row.Cells[0].Value}\t{row.Cells[1].Value}\n";

                }

                File.WriteAllText(fileName, content);
                Enable(false);
                bool result = await Notification.Alert(fileName);

                if (result)
                {
                    MessageBox.Show($"Your Response is sent! Thank You {initials.Value}!", "Response Sent!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Unable to send response!\nPlease contact admin!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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
