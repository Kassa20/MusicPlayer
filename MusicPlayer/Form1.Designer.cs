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
            this.logo = new System.Windows.Forms.Label();
            this.songs = new System.Windows.Forms.ListBox();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.sortButton = new System.Windows.Forms.Button();
            this.playList = new System.Windows.Forms.ListBox();
            this.AddPlaylist = new System.Windows.Forms.Button();
            this.clearPlayList = new System.Windows.Forms.Button();
            this.Lyrics = new System.Windows.Forms.ListBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopPanel.Controls.Add(this.logo);
            resources.ApplyResources(this.TopPanel, "TopPanel");
            this.TopPanel.Name = "TopPanel";
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logo.Name = "logo";
            // 
            // songs
            // 
            this.songs.AllowDrop = true;
            resources.ApplyResources(this.songs, "songs");
            this.songs.FormattingEnabled = true;
            this.songs.Name = "songs";
            this.songs.SelectedIndexChanged += new System.EventHandler(this.songs_SelectedIndexChanged);
            // 
            // btnSelectSong
            // 
            resources.ApplyResources(this.btnSelectSong, "btnSelectSong");
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.UseVisualStyleBackColor = true;
            this.btnSelectSong.Click += new System.EventHandler(this.btnSelectSong_Click);
            // 
            // mediaPlayer
            // 
            resources.ApplyResources(this.mediaPlayer, "mediaPlayer");
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // sortButton
            // 
            resources.ApplyResources(this.sortButton, "sortButton");
            this.sortButton.Name = "sortButton";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // playList
            // 
            this.playList.FormattingEnabled = true;
            resources.ApplyResources(this.playList, "playList");
            this.playList.Name = "playList";
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            // 
            // AddPlaylist
            // 
            resources.ApplyResources(this.AddPlaylist, "AddPlaylist");
            this.AddPlaylist.Name = "AddPlaylist";
            this.AddPlaylist.UseVisualStyleBackColor = true;
            this.AddPlaylist.Click += new System.EventHandler(this.AddPlaylist_Click);
            // 
            // clearPlayList
            // 
            resources.ApplyResources(this.clearPlayList, "clearPlayList");
            this.clearPlayList.Name = "clearPlayList";
            this.clearPlayList.UseVisualStyleBackColor = true;
            this.clearPlayList.Click += new System.EventHandler(this.clearPlayList_Click);
            // 
            // Lyrics
            // 
            this.Lyrics.FormattingEnabled = true;
            resources.ApplyResources(this.Lyrics, "Lyrics");
            this.Lyrics.Name = "Lyrics";
            this.Lyrics.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MusicPlayer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Lyrics);
            this.Controls.Add(this.clearPlayList);
            this.Controls.Add(this.AddPlaylist);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.btnSelectSong);
            this.Controls.Add(this.songs);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.ListBox songs;
        private System.Windows.Forms.Button btnSelectSong;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Button AddPlaylist;
        private System.Windows.Forms.Button clearPlayList;
        private System.Windows.Forms.ListBox Lyrics;
    }
}

