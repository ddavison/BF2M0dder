using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class Copying : Form
    {
        string sFrom = "";
        string sTo = "";
        
        public Copying(string from, string to)
        {
            InitializeComponent();

            sFrom = from;

            sTo = to;
        }

        void copyMod(string from, string to)
        {
            try
            {
                File.Copy(from, to);
            }
            catch (Exception x)
            {
                x.ToString();
                MessageBox.Show("The network m0d is not available!", "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Copying_Load(object sender, EventArgs e)
        {
            copier.RunWorkerAsync();
        }

        private void copier_DoWork(object sender, DoWorkEventArgs e)
        {
            copyMod(sFrom, sTo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                copier.CancelAsync();
            }
            catch
            {
            }
        }

        private void copier_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Text = "Complete!";
            progressBar1.Visible = false;
            label1.Visible = false;

            this.Close();
        }
    }
}
