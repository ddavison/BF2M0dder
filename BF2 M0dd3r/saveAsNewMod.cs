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
    public partial class saveAsNewMod : Form
    {
        string modName;

        public saveAsNewMod(string nm)
        {
            InitializeComponent();

            //nm = Objects_server(modname).zip

            modName = nm.Replace("Objects_server(", "");

            //modName = modname).zip

            modName = modName.Remove(modName.Length - 5, 5);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            modName = textBox1.Text;

            DialogResult = DialogResult.OK;

        }

        private void cancelButtton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public string getModName()
        {
            return modName;
        }

        private void saveAsNewMod_Load(object sender, EventArgs e)
        {
            if (modName == "")
            {

            }
            else
                textBox1.Text = modName;
        }
    }
}
