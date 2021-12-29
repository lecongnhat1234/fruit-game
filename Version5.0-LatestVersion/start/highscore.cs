using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace start
{
    public partial class highscore : Form
    {
        List<int> sArr = new List<int>();
        string file = Application.StartupPath + @"\music\BXH.txt";
        FileWork f = new FileWork();
        public highscore()
        {
            InitializeComponent();
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void highscore_Load(object sender, EventArgs e)
        {
            try
            {
                f.read(sArr, file);
            }catch(FileNotFoundException)
            {
                MessageBox.Show("Không có thông tin!!!");
            }
            sArr.Sort();
            List<Label> lb = new List<Label>(5) {label1, label2, label3, label4, label5};
            int n = 0;
            for (int i = 0; i < sArr.Count; i++)
            {
                lb[n].Text = sArr[sArr.Count - 1 - i].ToString();
                n++;
                if (n > 4)
                    break;
            }
            if (sArr.Count == 0)
                f.deleteF(file);
        }
    }
}
