using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// thư viện chèn nhạc
using System.Media;
    // t chưa có ý tưởng gì với 2 cái nút vô màn cả . cái đó từ từ t thêm sau :v để màu trắng đỡ
namespace start
{
    public partial class menu1 : Form
    {
        string path = Application.StartupPath + @"\music\";
        FileWork ms = new FileWork();
        public menu1()
        {
            InitializeComponent();
        }
        // tạo
        SoundPlayer player = new SoundPlayer();
        SoundPlayer player1 = new SoundPlayer();
        
        // button 1 là nút back á => trở về start
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        // cái này dùng để làm cái backcolor trùng với màu nền
        // code phần chơi game quăng cái này qua cho nó xóa backcolor
        private void SetTransparent(PictureBox Map, PictureBox sender)
        {
            sender.BringToFront();
            sender.BackColor = Color.Transparent;
            sender.Parent = Map;
        }
        private void SetTransparent(PictureBox Map, Label sender)
        {
            sender.BringToFront();
            sender.BackColor = Color.Transparent;
            sender.Parent = Map;
        }
        private void SetTransparent(PictureBox Map, Button sender)
        {
            sender.BringToFront();
            sender.BackColor = Color.Transparent;
            sender.Parent = Map;
        }

        private void menu1_Load(object sender, EventArgs e)
        {
            SetTransparent(backgroundmenu, gamename);
            SetTransparent(backgroundmenu, back);
            PLAY.Hide();
            label2.Hide(); 
        }


        // cái này đưa chuột vào ra để nó phát nhạc nghe thử
        // picterbox2 là cái ở trên
        // picterbox3 là cái ở dưới
        // 2 cái label2 với PLAY cái hình nút play rê vào là nó hiện ra

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PLAY.Show();
            player.SoundLocation = path + "DoiLaLamANghen.wav";
            player.PlayLooping();
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PLAY.Hide();
            player.Stop();
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            player1.SoundLocation = path + "Lemon.wav";
            player1.PlayLooping();
            label2.Show();  
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            player1.Stop();
            label2.Hide(); 
        }



        // cái này dùng để chuyển sang form loading
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            loadinggame i = new loadinggame();
            i.Show();
            i.FormClosed += new FormClosedEventHandler(a_formOpen);
            
            this.Hide();
            
        }
        
        private void PLAY_Click(object sender, EventArgs e)
        {
            
            loadinggame i = new loadinggame();
            i.Show();
            i.FormClosed += new FormClosedEventHandler(a_formOpen);
            this.Hide();

        }
        private void a_formOpen(object sender, FormClosedEventArgs e)
        {
            ms.ghiTenNhac("DoiLaLamANghen.wav",path + "test.txt");
            ingame a = new ingame();
            a.Show();
            a.FormClosed += new FormClosedEventHandler(i_formClosed);
        }
        private void b_formOpen(object sender, FormClosedEventArgs e)
        {
            ms.ghiTenNhac("Lemon.wav",path + "test.txt");
            ingame a = new ingame();
            a.Show();
            a.FormClosed += new FormClosedEventHandler(i_formClosed);
        }
        private void i_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loadinggame i = new loadinggame();
            i.Show();
            i.FormClosed += new FormClosedEventHandler(b_formOpen);
            this.Hide();
            
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadinggame i = new loadinggame();
            i.Show();
            i.FormClosed += new FormClosedEventHandler(b_formOpen);
            this.Hide();
        }
        
    }
}
