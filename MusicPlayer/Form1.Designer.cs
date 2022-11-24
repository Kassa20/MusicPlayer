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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.sortButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
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
            // axWindowsMediaPlayer1
            // 
            resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // sortButton
            // 
            resources.ApplyResources(this.sortButton, "sortButton");
            this.sortButton.Name = "sortButton";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // MusicPlayer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnSelectSong);
            this.Controls.Add(this.songs);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.ListBox songs;
        private System.Windows.Forms.Button btnSelectSong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button sortButton;
    }
}

