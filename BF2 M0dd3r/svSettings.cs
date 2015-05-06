using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace BF2_M0dd3r
{
    [DefaultPropertyAttribute("ServerName")]
    class svSettings
    {

        #region "globals"
            BF2MConstants _const = new BF2MConstants();
            string playerFile = "bf2profname.cfg";
            string[] playerFileLines = null;

            string playerName = "";

            List<string> newContent = new List<string>();

            string configFile = "";
            string[] configFileLines = null;

        #endregion

        public svSettings()
        {
            //try
            //{
                playerFile = _const.InstallPath + "\\" + playerFile;

                if (!File.Exists(playerFile))
                {
                    MessageBox.Show("Keep in mind that you will not be able to use the server settings until you configure the \"Auto-Login\" Feature.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    playerName = File.ReadAllText(playerFile);

                    playerFileLines = File.ReadAllLines(playerFile);

                    configFile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Battlefield 2\\Profiles\\" + playerFileLines[1] + "\\ServerSettings.con";

                    configFileLines = File.ReadAllLines(configFile);

                    fillProperties();
                }
        //    }
        //    catch (Exception x)
        //    {
        //        MessageBox.Show(x.Message);
        //    }
        }

        private void fillProperties()
        {
            //try
            //{
                File.ReadAllLines(playerFile);

                ServerName = getValue("setServerName");
                ServerPassword = getValue("setServerPassword");
                SpawnTime = Int32.Parse(getValue("setSpawnTime"));
                MaxPlayers = Int32.Parse(getValue("setMaxPlayers"));
                TicketRatio = Int32.Parse(getValue("setTicketRatio"));
                TeamRatio = Int32.Parse(getValue("setTeamRatio"));

                if (getValue("setAutoBalanceTeam") == "1")
                    AutoBalanceTeam = true;
                else
                    AutoBalanceTeam = false;

                ManDownTime = Int32.Parse(getValue("setManDownTime"));

                if (getValue("setPunishTeamKills") == "1")
                    PunishTeamKills = true;
                else
                    PunishTeamKills = false;

                RoundsPerMap = Int32.Parse(getValue("setRoundsPerMap"));
                RoundTimeLimit = Int32.Parse(getValue("setTimeLimit"));
                RoundScoreLimit = Int32.Parse(getValue("setScoreLimit"));

                if (getValue("setNoVehicles") == "1")
                    NoVehicles = true;
                else
                    NoVehicles = false;

                if (getValue("setVotingEnabled") == "1")
                    VotingEnabled = true;
                else
                    VotingEnabled = false;

                VoteTime = Int32.Parse(getValue("setVoteTime"));
                MinimumPlayersToVote = Int32.Parse(getValue("setMinPlayersForVoting"));

                if (getValue("setTeamVoteOnly") == "1")
                    TeamVoteOnly = true;
                else
                    TeamVoteOnly = false;

                if (getValue("setSvPunkBuster") == "1")
                    PunkBusterEnabled = true;
                else
                    PunkBusterEnabled = false;

                SoldierFF = Int32.Parse(getValue("setSoldierFF"));
                VehicleFF = Int32.Parse(getValue("setVehicleFF"));
                SoldierSplashFF = Int32.Parse(getValue("setSoldierSplashFF"));
                VehicleSplashFF = Int32.Parse(getValue("setVehicleSplashFF"));

                if (getValue("setVoipEnabled") == "1")
                    VoIPEnabled = true;
                else
                    VoIPEnabled = false;

                VoIPQuality = Int32.Parse(getValue("setVoipQuality"));
                VoIPServerRemote = getValue("setVoipServerRemote");
                VoIPServerRemoteIP = getValue("setVoipServerRemoteIP");
                VoIPServerPort = Int32.Parse(getValue("setVoipServerPort"));
                VoIP_BF_ClientPort = Int32.Parse(getValue("setVoipBFClientPort"));
                VoIP_BF_ServerPort = Int32.Parse(getValue("setVoipBFServerPort"));
                VoIPSharedPassword = getValue("setVoipSharedPassword");
            //}
            //catch (Exception x)
            //{
            //    System.Windows.Forms.MessageBox.Show(x.Message);
            //}
        }

        private string getValue(string valueToGet)
        {
            foreach (string line in configFileLines)
            {
                if (line.Contains(valueToGet))
                {
                    string vl = (line.Remove(0, ("GameServerSettings.".Length + valueToGet.Length + 1)));

                    if (vl.Contains("\""))
                    {

                        vl = vl.Replace("\"", "");
                    }

                    return vl;
                }
            }
            return "";
        }

        private void writeValue(string bfValue, string propertyValue)
        {

            string gs = "GameServerSettings.";

            newContent.Add(gs + bfValue + " \"" + propertyValue + "\"");
        }

        private void writeValue(string bfValue, bool propertyValue)
        {
            string gs = "GameServerSettings.";

            string actualValue;

            if (propertyValue)
                actualValue = "1";
            else
                actualValue = "0";
            

            newContent.Add(gs + bfValue + " " + actualValue);
        }

        private void writeValue(string bfValue, int propertyValue)
        {

            string gs = "GameServerSettings.";

            newContent.Add(gs + bfValue + " " + propertyValue.ToString());
        }


        [CategoryAttribute("1 Primary Server Settings")]
        public string ServerName
        {
            get;
            set;
        }
        [CategoryAttribute("1 Primary Server Settings")]
        public string ServerPassword
        {
            get;
            set;
        }
        [CategoryAttribute("1 Primary Server Settings")]
        public int SpawnTime
        {
            get;
            set;
        }

        [CategoryAttribute("2 Secondary Server Settings")]
        public int MaxPlayers
        {
            get;
            set;
        }
        [CategoryAttribute("2 Secondary Server Settings")]
        public int TicketRatio
        {
            get;
            set;
        }
        [CategoryAttribute("2 Secondary Server Settings")]
        public int TeamRatio
        {
            get;
            set;
        }
        [CategoryAttribute("2 Secondary Server Settings")]
        public bool AutoBalanceTeam
        {
            get;
            set;
        }
        [CategoryAttribute("2 Secondary Server Settings")]
        public int ManDownTime
        {
            get;
            set;
        }
        [CategoryAttribute("2 Secondary Server Settings")]
        public bool PunishTeamKills
        {
            get;
            set;
        }

        // ***** ROUND OPTIONS ***** \\

        [CategoryAttribute("3 Round Options")]
        public int RoundsPerMap
        {
            get;
            set;
        }

        // ***** SCORING ***** \\

        [CategoryAttribute("4 Scoring")]
        public int RoundTimeLimit
        {
            get;
            set;
        }
        [CategoryAttribute("4 Scoring")]
        public int RoundScoreLimit
        {
            get;
            set;
        }

        // ***** VEHICLE SETTINGS ***** \\

        [CategoryAttribute("5 Vehicle Settings")]
        public bool NoVehicles
        {
            get;
            set;
        }




        [CategoryAttribute("6 Voting Options")]
        public bool VotingEnabled
        {
            get;
            set;
        }
        [CategoryAttribute("6 Voting Options")]
        public int VoteTime
        {
            get;
            set;
        }
        [CategoryAttribute("6 Voting Options")]
        public int MinimumPlayersToVote
        {
            get;
            set;
        }
        [CategoryAttribute("6 Voting Options")]
        public bool TeamVoteOnly
        {
            get;
            set;
        }

        [CategoryAttribute("7 PunkBuster Options")]
        public bool PunkBusterEnabled
        {
            get;
            set;
        }

        [CategoryAttribute("8 FF Options")]
        public int SoldierFF
        {
            get;
            set;
        }
        [CategoryAttribute("8 FF Options")]
        public int VehicleFF
        {
            get;
            set;
        }
        [CategoryAttribute("8 FF Options")]
        public int SoldierSplashFF
        {
            get;
            set;
        }
        [CategoryAttribute("8 FF Options")]
        public int VehicleSplashFF
        {
            get;
            set;
        }

        [CategoryAttribute("9 VoIP Options")]
        public bool VoIPEnabled
        {
            get;
            set;
        }
        [CategoryAttribute("9 VoIP Options")]
        public int VoIPQuality
        {
            get;
            set;
        }
        [CategoryAttribute("9 VoIP Options")]
        public string VoIPServerRemote
        {
            get;
            set;
        }
        [CategoryAttribute("9 VoIP Options")]
        public string VoIPServerRemoteIP
        {
            get;
            set;
        }
        [CategoryAttribute("9 VoIP Options")]
        public int VoIPServerPort
        {
            get;
            set;
        }
        [CategoryAttribute("9 VoIP Options")]
        public int VoIP_BF_ClientPort
        {
            get;
            set;
        }
        [CategoryAttribute("9 VoIP Options")]
        public int VoIP_BF_ServerPort
        {
            get;
            set;
        }
        [CategoryAttribute("9 VoIP Options")]
        public string VoIPSharedPassword
        {
            get;
            set;
        }

        public void ApplySettings()
        {
            try
            {
                writeValue("setServerName", ServerName);
                writeValue("setServerPassword", ServerPassword);
                writeValue("setSpawnTime", SpawnTime);
                writeValue("setMaxPlayers", MaxPlayers);
                writeValue("setTicketRatio", TicketRatio);
                writeValue("setTeamRatio", TeamRatio);
                writeValue("setAutoBalanceTeam", AutoBalanceTeam);
                writeValue("setManDownTime", ManDownTime);
                writeValue("setPunishTeamKills", PunishTeamKills);
                writeValue("setRoundsPerMap", RoundsPerMap);
                writeValue("setRoundTimeLimit", RoundTimeLimit);
                writeValue("setRoundScoreLimit", RoundScoreLimit);
                writeValue("setNoVehicles", NoVehicles);
                writeValue("setVotingEnabled", VotingEnabled);
                writeValue("setVoteTime", VoteTime);
                writeValue("setMinimumPlayersToVote", MinimumPlayersToVote);
                writeValue("setTeamVoteOnly", TeamVoteOnly);
                writeValue("setSvPunkBuster", PunkBusterEnabled);
                writeValue("setSoldierFF", SoldierFF);
                writeValue("setVehicleFF", VehicleFF);
                writeValue("setSoldierSplashFF", SoldierSplashFF);
                writeValue("setVehicleSplashFF", VehicleSplashFF);
                writeValue("setVoipQuality", VoIPQuality);
                writeValue("setVoipServerRemote", VoIPServerRemote);
                writeValue("setVoipServerRemoteIP", VoIPServerRemoteIP);
                writeValue("setVoipServerPort", VoIPServerPort);
                writeValue("setVoipBFClientPort", VoIP_BF_ClientPort);
                writeValue("setVoipBFServerPort", VoIP_BF_ServerPort);
                writeValue("setVoipSharedPassword", VoIPSharedPassword);

                string[] content = newContent.ToArray();

                File.WriteAllLines(configFile, content);

                DONE ne = new DONE();
                ne.ShowDialog();
            }
            catch (Exception x)
            {
                if ( x.Message == "Empty path name is not legal." )
                    MessageBox.Show("Use the Auto-Login feature to apply any server settings.");
                else
                    MessageBox.Show(x.ToString());
            }
        }
    }
}
