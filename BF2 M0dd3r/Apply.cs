/*
 * Created by SharpDevelop.
 * User: DJ
 * Date: 1/23/2010
 * Time: 12:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
	/// <summary>
	/// Description of Apply.
	/// </summary>
	public partial class Apply : Form
	{
        string modName = "";

        string conf = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg";
        string path = "";


		public Apply(string modNm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            modName = modNm;
            
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		

        private void Apply_Load(object sender, EventArgs e)
        {
            path = File.ReadAllText(conf);

            try
            {
                if (File.Exists(conf))
                {
                    

                    if (path == "")
                    {
                        MessageBox.Show("You have to Load the Archive before you apply a mod.", "BF2 M0dd3r ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {



                        File.Copy(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\mods\" + modName, path + "\\mods\\bf2modder\\Objects_server.zip", true);

                        if (!File.Exists(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\currentMod.cfg"))
                            File.Create(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\currentMod.cfg");

                        File.WriteAllText(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\currentMod.cfg", modName);

                        timer1.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("You have to Load the Archive before you apply a mod.", "BF2 M0dd3r ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                


            }
            catch ( Exception x )
            {
                MessageBox.Show("There was an error trying to apply the mod. Please email this error report to support@sircapsalot.net \n :: " + x.Message, "BF2 M0dd3r ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            this.Text = "M0d Applied!";

            timer1.Enabled = false;

            System.Threading.Thread.Sleep(1000);

            this.Close();
        }
	}
}
