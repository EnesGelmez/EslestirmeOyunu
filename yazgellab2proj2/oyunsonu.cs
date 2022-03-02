using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazgellab2proj2
{
    public partial class oyunsonu : Form
    {
        public int alinanpuan, denemesayisi, basari;
        public string kalandakika, kalansaniye;

        private void oyunsonu_Load(object sender, EventArgs e)
        {
            if (basari == 1)
            {
                label1.Text = "ZAMAN DOLDU";
                label1.Font = new System.Drawing.Font("Sitka Small", 54F, System.Drawing.FontStyle.Regular);
                label1.Location = new Point(5, 0);
                lbl_kalandakika.Text = kalandakika;
                lbl_kalansaniye.Text = ":" + kalansaniye;
                lbl_alinanpuan.Text = alinanpuan.ToString();
                lbl_oyunsonu_denemesayisi.Text = denemesayisi.ToString();
                lbl_alinanpuan.Location = new Point(188, 318);
            }
            else
            {
                lbl_kalandakika.Text = kalandakika;
                lbl_kalansaniye.Text = kalansaniye;
                lbl_alinanpuan.Text = alinanpuan.ToString();
                lbl_oyunsonu_denemesayisi.Text = denemesayisi.ToString();
            }

        }

        private void oyunsonu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_oyunsonu_menu_Click(object sender, EventArgs e)
        {
            giris girisfrm = new giris();
            this.Hide();
            girisfrm.Show();
        }


        public oyunsonu()
        {
            InitializeComponent();
        }

    }
}
