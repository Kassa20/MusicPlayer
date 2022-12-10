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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.amountPlayed = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mostPlayedSongs
            // 
            this.mostPlayedSongs.FormattingEnabled = true;
            this.mostPlayedSongs.ItemHeight = 20;
            this.mostPlayedSongs.Location = new System.Drawing.Point(42, 60);
            this.mostPlayedSongs.Name = "mostPlayedSongs";
            this.mostPlayedSongs.Size = new System.Drawing.Size(284, 404);
            this.mostPlayedSongs.TabIndex = 0;
            this.mostPlayedSongs.SelectedIndexChanged += new System.EventHandler(this.mostPlayedSongs_SelectedIndexChanged);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.AntiqueWhite;
            this.display.Location = new System.Drawing.Point(599, 325);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(116, 48);
            this.display.TabIndex = 1;
            this.display.Text = "display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Song";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountPlayed
            // 
            this.amountPlayed.FormattingEnabled = true;
            this.amountPlayed.ItemHeight = 20;
            this.amountPlayed.Location = new System.Drawing.Point(359, 60);
            this.amountPlayed.Name = "amountPlayed";
            this.amountPlayed.Size = new System.Drawing.Size(120, 404);
            this.amountPlayed.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(359, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Amount Played";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.amountPlayed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.mostPlayedSongs);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mostPlayedSongs;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox amountPlayed;
        private System.Windows.Forms.TextBox textBox2;
    }
}