using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;

using System.Text;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class LANServer : Form
    {
        public LANServer()
        {
            InitializeComponent();
        }

        private void LANServer_Load(object sender, EventArgs e)
        {
            ipAddressTextBox.Focus();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "This tool allows you to take advantage of playing with a friend, via Local Area connection on a single player server.\n\n";
            message = message + "How to play:\n--------------------------\n\n";
            message = message + "Have the host of the game, simply start a single player map, and then YOU, from BF2 M0dd3r, fill in the provided IP address field.";
            message = message + "Once applied, if you Launch BF2 from BF2 M0dd3r, you will automatically connect to the server.";

            MessageBox.Show(message, "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ipAddressTextBox.Text != "")
            {
                File.AppendAllText(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\add_para.cfg", " +joinServer " + ipAddressTextBox.Text);
                DONE done = new DONE();

                done.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Enter an IP of a local computer or click Cancel", "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
