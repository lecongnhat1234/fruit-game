namespace start
{
    partial class loadinggame
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
            this.thanhphantram = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saitamar = new System.Windows.Forms.PictureBox();
            this.backgroundloading = new System.Windows.Forms.PictureBox();
            this.note = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saitamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundloading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.thanhphantram);
            this.panel1.Location = new System.Drawing.Point(-4, 736);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 30);
            this.panel1.TabIndex = 0;
            // 
            // thanhphantram
            // 
            this.thanhphantram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thanhphantram.Location = new System.Drawing.Point(3, 0);
            this.thanhphantram.Name = "thanhphantram";
            this.thanhphantram.Size = new System.Drawing.Size(47, 34);
            this.thanhphantram.TabIndex = 1;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loading.Font = new System.Drawing.Font("Press Start 2P", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.Location = new System.Drawing.Point(530, 714);
            this.loading.Name = "loading";
            this.loading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loading.Size = new System.Drawing.Size(173, 28);
            this.loading.TabIndex = 6;
            this.loading.Text = "Loading...";
            this.loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saitamar
            // 
            this.saitamar.BackgroundImage = global::start.Properties.Resources.pngguru_com;
            this.saitamar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saitamar.Location = new System.Drawing.Point(366, 163);
            this.saitamar.Name = "saitamar";
            this.saitamar.Size = new System.Drawing.Size(536, 436);
            this.saitamar.TabIndex = 3;
            this.saitamar.TabStop = false;
            // 
            // backgroundloading
            // 
            this.backgroundloading.BackColor = System.Drawing.Color.SlateBlue;
            this.backgroundloading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundloading.Location = new System.Drawing.Point(-1, -4);
            this.backgroundloading.Name = "backgroundloading";
            this.backgroundloading.Size = new System.Drawing.Size(1250, 746);
            this.backgroundloading.TabIndex = 2;
            this.backgroundloading.TabStop = false;
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.note.Font = new System.Drawing.Font("Press Start 2P", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.Location = new System.Drawing.Point(344, 113);
            this.note.Name = "note";
            this.note.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.note.Size = new System.Drawing.Size(592, 47);
            this.note.TabIndex = 7;
            this.note.Text = "choi game thua khong duoc quau !";
            this.note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadinggame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 765);
            this.Controls.Add(this.note);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.saitamar);
            this.Controls.Add(this.backgroundloading);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loadinggame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadinggame";
            this.Load += new System.EventHandler(this.loadinggame_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saitamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundloading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel thanhphantram;
        private System.Windows.Forms.PictureBox backgroundloading;
        private System.Windows.Forms.PictureBox saitamar;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label note;
    }
}