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
    public partial class ServerSettings : Form
    {
        string playerFile = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2profname.cfg";
        string[] playerFileLines = null;

        string playerName = "";
        
        List<string> newContent = new List<string>();
        
        string configFile = "";
        string[] configFileLines = null;

        public ServerSettings()
        {
            InitializeComponent();
        }

        private void ServerSettings_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(playerFile))
                {
                    MessageBox.Show("Please configure the Auto-Login feature of BF2 M0dd3r before using this tool.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                    playerName = File.ReadAllText(playerFile);

                playerFileLines = File.ReadAllLines(playerFile);

                configFile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Battlefield 2\\Profiles\\" + playerFileLines[1] + "\\ServerSettings.con";

                configFileLines = File.ReadAllLines(configFile);

                

                fillBasicFields();
                fillAdvancedFields();
            }
            catch (Exception x)
            {
                if ( !x.Message.Contains("find") )
                    MessageBox.Show(x.Message);
            }
        }

        private void fillAdvancedFields()
        {
            try
            {
                advancedBFClientPort.Value = Decimal.Parse(getValue(advancedBFClientPort.Tag.ToString()));
                advancedServerRemoteIP.Text = getValue(advancedServerRemoteIP.Tag.ToString());
                advancedSoldierFF.Value = Decimal.Parse(getValue(advancedSoldierFF.Tag.ToString()));
                advancedSoldierSplashFF.Value = Decimal.Parse(getValue(advancedSoldierSplashFF.Tag.ToString()));
                advancedVehicleFF.Value = Decimal.Parse(getValue(advancedVehicleFF.Tag.ToString()));
                advancedVehicleSplashFF.Value = Decimal.Parse(getValue(advancedVehicleSplashFF.Tag.ToString()));
                advancedVoipBFServerPort.Value = Decimal.Parse(getValue(advancedVoipBFServerPort.Tag.ToString()));

                if (getValue(advancedVoipEnabled.Tag.ToString()) == "1")
                    advancedVoipEnabled.Checked = true;
                else
                    advancedVoipEnabled.Checked = false;

                advancedVoipQuality.Value = Decimal.Parse(getValue(advancedVoipQuality.Tag.ToString()));
                advancedVoipServerPort.Value = Decimal.Parse(getValue(advancedVoipServerPort.Tag.ToString()));
                advancedVoipServerRemote.Text = getValue(advancedVoipServerRemote.Tag.ToString());
                advancedVoipSharedPassword.Text = getValue(advancedVoipSharedPassword.Tag.ToString());
            }
            catch (Exception x)
            {
                if ( x.Message == "Empty path name is not legal." )
                    MessageBox.Show("Use the Auto-Login feature to apply any server settings.");
                else
                    MessageBox.Show(x.ToString());
            }
        }

        private void fillBasicFields()
        {
            if (getValue(basicAutoBalance.Tag.ToString()) == "1")
                basicAutoBalance.Checked = true;
            else
                basicAutoBalance.Checked = false;

            if (getValue(basicHasVehicles.Tag.ToString()) == "1")
                basicHasVehicles.Checked = true;
            else
                basicHasVehicles.Checked = false;

            if (basicHasVehicles.Checked)
                basicHasVehicles.Checked = false;
            else
                basicHasVehicles.Checked = true;
            try
            {
                basicManDownTime.Value = Decimal.Parse(getValue(basicManDownTime.Tag.ToString()));
                basicMaxPlayers.Value = Decimal.Parse(getValue(basicManDownTime.Tag.ToString()));
                basicMinPlayersForVote.Value = Decimal.Parse(getValue(basicMinPlayersForVote.Tag.ToString()));

                if (getValue(basicPunishTeamKills.Tag.ToString()) == "1")
                    basicPunishTeamKills.Checked = true;
                else
                    basicPunishTeamKills.Checked = false;

                basicRoundScoreLimit.Value = Decimal.Parse(getValue(basicRoundScoreLimit.Tag.ToString()));
                basicRoundsPerMap.Value = Decimal.Parse(getValue(basicRoundsPerMap.Tag.ToString()));
                basicRoundTimeLimit.Value = Decimal.Parse(getValue(basicRoundTimeLimit.Tag.ToString()));

                basicServerName.Text = getValue(basicServerName.Tag.ToString());
                basicServerPassword.Text = getValue(basicServerPassword.Tag.ToString());
                basicSpawnTime.Value = Decimal.Parse(getValue(basicSpawnTime.Tag.ToString()));
                basicTeamRatio.Value = Decimal.Parse(getValue(basicTeamRatio.Tag.ToString()));

                if (getValue(basicTeamVoteOnly.Tag.ToString()) == "1")
                    basicTeamVoteOnly.Checked = true;
                else
                    basicTeamVoteOnly.Checked = false;

                if (getValue(basicTeamVoteOnly.Tag.ToString()) == "1")
                    basicTeamVoteOnly.Checked = true;
                else
                    basicTeamVoteOnly.Checked = false;


                basicTicketRatio.Value = Decimal.Parse(getValue(basicTicketRatio.Tag.ToString()));

                if (getValue(basicUsingPb.Tag.ToString()) == "1")
                    basicUsingPb.Checked = true;
                else
                    basicUsingPb.Checked = false;

                basicVoteTime.Value = Decimal.Parse(getValue(basicVoteTime.Tag.ToString()));

                if (getValue(basicVotingEnabled.Tag.ToString()) == "1")
                    basicVotingEnabled.Checked = true;
                else
                    basicVotingEnabled.Checked = false;

            }
            catch
            {
            }

            
        }

        // -----------------------------------------------
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

        // WRITE VALUE
        private void writeValue(TextBox sender)
        {
            //first encapsulate the valueToWrite...
            
            string gs = "GameServerSettings.";

            newContent.Add(gs + sender.Tag.ToString() + " \"" + sender.Text + "\"");
        }

        private void writeValue(NumericUpDown sender)
        {
            string gs = "GameServerSettings.";

            newContent.Add(gs + sender.Tag.ToString() + " " + sender.Value.ToString()); 
        }

        private void writeValue(CheckBox sender)
        {
            string gs = "GameServerSettings.";
            string bl = null;

            if ( sender.Checked )
                bl = "1";
            else
                bl = "0";

            if (sender.Tag.ToString().Contains("NoVehicles"))
            {
                if (bl == "0")
                    bl = "1";
                else
                    bl = "0";
            }

            

            newContent.Add(gs + sender.Tag.ToString() + " " + bl);
        }
        // ---------------------------------------------
        

        private void applyButton_Click(object sender, EventArgs e)
        {
            applyBasic();
            applyAdvanced();

            try
            {
                if ( File.Exists(configFile + "_bak" ) )
                {

                }
                else
                {
                    File.Copy(configFile, configFile + "_bak");
                }

                string[] content = newContent.ToArray();

                

                File.WriteAllLines(configFile, content);

                DONE ne = new DONE();
                ne.ShowDialog();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void applyBasic()
        {
            writeValue(basicAutoBalance);
            writeValue(basicHasVehicles);
            writeValue(basicManDownTime);
            writeValue(basicMaxPlayers);
            writeValue(basicMinPlayersForVote);
            writeValue(basicPunishTeamKills);
            writeValue(basicRoundScoreLimit);
            writeValue(basicRoundsPerMap);
            writeValue(basicRoundTimeLimit);
            writeValue(basicServerName);
            writeValue(basicServerPassword);
            writeValue(basicSpawnTime);
            writeValue(basicTeamRatio);
            writeValue(basicTeamVoteOnly);
            writeValue(basicTicketRatio);
            writeValue(basicUsingPb);
            writeValue(basicVoteTime);
            writeValue(basicVotingEnabled);
        }

        private void applyAdvanced()
        {
            writeValue(advancedBFClientPort);
            writeValue(advancedServerRemoteIP);
            writeValue(advancedSoldierFF);
            writeValue(advancedSoldierSplashFF);
            writeValue(advancedVehicleFF);
            writeValue(advancedVehicleSplashFF);
            writeValue(advancedVoipBFServerPort);
            writeValue(advancedVoipEnabled);
            writeValue(advancedVoipQuality);
            writeValue(advancedVoipServerPort);
            writeValue(advancedVoipServerRemote);
            writeValue(advancedVoipSharedPassword);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
