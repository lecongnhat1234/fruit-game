using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace start
{
    class RandomFruits
    {
        int speed = 8;
        System.Random rndX = new System.Random();
        System.Random rndY = new System.Random();
        public void setRandom(PictureBox pic, Form x, PictureBox main,ref int score,ref int missed, int scoreOfFruits)
        {
            pic.Top += speed;
            if (pic.Top + pic.Height > x.ClientSize.Height)
            {
                pic.Top = rndY.Next(80, 300) * -1;
                pic.Left = rndX.Next(5, x.ClientSize.Width - pic.Width);
                missed++;
            }
            if (pic.Bounds.IntersectsWith(main.Bounds))
            {
                pic.Top = rndY.Next(80, 300) * -1;
                pic.Left = rndX.Next(5, x.ClientSize.Width - pic.Width);
                score += scoreOfFruits;
            }
        }

        public void specialFruits(PictureBox pic, Form x, PictureBox main,ref int spd, int i, int n)
        {
            pic.Top += 30;
            if (pic.Top + pic.Height > x.ClientSize.Height && i > n)
            {
                pic.Top = rndY.Next(80, 300) * -1;
                pic.Left = rndX.Next(5, x.ClientSize.Width - pic.Width);
            }
            if (pic.Bounds.IntersectsWith(main.Bounds))
            {
                pic.Top = rndY.Next(80, 300) * -1;
                pic.Left = rndX.Next(5, x.ClientSize.Width - pic.Width);
                if (spd <= 50)
                    spd += 2;
            }
        }
        public void setFruitSpeed(PictureBox pic)
        {
            if (speed < 30)
                speed += 2;
        }
    }
}
