using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class Participation : Form
    {
        public Participation()
        {
            InitializeComponent();
        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {
            fullName.Text = fullName.Text.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (fullName.Text == "")
                {
                    MessageBox.Show("Please enter your name first...");
                }
                else
                {
                    File.WriteAllText(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\nm.cfg", fullName.Text.ToUpper());
                    File.WriteAllText(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\participation.cfg", "part");

                    MessageBox.Show("Thank you for participating!");

                    this.Close();
                }
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
