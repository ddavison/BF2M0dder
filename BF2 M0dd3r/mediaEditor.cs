using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using WMPLib;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class mediaEditor : Form
    {
        IWMPPlayer player = new WindowsMediaPlayerClass();

        bool isReplacing;
        string mediaName;
        string replacingWith;
        string mediaURL;
        public mediaEditor(string media)
        {
            InitializeComponent();

            loadSong(media);
        }

        private void mediaEditor_Load(object sender, EventArgs e)
        {
            labelX1.Text = mediaName;
            labelX2.Text = mediaURL;
        }

        void loadSong(string songToLoad)
        {
            try
            {
                mediaName = Path.GetFileName(songToLoad);
                mediaURL = songToLoad;

                player.URL = songToLoad;
                player.controls.stop();
                player.settings.volume = volume.Value;
            }
            catch (Exception x)
            {
                MessageBox.Show("There was an error loading the song.\n\n\t" + x.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            player.URL = mediaURL;
            player.controls.play();
        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            if (seeker.Maximum != (int)player.currentMedia.duration)
            {
                seeker.Maximum = (int)player.currentMedia.duration;
            }

            seeker.Value = player.currentMedia.markerCount;
        }

        private void volume_ValueChanged(object sender, EventArgs e)
        {
            player.settings.volume = volume.Value;
        }

        private void mediaEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                player.URL = null;

                File.Delete(mediaURL);
            }
            catch (Exception x)
            {
                MessageBox.Show("Could not delete " + mediaURL + "\n\n\t" + x.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //first set cd.Filter...

            string extension = mediaName.Remove(0, (mediaName.Length - 3));

            cd.Filter = extension.ToUpper() + " files (*." + extension + ")|*." + extension;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (cd.FileName == "")
                {

                }
                else
                {
                    string pathToWriteTo = mediaURL.Remove((mediaURL.Length - mediaName.Length), mediaName.Length);

                    replacingWith = cd.FileName;

                    this.Text = "BF2 Modder Media Editor - REPLACING MEDIA";
                    //File.WriteAllText(, cd.FileName);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isReplacing)
            {
                File.WriteAllText("bf2mrepl.cfg", replacingWith);
                FileInfo fl = new FileInfo("bf2mrepl.cfg");

                MessageBox.Show(fl.FullName);
                this.Close();
            }
            this.Close();
        }

    }
}
