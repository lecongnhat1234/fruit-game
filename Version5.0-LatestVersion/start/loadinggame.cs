using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start
{
    public partial class loadinggame : Form
    {
        public loadinggame()
        {
            InitializeComponent();
        }

        // vẫn là xóa backcolor hình png
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

        private void loadinggame_Load(object sender, EventArgs e)
        {
            SetTransparent(backgroundloading, saitamar);
            SetTransparent(backgroundloading, loading);
            SetTransparent(backgroundloading, note);
        }
        
        // cái này dùng để chạy thanh loading ở dưới
        private void timer1_Tick(object sender, EventArgs e)
        {

            thanhphantram.Width += 3;
            if (thanhphantram.Width >= 1253)
            {
                timer1.Stop();
                this.Close();
                
            }
        }
    }
}
