/*
** 
** User: DJ
** Date: 1/1/2010
** Time: 7:20 pm
*/

using System;
using System.Windows.Forms;
using System.IO;

namespace BF2_M0dd3r
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length <= 0)
                Application.Run(new BF2Modder(args));
            else
            {
                foreach (string argument in args)
                {
                    switch (argument)
                    {
                        case "botswap":
                            Application.Run(new BF2BotSwap());
                            break;

                        case "tickit":
                            Application.Run(new BF2TickIT());
                            break;

                        case null:
                            Application.Run(new BF2Modder(args));
                            break;

                        case "":
                            Application.Run(new BF2Modder(args));
                            break;

                        default:
                            Application.Run(new pluginRunner(argument));
                            break;
                    }

                }
            }

            
		}
		
	}
}
