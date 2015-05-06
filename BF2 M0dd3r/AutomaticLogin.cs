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
    public partial class AutomaticLogin : Form
    {
        string addFile;
        BF2MConstants _const = new BF2MConstants();

        string appDir;

        public AutomaticLogin()
        {
            InitializeComponent();
            appDir = _const.InstallPath;
        }

        List<string> dirs = new List<string>();
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            addFile = appDir + "\\add_para.cfg";

            //clicked ok...

            //append to addFile... the stuff...

            if (localAccount.Checked)
            {
                if (avaNames.Text != "")
                {
                    File.AppendAllText(addFile, " +playerName " + avaNames.Text);

                    string[] content = {avaNames.Text, dirs[avaNames.SelectedIndex]};
                    
                    File.WriteAllLines(appDir + "\\bf2profname.cfg", content);

                    DONE done = new DONE();
                    done.ShowDialog();

                    this.Close();
                }
                else
                    MessageBox.Show("Please select your Battlefield 2 Profile name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (internetAccount.Checked)
            {
                if (avaNames.Text != "" && passwordTextBox.Text != "")
                {
                    File.AppendAllText(addFile, " +playerName " + avaNames.Text + " +playerPassword " + passwordTextBox.Text);

                    DONE done = new DONE();
                    done.ShowDialog();

                    this.Close();
                }
                else
                    MessageBox.Show("Please select your Battlefield 2 Profile name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void localAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (localAccount.Checked)
            {
                passwordTextBox.Clear();
                passwordTextBox.Enabled = false;
            }
        }

        private void internetAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (internetAccount.Checked)
            {
                passwordTextBox.Enabled = true;
            }
        }

        private void AutomaticLogin_Load(object sender, EventArgs e)
        {
            try
            {
                avaNames.Focus();

                
                string proflesFolder = (System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\Battlefield 2\\Profiles");
                //now they could have 001 002 003, so lets do this...

                DirectoryInfo profilesFolder = new DirectoryInfo(proflesFolder);

                foreach (DirectoryInfo di in profilesFolder.GetDirectories())
                {
                    if (di.Name.StartsWith("0"))
                    {
                        dirs.Add(di.Name);

                        string path = di.FullName + "\\Profile.con"; // now s C:\Users\douche\Documents\Battlefield 2\Profiles\0001\Profile.con
                        //k, now read the Profile.con...
                        string[] fileLines = File.ReadAllLines(path);

                        foreach (string line in fileLines)
                        {
                            if (line.Contains(".setName"))
                            {
                                //get the name between the ""....

                                string profileName = line.Remove(0, line.IndexOf('"'));

                                avaNames.Items.Add(profileName.Replace("\"", String.Empty));
                            }
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
