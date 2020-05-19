using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UBTStandardLibrary.Dialog;

namespace RefillManager
{
    public partial class DmeInput : UBTStandardLibrary.Forms.N1Form
    {
        public ResultType ResultType { get; private set; }
        private bool isExit = true;
        public DmeInput()
        {
            InitializeComponent();
            this.Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            if (isExit)
                ResultType = ResultType.Exit;
            e.Cancel = true;
            this.Hide();
        }

        private void DmeInput_Load(object sender, EventArgs e)
        {

        }

        public string Result { get; set; }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            isExit = false;
            ResultType = ResultType.OK;
            Result = (txtFirstName.isEmptyOrHint() ? "" : txtFirstName.Text) + " "+
                     (txtLastName.isEmptyOrHint() ? "" : txtLastName.Text);
            Hide();
        }
    }
    
}
