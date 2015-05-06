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
    public partial class RestoreUtility : Form
    {
        public RestoreUtility()
        {
            InitializeComponent();
        }

        string selPath = "";

        private void RestoreUtility_Load(object sender, EventArgs e)
        {
            if ( File.Exists( @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg" ) )
            {
                selPath = File.ReadAllText( @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg" );

                if ( selPath == "" )
                {
                    MessageBox.Show( "You only use the restore utility when using BF2 M0dd3r.", "BF2 Restore Utility", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show( "You only use the restore utility when using BF2 M0dd3r.", "BF2 Restore Utility", MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.Close();
            }
        }

        private void man_Tick ( object sender, EventArgs e )
        {
            //if (rest.TopNode.Checked == true)
            //{
            //    selectAll(true);
            //}
            //else
            //    selectAll(false);

            //if (rest.TopNode.Nodes[0].Checked == true)
            //{
            //    selectLevels(true);
            //}
            //else
            //    selectLevels(false);

            //if (rest.TopNode.Nodes[1].Checked == true)
            //{
            //    selectCore(true);
            //}
            //else
            //    selectCore(false);
        }

        private void btnRestoreAll_Click ( object sender, EventArgs e )
        {
        }






        //RESTORE

        bool restore ( int restoreOption, string localName, string destName )
        {
            switch ( restoreOption )
            {
                case 0:
                    //Restore a file (with localName) to destName...
                                                
                    break;

                case 1:
                    //restore ALL

                    break;

                case 2:
                    //Restore all core files

                    break;

                case 3:
                    //Restore all Levels

                    break;
            }

            return false;
        }
    }
}
