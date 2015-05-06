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
    public partial class Saving_File : Form
    {
        public Saving_File()
        {
            InitializeComponent();
        }

        private void Saving_File_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {

                progressBar1.Increment(20);
            }
            else
                this.Close();
        }
    }
}
