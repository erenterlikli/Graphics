using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafikler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float d1, d2, d3, toplam; //değerleri almak
            d1 = int.Parse(txt1.Text);
            d2 = int.Parse(txt2.Text);
            d3 = int.Parse(txt3.Text);

            toplam = d1 + d2 + d3;

            float pd1, pd2, pd3; //değerleri 360 derecelik grafik üzerinde yazdırmak
            pd1 = (d1 / toplam) * 360;
            pd2 = (d2 / toplam) * 360;
            pd3 = (d3 / toplam) * 360;


            Pen p = new Pen(Color.White, 4); //sınırları çizdirelim.
            Graphics g = this.CreateGraphics();
            Rectangle rec = new Rectangle(txt1.Location.X + txt1.Size.Width + 10, 10, 250, 250); //forma grafik için alan ayırdık.
            Brush b1 = new SolidBrush(Color.Green); //1.alanın rengi
            Brush b2 = new SolidBrush(Color.Yellow); //2.alanın rengi
            Brush b3 = new SolidBrush(Color.Red); //3.alanın rengi

            g.Clear(Form1.DefaultBackColor);

            g.DrawPie(p, rec, 0, pd1); //1.alanı çiz ve içini doldur. Sınırları belli.
            g.FillPie(b1, rec, 0, pd1);

            g.DrawPie(p, rec, pd1, pd2); //2.alanı çiz ve içini doldur.
            g.FillPie(b2, rec, pd1, pd2);

            g.DrawPie(p, rec, pd1 + pd2, pd3); //3.alan için.
            g.FillPie(b3, rec, pd1 + pd2, pd3);
     







        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }
    }
}
