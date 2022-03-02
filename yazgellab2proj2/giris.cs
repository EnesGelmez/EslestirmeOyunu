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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void cmb_giris_satir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_giris_sutun.Items.Clear();

            if (cmb_giris_satir.Text== "2")
            {
                this.cmb_giris_sutun.Items.AddRange(new object[] {
                "2",
                "3",
                "4",
                "5",
                "6"});
            }
            else if (cmb_giris_satir.Text == "3")
            {
                this.cmb_giris_sutun.Items.AddRange(new object[] {
                "2",
                "4",
                "6"});
            }
            else if (cmb_giris_satir.Text == "4")
            {
                this.cmb_giris_sutun.Items.AddRange(new object[] {
                "2",
                "3",
                "4",
                "5",
                "6"});
            }
            else if (cmb_giris_satir.Text == "5")
            {
                this.cmb_giris_sutun.Items.AddRange(new object[] {
                "2",
                "4",
                "6"});
            }
            else if (cmb_giris_satir.Text == "6")
            {
                this.cmb_giris_sutun.Items.AddRange(new object[] {
                "2",
                "3",
                "4",
                "5",
                "6"});
            }
        }

        private void btn_giris_basla_Click(object sender, EventArgs e)
        {
            oyun ofrm = new oyun();
            int satir = Convert.ToInt32(cmb_giris_satir.Text);
            int sutun = Convert.ToInt32(cmb_giris_sutun.Text);
            
            if (cmb_giris_tema.Text == "Meyveler")
            {
                ofrm.tema = "Meyveler";
            }
            else if (cmb_giris_tema.Text == "Hayvanlar")
            {
                ofrm.tema = "Hayvanlar";
            }
            else if (cmb_giris_tema.Text == "Meslekler")
            {
                ofrm.tema = "Meslekler";
            }
            else if (cmb_giris_tema.Text == "Renkler")
            {
                ofrm.tema = "Renkler";
            }

            if (satir* sutun == 0)
            {
                MessageBox.Show("Lütfen geçerli değerler girdiğinizden emin olunuz.");
            }
            if (cmb_giris_tema.SelectedItem == null)
            {
                MessageBox.Show("Lütfen oynamak istediğiniz temayı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                ofrm.satir = satir;
                ofrm.sutun = sutun;
                this.Hide();
                ofrm.Show();

            }
        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
