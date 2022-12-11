namespace MusicPlayer
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.songs = new System.Windows.Forms.ListBox();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.playList = new System.Windows.Forms.ListBox();
            this.AddPlaylist = new System.Windows.Forms.Button();
            this.clearPlayList = new System.Windows.Forms.Button();
            this.ReadLyrics = new System.Windows.Forms.RichTextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.MostPlayedbutton = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pauseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.TopPanel, "TopPanel");
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // songs
            // 
            this.songs.AllowDrop = true;
            this.songs.BackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.songs, "songs");
            this.songs.FormattingEnabled = true;
            this.songs.Name = "songs";
            this.songs.SelectedIndexChanged += new System.EventHandler(this.songs_SelectedIndexChanged);
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectSong.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnSelectSong, "btnSelectSong");
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.UseVisualStyleBackColor = false;
            this.btnSelectSong.Click += new System.EventHandler(this.btnSelectSong_Click);
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.Color.SandyBrown;
            this.playList.FormattingEnabled = true;
            resources.ApplyResources(this.playList, "playList");
            this.playList.Name = "playList";
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            // 
            // AddPlaylist
            // 
            this.AddPlaylist.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.AddPlaylist, "AddPlaylist");
            this.AddPlaylist.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddPlaylist.Name = "AddPlaylist";
            this.AddPlaylist.UseVisualStyleBackColor = false;
            this.AddPlaylist.Click += new System.EventHandler(this.AddPlaylist_Click);
            // 
            // clearPlayList
            // 
            this.clearPlayList.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.clearPlayList, "clearPlayList");
            this.clearPlayList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearPlayList.Name = "clearPlayList";
            this.clearPlayList.UseVisualStyleBackColor = false;
            this.clearPlayList.Click += new System.EventHandler(this.clearPlayList_Click);
            // 
            // ReadLyrics
            // 
            this.ReadLyrics.BackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.ReadLyrics, "ReadLyrics");
            this.ReadLyrics.Name = "ReadLyrics";
            this.ReadLyrics.TextChanged += new System.EventHandler(this.ReadLyrics_TextChanged);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.playButton, "playButton");
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Name = "playButton";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // MostPlayedbutton
            // 
            this.MostPlayedbutton.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.MostPlayedbutton, "MostPlayedbutton");
            this.MostPlayedbutton.ForeColor = System.Drawing.Color.White;
            this.MostPlayedbutton.Name = "MostPlayedbutton";
            this.MostPlayedbutton.UseVisualStyleBackColor = false;
            this.MostPlayedbutton.Click += new System.EventHandler(this.MostPlayedbutton_Click);
            // 
            // mediaPlayer
            // 
            resources.ApplyResources(this.mediaPlayer, "mediaPlayer");
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.pauseButton, "pauseButton");
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusicPlayer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.AddPlaylist);
            this.Controls.Add(this.MostPlayedbutton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.ReadLyrics);
            this.Controls.Add(this.clearPlayList);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.btnSelectSong);
            this.Controls.Add(this.songs);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.ListBox songs;
        private System.Windows.Forms.Button btnSelectSong;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Button AddPlaylist;
        private System.Windows.Forms.Button clearPlayList;
        private System.Windows.Forms.RichTextBox ReadLyrics;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button MostPlayedbutton;
        private System.Windows.Forms.Button pauseButton;
    }
}

