using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace BF2_M0dd3r
{
    class BF2MConstants
    {

        public BF2MConstants()
        {
            RegistryKey instPath = Registry.LocalMachine;

            RegistryKey sk = instPath.OpenSubKey("SOFTWARE\\sircapsalot.net\\BF2Modder");

            try
            {
                InstallPath = (string)sk.GetValue("installPath");

                dirModsDirectory = InstallPath + "\\mods";
                dirPluginsDirectory = InstallPath + "\\_plugins_";
                dirSharedDirectory = InstallPath + "\\_shared_";
                dirRestoreDirectory = InstallPath + "\\_restore_";
                dirTmpDirectory = InstallPath + "\\tmp";

                fileZipFile = InstallPath + "\\tmp\\Objects_server.zip";
                fileAddFile = InstallPath + "\\add_para.cfg";
                fileBotNamesFile = InstallPath + "\\BotNames.cfg";
                fileConfigFile = InstallPath + "\\bf2path.cfg";
                fileNetFile = InstallPath + "\\network.cfg";

                fileEditorFont = InstallPath + "\\editorFont.cfg";

                string[] fnt = File.ReadAllLines(fileEditorFont);
                float emSize = Convert.ToInt64(fnt[1]);
                editorFont = new Font(fnt[0], emSize); // fnt[0] will be string[familyname] and ftn[1] = float emSize.

                userName = File.ReadAllText(InstallPath + @"\nm.cfg");
            }
            catch
            {

            }

            writePath();
        }

        public string InstallPath
        {
            get;
            set;
        }

        public string dirPluginsDirectory;
        public string dirModsDirectory;

        public string dirTmpDirectory;

        public string dirSharedDirectory;

        public string fileZipFile;

        protected NetworkCredential creds = new NetworkCredential("no-reply@sircapsalot.net", "nopass");

        private MailAddress fromAddress = new MailAddress("no-reply@sircapsalot.net", "sircapsalot.NET Support Service");
        private MailAddress toAddress = new MailAddress("support@sircapsalot.net");

        public string fileAddFile;

        public string fileEditorFont;
        public Font editorFont; // the font the editor will use.

        public string fileNetFile;

        private string userName = "";

        public string fileConfigFile;

        public string fileBotNamesFile;
        public string dirRestoreDirectory;

        private void writePath()
        {
            if (!File.Exists(InstallPath + "\\" + "dev.cfg"))
                File.WriteAllText(InstallPath + "\\" + "dev.cfg", InstallPath); //this writes the path to yea...
        }

        public void updateFont()
        {
            string[] fnt = File.ReadAllLines(fileEditorFont);
            float emSize = Convert.ToInt64(fnt[1]);
            editorFont = new Font(fnt[0], emSize); // fnt[0] will be string[familyname] and ftn[1] = float emSize.
        }

        public void handleError(string message, bool isVital)
        {
            try
            {
                MessageBoxEx.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (isVital)
                {
                    // al this will do is email me if they are in the program... first check...
                    if (File.Exists(@"participation.cfg"))
                    {
                        if (File.ReadAllText(@"participation.cfg") != "")
                        {
                            emailReport(userName, message);
                        }
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception x)
            {
                emailReport("BF2 Modder", "handleError() didn't work?!?!?!?!" + x.Message);
            }
        }

        public void alert(string message)
        {
            try
            {
                MessageBoxEx.Show(message, "BF2 Modder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                handleError(x.Message, true);
            }
        }

        public bool emailReport(string whoFrom, string errorMessage)
        {
            try
            {

                MailMessage mailMessage = new MailMessage(fromAddress.Address, toAddress.Address, "BF2 Modder Participation Program", "<b>From: " + whoFrom + "</b><br /><br /><br />" + errorMessage);

                mailMessage.IsBodyHtml = true;

                SmtpClient mailClient = new SmtpClient("smtp.sircapsalot.net", 587);
                mailClient.Credentials = creds;


                mailClient.Send(mailMessage);

                return true;
            }
            catch (Exception x)
            {
                handleError(x.Message, true);
            }
            return false;
        }

    }
}
