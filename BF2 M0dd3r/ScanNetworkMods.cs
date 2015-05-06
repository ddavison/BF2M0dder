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
    public partial class ScanNetworkMods : Form
    {
        public string messageString = "";

        XMLParser config = new XMLParser();

        public ScanNetworkMods()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            appendMessage("\n\n\t - The computer you are specifying must have BF2 M0dd3r installed, and working in networked mode (BF2 M0dd3r does not have to be running on target)");
            appendMessage(" - BF2 M0dd3r Shared M0ds must be accessible by BF2 M0dd3r (check the sharing options and access)");

            MessageBox.Show("Requirement..." + messageString);
        }

        private void appendMessage(string msg)
        {
            messageString = messageString + "\t\n";
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScanNetworkMods_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }


        //SEARCH NETWORK...

        private void searchNetwork(string networkedComputerName) // SIRCAPSALOT
        {
            string networkFolder = "";

            if (networkedComputerName.StartsWith(@"\\"))
            {
                networkFolder = networkedComputerName + @"\BF2 M0dd3r Shared M0ds";
            }
            else
            {
                networkFolder = @"\\" + networkedComputerName + @"\BF2 M0dd3r Shared M0ds";
            }

            // add a network field...

            try
            {
                DirectoryInfo networkMods = new DirectoryInfo(networkFolder);

                foreach (FileInfo fi in networkMods.GetFiles("*.zip"))
                {
                    //add to the networkedModsMenu drop down...

                    
                }
            }
            catch (Exception x)
            {
                x.ToString();
            }
        }
    }
}
