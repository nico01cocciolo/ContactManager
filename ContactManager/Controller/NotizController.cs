using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Controller
{
    internal class NotizController
    {
        public void NotizErfassen(string path, string notiz)
        {
            StreamWriter sw = File.AppendText(path);

            sw.Write($"{DateTime.Today.ToShortDateString()}: {notiz}");
            sw.Write("\r\n");
            sw.Close();
        }

        public string NotizLaden(string path)
        {
            string line;
            string temp = "";

            StreamReader sr = File.OpenText(path);
            line = sr.ReadLine();

            while (line != null)
            {
                temp += line + "\r\n";
                line = sr.ReadLine();
            }
            
            sr.Close();
            return temp;
            
        }

    }
}
