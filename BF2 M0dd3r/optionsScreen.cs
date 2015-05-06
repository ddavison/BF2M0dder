using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class optionsScreen : Form
    {

        BF2MConstants _const = new BF2MConstants();

        public optionsScreen()
        {
            InitializeComponent();

        }


        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void chkShowStartupDialog_CheckedChanged(object sender, DevComponents.DotNetBar.CheckBoxChangeEventArgs e)
        {
        }

        private void chkShowStartupDialog_Click(object sender, EventArgs e)
        {

        }

        private void optionsScreen_Load(object sender, EventArgs e)
        {
            popEdit();
        }

        void popEdit()
        {

        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            try
            {
                editorFont.ShowDialog();
            }
            catch (Exception x)
            {
                _const.handleError("Could not apply the font you selected.\n\n Did you select a non true-type font?", false);
            }
        }

        private void editorFont_Apply(object sender, EventArgs e)
        {
            MessageBox.Show("doing it");
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            string[] fnt = File.ReadAllLines(_const.fileEditorFont);

            lblFontName.Text = fnt[0];
            lblFontSize.Text = fnt[1];
        }
    }
}
