using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class bugReport : Form
    {
        BF2MConstants _const = new BF2MConstants();

        public bugReport()
        {
            InitializeComponent();
        }

        private void bugReport_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (txtSubject.Text == "" && txtMessage.Text == "")
            {
                _const.handleError("You need to fill out the fields!", false);
            }
            else
            {
                _const.emailReport("BF2 Modder", "This is a bug report sent from BF2 Modder.<br /><br />Topic:<br /><b>" + txtSubject.Text + "</b>.<br /><br />Message:<br />" + txtMessage.Text + "&nbsp;&nbsp;");
                _const.alert("Thank you for submitting your bug report!\n\nThe Staff at sircapsalot.NET will examine the issue and act accordingly.");
                this.Close();
            }
            this.Cursor = System.Windows.Forms.Cursors.Arrow;

            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
