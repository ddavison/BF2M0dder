using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using Microsoft.Win32;

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
                fileZipFile = InstallPath + "\\tmp\\Objects_server.zip";
                dirTmpDirectory = InstallPath + "\\tmp";

                fileAddFile = InstallPath + "\\add_para.cfg";
                fileBotNamesFile = InstallPath + "\\BotNames.cfg";
                fileConfigFile = InstallPath + "\\bf2path.cfg";
                fileNetFile = InstallPath + "\\network.cfg";
                fileSplashFile = InstallPath + "\\skipSplash.cfg";
            }
            catch
            {
            }
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

        public string fileAddFile;

        public string fileNetFile;

        public string fileConfigFile;

        public string fileBotNamesFile;

        public string fileSplashFile;
        public string dirRestoreDirectory;

    }
}
