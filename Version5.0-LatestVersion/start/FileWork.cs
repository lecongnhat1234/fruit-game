using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start
{
    class FileWork
    {
        public void ghiTenNhac(string s, string tenFile)
        {
            using (StreamWriter sw = new StreamWriter(tenFile,false))
            {
                sw.WriteLine(s);
                sw.Close();
            }
        }
        public void read(ref string s, string tenFile)
        {
            StreamReader sr = new StreamReader(tenFile);
            s = sr.ReadLine();
            sr.Close();
        }
        public void write(string s, string file)
        {
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine(s);
            sw.Close();
        }
        public void read(List<int> s, string file)
        {
            StreamReader sr = new StreamReader(file);
            string check;
            while (sr.Peek() >= 0)
            {
                int tmp;
                check = sr.ReadLine();
                if (int.TryParse(check, out tmp))
                    s.Add(tmp);
                else
                    continue;
            }
            sr.Close();
        }
        public void deleteF(string file)
        {
            if (File.Exists(file))
                File.Delete(file);
            if (!File.Exists(file))
                SystemSounds.Exclamation.Play();
        }
    }
}
