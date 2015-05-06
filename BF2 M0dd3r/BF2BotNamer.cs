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
    public partial class BF2BotNamer : Form
    {
        public BF2BotNamer()
        {
            InitializeComponent();
        }

        private void addBotButton_Click(object sender, EventArgs e)
        {
            addBot();
        }

        private void addBot()
        {
            string newBotName = botNameTextBox.Text;

            try
            {
                if (newBotName == "")
                {
                    botNameTextBox.Focus();
                }
                else
                {
                    // it has a value

                    if (botNamesListBox.Items.Contains(newBotName))
                    {
                        // already contains it.
                    }
                    else
                    {

                        int newIndex = botNamesListBox.Items.Add(newBotName);

                        

                        botNameTextBox.Clear();
                        botNameTextBox.Focus();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Encountered an unknown error!\n\n\t" + x.Message);
            }
        }

        private void botNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBot();
            }
            else
            {
                // do nothin
            }
        }

        private void botNamesListBox_Click(object sender, EventArgs e)
        {
            // when they click, it deletes the bot name.

            botNamesListBox.Items.Remove(botNamesListBox.SelectedItem);
            botNameTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!useDefaultBotNames.Checked)
                {
                    string[] botNames = new string[botNamesListBox.Items.Count];

                    for (int i = 0 ; i < botNamesListBox.Items.Count ; i++)
                    {
                        botNames[i] = "aiSettings.addBotName " + botNamesListBox.Items[i].ToString();
                    }

                    // after array is written, write to the file...

                    File.WriteAllLines(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\BotNames.cfg", botNames);
                }
                else
                {
                    // they want default bots...
                    string[] botNames = new string[botNamesListBox.Items.Count];
                    botNames[0] = "rem (using default)";

                    if (botNamesListBox.Items.Count == 0)
                    {

                    }
                    else
                    {
                        for (int i = 1 ; i < botNamesListBox.Items.Count ; i++)
                        {
                            botNames[i] = "aiSettings.addBotName " + botNamesListBox.Items[i].ToString();
                        }
                    }
                    // after array is written, write to the file...

                    File.WriteAllLines(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\BotNames.cfg", botNames);
                }

                
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("There was an error writing the botnames file!\n\n\t" + x.Message, "BF2 BotNamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BF2BotNamer_Load(object sender, EventArgs e)
        {
            try
            {
                string selPath = File.ReadAllText(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg");

                if (selPath == "")
                {
                    MessageBox.Show("Load the archive before you launch BF2 BotNamer!", "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }
                else
                {
                    if (File.Exists(selPath + "\\mods\\bf2modder\\AI\\BotNames(backup).ai"))
                        File.Copy(selPath + "\\mods\\bf2modder\\AI\\BotNames.ai", selPath + "\\mods\\bf2\\AI\\BotNames(backup).ai", true);

                    string[] botNames = File.ReadAllLines(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\BotNames.cfg");

                    if (botNames[0].Contains("rem"))
                    {
                        useDefaultBotNames.Checked = true;

                        if (botNames.Length > 1)
                        {
                            for (int i = 1 ; i < botNames.Length ; i++)
                            {
                                botNamesListBox.Items.Add(botNames[i].Remove(0, "aiSettings.addBotName ".Length));
                            }
                        }
                    }
                    else
                    {
                        useDefaultBotNames.Checked = false;

                        for (int i = 0 ; i < botNames.Length ; i++)
                        {
                            botNamesListBox.Items.Add(botNames[i].Remove(0, "aiSettings.addBotName ".Length));
                        }
                    }
                    botNameTextBox.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("There was an error on BF2 BotNamer Startup!" + x.Message, "BF2 BotNamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "";

            message += "BF2 BotNamer\n--------------";
            message += "\nThis tool allows you to change the names of your bots.\n\nInstructions:\n\n";
            message += "\t- Fill in the text box, the name that you want to name the bot, Then press ENTER or click + to add the bot name.\n";
            message += "\t- Once pressed, it will add the bot name to the list. (The list contains all of the bot names you have set.)\n";
            message += "\t - If you would like to use the default bot names, check the \"Use Default Bot Names\" and press ok.";

            MessageBox.Show(message, "BF2 BotNamer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void useTimer_Tick(object sender, EventArgs e)
        {
            if (useDefaultBotNames.Checked)
            {
                // if it is checked, disable both of them ...
                botNamesGroupBox.Enabled = false;
                addBotGroupBox.Enabled = false;
            }
            else
            {
                botNamesGroupBox.Enabled = true;
                addBotGroupBox.Enabled = true;
            }
        }

    }
}
