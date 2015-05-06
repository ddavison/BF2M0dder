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
    public partial class BF2BotSwap : Form
    {
        public BF2BotSwap()
        {
            InitializeComponent();
        }

        string easy = "0.1";
        string veteran = "0.5";
        string expert = "1.0";


        private void btnApply_Click(object sender, EventArgs e)
        {
            //get the numBots...
            int botNum = Convert.ToInt32(numBots.Value);

            if (difEasy.Checked)
            {
                //applyeasymod

                applyMod(easy, botNum);
                
            }
            else
            {
                if (difVet.Checked)
                {
                    //applyvetmod
                    applyMod(veteran, botNum);
                }
                else
                {
                    if (difExpert.Checked)
                    {
                        applyMod(expert, botNum);
                    }
                }
            }
        }
        
        void applyMod(string difficulty, int numberOfBots)
        {
            if (File.Exists(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg"))
            {
                string tt = File.ReadAllText(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg");

                if (tt == String.Empty)
                {
                    MessageBox.Show("Please import the archive in BF2 M0dd3r before you use BF2 BotSwap.", "BF2 BotSwap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {

                    string diff = "{DIFFICULTY}";
                    string num = "{NUMBOTS}";

                    int start = txt.Find(diff);

                    txt.Select(start, diff.Length);

                    Clipboard.SetText(difficulty);

                    txt.Paste();

                    start = txt.Find(num);

                    txt.Select(start, num.Length);

                    Clipboard.SetText(numberOfBots.ToString());

                    txt.Paste();

                    string aifile = tt + "\\mods\\bf2modder\\AI\\AIDefault.ai";

                    //apply code in here...

                    if (!File.Exists(aifile))
                    {
                        StreamWriter sw = new StreamWriter(aifile);
                        foreach (string lin in txt.Lines)
                        {
                            sw.WriteLine(lin);
                        }
                        sw.Close();
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(aifile);
                        foreach (string lin in txt.Lines)
                        {
                            sw.WriteLine(lin);
                        }
                        sw.Close();
                    }
                   


                    //-----

                    DONE done = new DONE();
                    done.ShowDialog();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please import the archive in BF2 M0dd3r before you use BF2 BotSwap.", "BF2 BotSwap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BF2BotSwap_Load(object sender, EventArgs e)
        {
            string bf2pathFile = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg";

            if (File.Exists(bf2pathFile))
            {

            }
            else
            {
                MessageBox.Show("Please load the archive in BF2M first.");
                this.Close();
            }

            numBots.Focus();
        }

        private void numBots_Click(object sender, EventArgs e)
        {
            numBots.Select();
        }

    }
}
