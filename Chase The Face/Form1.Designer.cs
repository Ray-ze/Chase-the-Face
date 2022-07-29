namespace Chase_The_Face
{
    partial class menuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.statsPanel = new System.Windows.Forms.Panel();
            this.scoreText = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.smileFace = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statsPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smileFace)).BeginInit();
            this.SuspendLayout();
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.DimGray;
            this.statsPanel.Controls.Add(this.scoreText);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsPanel.Location = new System.Drawing.Point(0, 0);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(800, 51);
            this.statsPanel.TabIndex = 0;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(360, 14);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(83, 25);
            this.scoreText.TabIndex = 0;
            this.scoreText.Text = "Score : 0";
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.smileFace);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 51);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(800, 399);
            this.gamePanel.TabIndex = 1;
            // 
            // smileFace
            // 
            this.smileFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smileFace.BackgroundImage")));
            this.smileFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.smileFace.Location = new System.Drawing.Point(241, 239);
            this.smileFace.Name = "smileFace";
            this.smileFace.Size = new System.Drawing.Size(57, 44);
            this.smileFace.TabIndex = 0;
            this.smileFace.TabStop = false;
            this.smileFace.Click += new System.EventHandler(this.smileFace_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.statsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chase The Face";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smileFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel statsPanel;
        private Panel gamePanel;
        private PictureBox smileFace;
        private Label scoreText;
        private System.Windows.Forms.Timer timer1;
    }
}