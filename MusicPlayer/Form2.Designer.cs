namespace MusicPlayer
{
    partial class Form2
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
            this.mostPlayedSongs = new System.Windows.Forms.ListBox();
            this.display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostPlayedSongs
            // 
            this.mostPlayedSongs.FormattingEnabled = true;
            this.mostPlayedSongs.ItemHeight = 20;
            this.mostPlayedSongs.Location = new System.Drawing.Point(238, 50);
            this.mostPlayedSongs.Name = "mostPlayedSongs";
            this.mostPlayedSongs.Size = new System.Drawing.Size(249, 404);
            this.mostPlayedSongs.TabIndex = 0;
            this.mostPlayedSongs.SelectedIndexChanged += new System.EventHandler(this.mostPlayedSongs_SelectedIndexChanged);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(599, 325);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(116, 48);
            this.display.TabIndex = 1;
            this.display.Text = "display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.display);
            this.Controls.Add(this.mostPlayedSongs);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mostPlayedSongs;
        private System.Windows.Forms.Button display;
    }
}