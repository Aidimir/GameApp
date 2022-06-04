namespace GameApp.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startControl1 = new GameApp.Views.StartControl();
            this.gameScreen1 = new GameApp.Views.GameScreen();
            this.SuspendLayout();
            // 
            // startControl1
            // 
            this.startControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startControl1.BackgroundImage")));
            this.startControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startControl1.Location = new System.Drawing.Point(0, 0);
            this.startControl1.Name = "startControl1";
            this.startControl1.Size = new System.Drawing.Size(2560, 1520);
            this.startControl1.TabIndex = 0;
            // 
            // gameScreen1
            // 
            this.gameScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameScreen1.BackgroundImage")));
            this.gameScreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameScreen1.Location = new System.Drawing.Point(0, 0);
            this.gameScreen1.Name = "gameScreen1";
            this.gameScreen1.Size = new System.Drawing.Size(2560, 1520);
            this.gameScreen1.TabIndex = 1;
            this.gameScreen1.Load += new System.EventHandler(this.gameScreen1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2560, 1520);
            this.Controls.Add(this.gameScreen1);
            this.Controls.Add(this.startControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private StartControl startControl1;
        private GameScreen gameScreen1;
    }
}