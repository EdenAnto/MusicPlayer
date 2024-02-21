using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WMPLib;


namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private static string currentFileSelectedPath;
        private static string lastFileSelectedPath= "Add Files...";
        private Dictionary<string, string> Files = new Dictionary<string, string>();
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private WindowsMediaPlayer tmpPlayer = new WindowsMediaPlayer();
        private TimeSpan currentTime;
        private Boolean currentlblWritten = false;
        private bool pauseIsClicked = false;
        private bool shuffle = false;
        private bool deleteFlag = false;





        public Form1()
        {
            InitializeComponent();
            this.listBox1.Items.Add("Add Files...");
            this.listBox1.SelectedIndex = 0;
            player.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);

        }
        private void player_PlayStateChange(int newState)
        {
            if(listBox1.Items[0].ToString() != "Add Files...")
            {
                if (deleteFlag)
                {
                    player.URL = "";
                    selectPrevSong();
                    deleteFlag = !deleteFlag;
                }
                if (player.playState != WMPPlayState.wmppsPaused && currentFileSelectedPath != null && player.URL!="")
                    player.controls.play();
                // Check if the media file has finished playing
                if ((WMPPlayState)newState == WMPPlayState.wmppsMediaEnded )
                {
                    if (shuffle)
                        this.listBox1.SelectedIndex = (new Random()).Next(0, this.listBox1.Items.Count);
                    else
                    {
                        selectNextSong();
                    }
                    this.Play.PerformClick();
                }
            }
               

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

                if (listBox1.SelectedItem.ToString() != "Add Files...")
            {
                if(currentFileSelectedPath!= null)
                    lastFileSelectedPath = currentFileSelectedPath;
                currentFileSelectedPath = Files[listBox1.SelectedItem.ToString()];
                WindowsMediaPlayer tmpPlayer = new WindowsMediaPlayer();

                if (player.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    tmpPlayer.URL = currentFileSelectedPath;
                    tmpPlayer.controls.play();
                    showPlayerDetails(tmpPlayer);
                    this.lblDispCurrent.Text = "";
                    tmpPlayer.controls.stop();
                }

                
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string key;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3";
            openFileDialog.Title = "Select MP3 files";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(currentFileSelectedPath == null || listBox1.Items[listBox1.SelectedIndex].ToString()== "Add Files...") 
                    this.listBox1.Items.Clear();
                foreach (string path in openFileDialog.FileNames)
                {
                    key = Path.GetFileNameWithoutExtension(path);
                    Files[key] = path; //Use this method to avoid file aready insert exception
                    if(!this.listBox1.Items.Contains(key))
                        this.listBox1.Items.Add(key);
                }
                this.listBox1.SelectedIndex = 0;

            }

        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                player.controls.pause();

            if (File.Exists(currentFileSelectedPath) &&
                            listBox1.Items[listBox1.SelectedIndex].ToString() != "Add Files...")
            {
                player.URL = currentFileSelectedPath;
                player.controls.play();
                currentlblWritten = false;
                trackBar1.Visible = true;
                trackBar1.Maximum = (int)player.currentMedia.duration;
                trackBar1.Value = 0;
                timer1.Enabled = true;
                pauseIsClicked = false;
                Pause.Text = "Pause";
            }
            else if(currentFileSelectedPath!=null)
            {
                MessageBox.Show("The file does not exist in this path anymore.");

            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (!pauseIsClicked)
            {
                timer1.Enabled = false;
                player.controls.pause();
                pauseIsClicked=true;
                Pause.Text = "Continue";
            }
            else 
            {
                timer1.Enabled = true;
                player.controls.play();
                pauseIsClicked = false;
                Pause.Text = "Pause";


            }



        }

        private void selectNextSong()
        {
            if (this.listBox1.SelectedIndex == this.listBox1.Items.Count-1)
                this.listBox1.SelectedIndex = 0;
            else 
               this.listBox1.SelectedIndex++;
        }
        private void selectPrevSong()
        {
            if (this.listBox1.SelectedIndex == 0)
                this.listBox1.SelectedIndex=this.listBox1.Items.Count - 1;
            else
                this.listBox1.SelectedIndex--;
        }
        private void selectSongAfterDel(int idx)
        {
            if (idx == 0)
                idx = this.listBox1.Items.Count - 2;
            else
                idx--;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            selectNextSong();
            if (player.playState == WMPPlayState.wmppsPlaying)
                this.Play.PerformClick();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            selectPrevSong();
            if (player.playState == WMPPlayState.wmppsPlaying)
                this.Play.PerformClick();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Files.Clear();
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("Add Files...");
            this.listBox1.SelectedIndex = 0;
            player.URL = "";
            player.controls.stop();
            clearPlayerDetails();
        }

        private void showPlayerDetails(WindowsMediaPlayer player)
        {

            string title = player.currentMedia.getItemInfo("Title");
            string author = player.currentMedia.getItemInfo("Author");
            TimeSpan duration = TimeSpan.FromSeconds(player.currentMedia.duration);
            TimeSpan currentPosition = TimeSpan.FromSeconds(player.controls.currentPosition);

            this.lblDispName.Text = title;
            this.lblDispDuration.Text=duration.ToString(@"mm\:ss");
            this.lblDispCurrent.Text = currentPosition.ToString(@"mm\:ss");
            
        }

        private void clearPlayerDetails()
        {
            this.lblDispName.Text = "";
            this.lblDispDuration.Text = "";
            this.lblDispCurrent.Text = "";
           

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.controls.currentPosition = trackBar1.Value;
            this.lblDispCurrent.Text = TimeSpan.FromSeconds(trackBar1.Value).ToString(@"mm\:ss");
            player.controls.play();

        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            currentTime = TimeSpan.FromSeconds(player.controls.currentPosition);
            this.lblDispCurrent.Text = currentTime.ToString(@"mm\:ss");
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying) { 

                if (player.currentMedia.duration > 0)
                {
                    if (trackBar1.Maximum == 0)
                        trackBar1.Maximum = (int)player.currentMedia.duration;
                    if (!currentlblWritten)
                    {
                        currentlblWritten = true;
                        showPlayerDetails(player);
                    }
                }

            try
            {
                trackBar1.Value = Convert.ToInt32(player.controls.currentPosition);

            }
            catch (Exception ex)
            {
            }
        }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            shuffle = !shuffle;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.Items[listBox1.SelectedIndex].ToString() != "Add Files...")
            {
                int idx = listBox1.SelectedIndex;
                if (Path.GetFileNameWithoutExtension(player.URL) == listBox1.Items[idx].ToString()) 
                {
                    listBox1.SelectedIndex = 0;
                    currentFileSelectedPath = null;
                    player.URL = "";
                    deleteFlag=!deleteFlag;
                    clearPlayerDetails();
                    player=new WindowsMediaPlayer();
                }
                Files.Remove(listBox1.Items[idx].ToString());
                listBox1.Items.RemoveAt(idx);



            }
        }

      
        
    }
}
