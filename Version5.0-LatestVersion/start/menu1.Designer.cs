namespace start
{
    partial class menu1
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
            this.gamename = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.PLAY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.luachon2 = new System.Windows.Forms.PictureBox();
            this.luachon1 = new System.Windows.Forms.PictureBox();
            this.backgroundmenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.luachon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luachon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gamename
            // 
            this.gamename.Font = new System.Drawing.Font("Star Jedi Hollow", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamename.Location = new System.Drawing.Point(2, -3);
            this.gamename.Name = "gamename";
            this.gamename.Size = new System.Drawing.Size(335, 123);
            this.gamename.TabIndex = 1;
            this.gamename.Text = "CATCH!";
            this.gamename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Press Start 2P", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(29, 502);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(268, 51);
            this.back.TabIndex = 2;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // PLAY
            // 
            this.PLAY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PLAY.Font = new System.Drawing.Font("Press Start 2P", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PLAY.Location = new System.Drawing.Point(133, 184);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(67, 20);
            this.PLAY.TabIndex = 5;
            this.PLAY.Text = "PLAY";
            this.PLAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PLAY.Click += new System.EventHandler(this.PLAY_Click);
            this.PLAY.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Press Start 2P", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(133, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLAY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // luachon2
            // 
            this.luachon2.BackgroundImage = global::start.Properties.Resources.lemon;
            this.luachon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luachon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luachon2.Location = new System.Drawing.Point(12, 291);
            this.luachon2.Name = "luachon2";
            this.luachon2.Size = new System.Drawing.Size(310, 145);
            this.luachon2.TabIndex = 4;
            this.luachon2.TabStop = false;
            this.luachon2.Click += new System.EventHandler(this.pictureBox3_Click);
            this.luachon2.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.luachon2.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // luachon1
            // 
            this.luachon1.BackgroundImage = global::start.Properties.Resources.doinayvuianghen;
            this.luachon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luachon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luachon1.Location = new System.Drawing.Point(12, 123);
            this.luachon1.Name = "luachon1";
            this.luachon1.Size = new System.Drawing.Size(310, 140);
            this.luachon1.TabIndex = 3;
            this.luachon1.TabStop = false;
            this.luachon1.Click += new System.EventHandler(this.pictureBox2_Click);
            this.luachon1.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.luachon1.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // backgroundmenu
            // 
            this.backgroundmenu.Image = global::start.Properties.Resources.a4405e3b03ed493b76666bdf53029742;
            this.backgroundmenu.Location = new System.Drawing.Point(2, -3);
            this.backgroundmenu.Name = "backgroundmenu";
            this.backgroundmenu.Size = new System.Drawing.Size(335, 571);
            this.backgroundmenu.TabIndex = 0;
            this.backgroundmenu.TabStop = false;
            // 
            // menu1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PLAY);
            this.Controls.Add(this.luachon2);
            this.Controls.Add(this.luachon1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.gamename);
            this.Controls.Add(this.backgroundmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu1";
            this.Load += new System.EventHandler(this.menu1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luachon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luachon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundmenu;
        private System.Windows.Forms.Label gamename;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox luachon1;
        private System.Windows.Forms.PictureBox luachon2;
        private System.Windows.Forms.Label PLAY;
        private System.Windows.Forms.Label label2;
    }
}