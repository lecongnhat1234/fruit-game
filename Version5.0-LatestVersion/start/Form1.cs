using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// cái này thư viện chèn nhạc
using System.Media;
using start.Resources;

// do hơi ngu nên t quên đổi tên mấy cái toolbox nên giờ t ghi chú từng cái cho nhớ 

namespace start
{
    public partial class batdau : Form
    {
        string path;
        
        public batdau()
        {
            InitializeComponent();
            
        }
       
        SoundPlayer player = new SoundPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            hinhnho.BackColor = Color.FromArgb(0, 0, 0, 0);
            hinhle.BackColor = Color.FromArgb(0, 0, 0, 0);
            hinhnhanvat.BackColor = Color.FromArgb(0, 0, 0, 0);
            // cái này xóa border . mà phần này còn non nên làm hơi ngu
            start.TabStop = false;
            start.FlatStyle = FlatStyle.Flat;
            start.FlatAppearance.BorderSize = 0;
            howtoplay.TabStop = false;
            howtoplay.FlatStyle = FlatStyle.Flat;
            howtoplay.FlatAppearance.BorderSize = 0;
            exit.TabStop = false;
            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 0;
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            // thêm nhạc
            path = Application.StartupPath + @"\music\";
            player.SoundLocation = path + "avengers_theme_8_bit_2203764098683215877.wav";
            player.Play();
            
        }
       // button 1 là nút start nha
       // button 2 là nút howtoplay
       // button 3 là nút exit
       // đống dưới đây để làm hiệu ứng rê chuột ra vào
        private void button1_MouseHover(object sender, EventArgs e)
        {
            start.Font = new Font(start.Font.Name, 25);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            start.Font = new Font(start.Font.Name, 16);
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            howtoplay.Font = new Font(start.Font.Name, 12);
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            howtoplay.Font = new Font(start.Font.Name, 10);
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            exit.Font = new Font(start.Font.Name, 12);
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            exit.Font = new Font(start.Font.Name, 10);
        }


        // cái này exit
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    
        // formclosing
        private void batdau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
       

        // cái này click nút start để qua menu
        private void button1_Click(object sender, EventArgs e)
        {
            menu1 m = new menu1();
            m.FormClosed += new FormClosedEventHandler(m_formClosed);
            m.Show();
            this.Hide();
            player.Stop();
       
        }
        // cái này để từ cái menu trở về form start
        private void m_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            player.Play();
        }

        // m làm xong r sửa cái này dùm tao , cái này là hướng dẫn cách chơi :v
        private void button2_Click(object sender, EventArgs e)
        {
            HuongDan huongDan = new HuongDan();
            huongDan.ShowDialog();//nhớ sửa nốt cái định dạng font của hướng dẫn
            //thích thì tô nền lên cho đẹp luôn
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            highscore m = new highscore();
            m.Show();
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            button1.Font = new Font(start.Font.Name, 12);
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.Font = new Font(start.Font.Name, 10);
        }
    }
}
