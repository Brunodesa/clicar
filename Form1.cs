using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Class1 Classe = new Class1();

        Class1 c = new Class1();

        private void Button1_Click(object sender, EventArgs e)
        {
            label5.Text = c.Conta();
            timer1.Start();
            c.Move(sender);
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = c.Temp();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            c.ResPos(button1);
            label1.Text = c.ResP();
            label5.Text = c.ResT();
        }
    }
}
