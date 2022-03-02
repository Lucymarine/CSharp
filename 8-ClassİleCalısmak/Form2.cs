using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_ClassİleCalısmak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            arabalar rbl = new arabalar();
            rbl.renk = "Sarı";
            rbl.fiyat = 35.400;
            rbl.durum = 's';
            rbl.model = 2016;
            rbl.hiz = 220;

            label1.Text = rbl.renk;
            label2.Text = rbl.fiyat.ToString();
            label3.Text = rbl.durum.ToString();
            label4.Text = rbl.model.ToString();
            label5.Text = rbl.hiz.ToString();

            this.BackColor = Color.Yellow;
        }
    }
}
