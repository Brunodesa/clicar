using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicar
{
    class Class1
    {
        private static string _path = Application.StartupPath + "\\Resources\\Texto.txt";
        private int _pontos;
        private static int tmp = 30;
        private int _tempo = tmp;

        public void Move(object sender)
        {
            if (_tempo > 0)
            {
                Random r = new Random();
                int _x = int.Parse(r.Next(700).ToString());
                int _y = int.Parse(r.Next(250).ToString()) + 100;
                Point pt = new Point(_x, _y);
                Button b = (Button)sender;
                b.Location = pt;
            }
        }

        public string Conta()
        {
            if (_tempo > 0)
            {
                _pontos += 1;
            }
            return _pontos.ToString();
        }

        public string Temp()
        {
            if (_tempo > 0)
            {
                _tempo -= 1;
            }
            return _tempo.ToString();
        }

        public string ResP()
        {
            _pontos = 0;
            return (_pontos).ToString();
        }

        public string ResT()
        {
            _tempo = tmp;
            return (_tempo).ToString();
        }

        public void ResPos(object sender)
        {
            Point pt = new Point(350, 175);
            Button b = (Button)sender;
            b.Location = pt;
        }
    }
}