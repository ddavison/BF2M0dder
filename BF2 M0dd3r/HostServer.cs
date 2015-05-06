using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class HostServer : Form
    {
        public HostServer()
        {
            InitializeComponent();
        }

        private void HostServer_Load(object sender, EventArgs e)
        {
            try
            {

                string selPath = File.ReadAllText(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg");

                if (selPath == "")
                {
                    MessageBox.Show("Please import the archive before hosting with BF2 M0dd3r.", "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    string addFile = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\add_para.cfg";

                    string txt = File.ReadAllText(addFile);
                    
                    if (txt.Contains("loadLevel"))
                    {
                        string[] nn = txt.Split(new char[1] { '+' });

                        string newtxt = "";

                        foreach (string n in nn)
                        {

                            if (n.Contains("loadLevel"))
                            {
                                txt = txt.Replace("+" + n, "");
                            }

                            if (n.Contains("gameMode"))
                            {
                                txt = txt.Replace("+" + n, "");
                            }
                        }
                        newtxt = txt;

                        File.WriteAllText(addFile, newtxt);
                    }

                    DirectoryInfo di = new DirectoryInfo(selPath + "\\mods\\bf2\\Levels");

                    foreach (DirectoryInfo d in di.GetDirectories())
                    {
                        levelComboBox.Items.Add(d.Name);
                    }

                    IPHostEntry ipEntry = Dns.GetHostByName(Dns.GetHostName());

                    IPAddress[] addr = ipEntry.AddressList;

                    this.Text = "Host BF2 M0dd3r LAN Server - " + addr[0].ToString();

                    levelComboBox.Text = "Dalian_plant";
                }
            }
            catch
            {
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {

                // after they click ok, put in the add_para.cfg, +loadLevel levelComboBox.Text

                File.AppendAllText(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\add_para.cfg", " +loadLevel " + levelComboBox.Text + " +gameMode sp1 +ai 1 ");

            }
            catch
            {
                MessageBox.Show("Could not prepare the BF2 LAN Server...", "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
