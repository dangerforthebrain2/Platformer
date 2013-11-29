namespace Platformer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.playedField = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.movment = new System.Windows.Forms.Timer(this.components);
            this.platform = new System.Windows.Forms.PictureBox();
            this.playedField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            this.SuspendLayout();
            // 
            // playedField
            // 
            this.playedField.Controls.Add(this.platform);
            this.playedField.Controls.Add(this.player);
            this.playedField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playedField.Location = new System.Drawing.Point(0, 0);
            this.playedField.Name = "playedField";
            this.playedField.Size = new System.Drawing.Size(611, 574);
            this.playedField.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(288, 247);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(26, 26);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // movment
            // 
            this.movment.Enabled = true;
            this.movment.Interval = 1;
            this.movment.Tick += new System.EventHandler(this.movment_Tick);
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.DimGray;
            this.platform.Location = new System.Drawing.Point(225, 524);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(138, 50);
            this.platform.TabIndex = 1;
            this.platform.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 574);
            this.Controls.Add(this.playedField);
            this.Name = "Main";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.playedField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playedField;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer movment;
        private System.Windows.Forms.PictureBox platform;
    }
}

