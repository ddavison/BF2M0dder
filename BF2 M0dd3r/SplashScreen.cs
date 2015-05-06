/*
** 
** User: DJ
** Date: 1/14/2010
** Time: 3:16 pm
*/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace BF2_M0dd3r
{
    /// <summary>
    /// Description of SplashScreen.
    /// </summary>
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        BF2MConstants _const = new BF2MConstants();

        private string appDir, supportSitePage;

        void Timer1Tick(object sender, EventArgs e)
        {
            if (!this.Focused)
            {
                this.Focus();
            }
        }

        void SplashScreenLoad(object sender, EventArgs e)
        {
            lblVersion.Text = "v." + Application.ProductVersion.ToString();

            appDir = _const.InstallPath;

            supportSitePage = appDir + "\\support_site.htm";

        }

        void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(supportSitePage);
            }
            catch
            {
                MessageBox.Show("Please go to http://www.sircapsalot.net/support/ to submit a support ticket.");
            }
        }

        private void close(object sender, EventArgs e)
        {
            //if the form is clicked...
            


            if (!checkBox1.Checked)
            {
                File.WriteAllText(appDir + "\\skipSplash.cfg", "true");
            }

            this.Close();
        }

        private void cll(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.Checked)
            {
                case true:
                    //it is checked, so uncheck it...
                    checkBox1.Checked = true;
                    break;

                case false:
                    checkBox1.Checked = false;
                    MessageBox.Show("Enable this dialog again by viewing the \"Options\" in BF2Modder.", "BF2Modder");
                    break;

                default:
                    checkBox1.Checked = false;
                    break;
            }
        }
    }
}