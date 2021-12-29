namespace start
{
    partial class ingame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbMiss = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.ingameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnGameOver = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.picSpecial = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundgame = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundgame)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.lbMiss);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 59);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::start.Properties.Resources._1a824c01b45ed566b1a887861843c55e;
            this.pictureBox5.Location = new System.Drawing.Point(1179, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // lbMiss
            // 
            this.lbMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiss.Location = new System.Drawing.Point(176, 9);
            this.lbMiss.Name = "lbMiss";
            this.lbMiss.Size = new System.Drawing.Size(181, 36);
            this.lbMiss.TabIndex = 6;
            this.lbMiss.Text = "MISSED:";
            this.lbMiss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(3, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(186, 36);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "SCORE:";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ingameTimer
            // 
            this.ingameTimer.Enabled = true;
            this.ingameTimer.Interval = 20;
            this.ingameTimer.Tick += new System.EventHandler(this.ingameTimer_Tick);
            // 
            // pnGameOver
            // 
            this.pnGameOver.Controls.Add(this.btOK);
            this.pnGameOver.Controls.Add(this.label1);
            this.pnGameOver.Location = new System.Drawing.Point(265, 198);
            this.pnGameOver.Name = "pnGameOver";
            this.pnGameOver.Size = new System.Drawing.Size(696, 343);
            this.pnGameOver.TabIndex = 6;
            this.pnGameOver.Visible = false;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btOK.Location = new System.Drawing.Point(219, 215);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(241, 64);
            this.btOK.TabIndex = 12;
            this.btOK.Text = "Back To Menu";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::start.Properties.Resources._68747470733a2f2f6f73752e7070792e73682f68656c702f77696b692f536b696e6e696e672f6f73752163617463682f696d672f66727569742d6772617065732d6f7665726c61792e706e67;
            this.pictureBox1.Location = new System.Drawing.Point(364, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "F";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPlayer.Image = global::start.Properties.Resources.miku1;
            this.mainPlayer.Location = new System.Drawing.Point(560, 601);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(157, 164);
            this.mainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPlayer.TabIndex = 2;
            this.mainPlayer.TabStop = false;
            // 
            // picSpecial
            // 
            this.picSpecial.BackColor = System.Drawing.Color.Black;
            this.picSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSpecial.Image = global::start.Properties.Resources.power_icon_png_25;
            this.picSpecial.Location = new System.Drawing.Point(580, 12);
            this.picSpecial.Name = "picSpecial";
            this.picSpecial.Size = new System.Drawing.Size(101, 91);
            this.picSpecial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpecial.TabIndex = 10;
            this.picSpecial.TabStop = false;
            this.picSpecial.Tag = "F";
            this.picSpecial.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::start.Properties.Resources._68747470733a2f2f6f73752e7070792e73682f68656c702f77696b692f536b696e6e696e672f6f73752163617463682f696d672f66727569742d6772617065732e706e67;
            this.pictureBox3.Location = new System.Drawing.Point(635, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "F";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::start.Properties.Resources._68747470733a2f2f6f73752e7070792e73682f68656c702f77696b692f536b696e6e696e672f6f73752163617463682f696d672f66727569742d706561722d6f7665726c61792e706e67;
            this.pictureBox2.Location = new System.Drawing.Point(1004, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "F";
            // 
            // backgroundgame
            // 
            this.backgroundgame.Image = global::start.Properties.Resources.ldsZak1;
            this.backgroundgame.Location = new System.Drawing.Point(-2, 52);
            this.backgroundgame.Name = "backgroundgame";
            this.backgroundgame.Size = new System.Drawing.Size(1250, 713);
            this.backgroundgame.TabIndex = 7;
            this.backgroundgame.TabStop = false;
            // 
            // ingame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 765);
            this.Controls.Add(this.pnGameOver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainPlayer);
            this.Controls.Add(this.picSpecial);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.backgroundgame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ingame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ingame";
            this.Load += new System.EventHandler(this.ingame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ingame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ingame_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnGameOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundgame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMiss;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer ingameTimer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnGameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backgroundgame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picSpecial;
        private System.Windows.Forms.Button btOK;
    }
}