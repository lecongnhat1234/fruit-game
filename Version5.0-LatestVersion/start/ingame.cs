using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace start
{
    public partial class ingame : Form
    {
        string path = Application.StartupPath + @"\music\";
        bool goLeft, goRight;
        int score = 0;
        int missed = 0;
        int spd = 20;
        System.Random rndX = new System.Random();
        System.Random rndY = new System.Random();
        FileWork ms = new FileWork();
        string s;
        int i = 0, n = 0;
        SoundPlayer player = new SoundPlayer();
        RandomFruits rnd = new RandomFruits();
        public ingame()
        {
            InitializeComponent();
            gameReset();
        }
        // ingame tự xử nha con trai
        // nút button 1 là nút back , trở về menu
        //async Task Test()
        //{
        //    await Task.Run(() =>
        //    {
        //        player.Load();
        //        player.PlaySync();
        //    });
        //    ingameTimer.Stop();
        //    player.Dispose();
        //}
        private void SetTransparent(PictureBox Map, PictureBox sender)
        {
            sender.BringToFront();
            sender.BackColor = Color.Transparent;
            sender.Parent = Map;
        }
        private void SetTransparent(PictureBox Map, Panel sender)
        {
            sender.BringToFront();
            sender.BackColor = Color.Transparent;
            sender.Parent = Map;
        }
        private void ingame_Load(object sender, EventArgs e)
        {
            try
            {
                ms.read(ref s, path + "test.txt");
                player.SoundLocation = path + s;
                player.Play();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found!!!");
                Close();
            }

            SetTransparent(backgroundgame, mainPlayer);
            SetTransparent(backgroundgame, pictureBox1);
            SetTransparent(backgroundgame, pictureBox2);
            SetTransparent(backgroundgame, pictureBox3);
            SetTransparent(backgroundgame, picSpecial);
            //SetTransparent(backgroundgame, pnGameOver);
        }

        private void ingame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void ingame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void ingameTimer_Tick(object sender, EventArgs e)
        {
            lbScore.Text = "SCORE: " + score;
            lbMiss.Text = "MISSED: " + missed;
            //if (score > highScore)
          //  {
            //    highScore = score;
          //      lbHighScore.Text = "HIGH SCORE: " + highScore;
           // }
            if (goLeft == true && mainPlayer.Left > 0)
            {
                mainPlayer.Left -= spd;
                mainPlayer.Image = Properties.Resources.miku1;
            }
            if (goRight == true && mainPlayer.Left + mainPlayer.Width < this.ClientSize.Width)
            {
                mainPlayer.Left += spd;
                mainPlayer.Image = Properties.Resources.miku2;
            }
            rnd.setRandom(pictureBox1, this, mainPlayer, ref score, ref missed, 500);
            rnd.setRandom(pictureBox2, this, mainPlayer, ref score, ref missed, 200);
            rnd.setRandom(pictureBox3, this, mainPlayer, ref score, ref missed, 100);
            if (missed > 30)
            {
                pnGameOver.Enabled = true;
                pnGameOver.Visible = true;
                ingameTimer.Stop();
                player.Stop();
            }
            if(i >= 1)
                picSpecial.Visible = true;
            rnd.specialFruits(picSpecial, this, mainPlayer, ref spd, i, n);
            n = i;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ingameTimer.Stop();
            player.Stop();
            pnGameOver.Enabled = true;
            pnGameOver.Visible = true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            highScore();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            switch(s)
            {
                case "Lemon.wav":

                    rnd.setFruitSpeed(pictureBox1);
                    rnd.setFruitSpeed(pictureBox2);
                    rnd.setFruitSpeed(pictureBox3);
                    if (i >= 26)
                    {
                        pnGameOver.Enabled = true;
                        pnGameOver.Visible = true;
                        ingameTimer.Stop();
                    }    
                    break;
                case "DoiLaLamANghen.wav":
                    if(i >= 19)
                    {
                        pnGameOver.Enabled = true;
                        pnGameOver.Visible = true;
                        ingameTimer.Stop();
                    }
                    break;
            }    
        }
        private void gameReset()
        {
            goLeft = false;
            goRight = false;
            score = 0;
            missed = 0;
            ingameTimer.Start();
            pnGameOver.Visible = false;
            pnGameOver.Enabled = false;
            player.Play();

        }
        private void highScore()
        {
            List<int> iArr = new List<int>();
            ms.write(score.ToString(), path + "BXH.txt");
            ms.read(iArr, path + "BXH.txt");
            if (score >= iArr.Max())
                MessageBox.Show("Bạn đã đạt điểm cao nhất!!!", "Chúc mừng");
            ms.deleteF(path + "BXH.txt");
            iArr.Sort();
            int c = 1;
            for (int i = iArr.Count() - 1; i >= 0; i--)
            { 
                ms.write(iArr[i].ToString(), path + "BXH.txt");
                if (c >= 5)
                    break;
                c++;
            }
        }
    }
}
