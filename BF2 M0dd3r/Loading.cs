/*
 * Created by SharpDevelop.
 * User: DJ
 * Date: 1/21/2010
 * Time: 5:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
	/// <summary>
	/// Description of Loading.
	/// </summary>
	public partial class Loading : Form
	{
		public Loading()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LoadingLoad(object sender, EventArgs e)
		{
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			//increment.
			if ( progressBar1.Value != progressBar1.Maximum )
            {
                progressBar1.Increment(20);
			}
            else
                this.Close();
			
			
		}
	}
}
