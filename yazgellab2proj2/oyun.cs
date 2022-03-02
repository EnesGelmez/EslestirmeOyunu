using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace yazgellab2proj2
{
    public partial class oyun : Form
    {
        public string tema;
        public int satir, sutun;
        Random rnd = new Random();
        int btn_sayisi = 0, dakika = 4, saniye = 60, puan = 0;
        int[] indeks;
        Image[] resimler;
        PictureBox ilkkutu, ikincikutu, kutu;
        int ilkindex, bulunan = 0, deneme = 0, indeksNo, kutuno, cnt = 0, animasyoncounter = 0, basari = 0,pa=0;
        string kn;

        private void zaman_Tick(object sender, EventArgs e)
        {

            saniye = saniye - 1;
            saniyelbl.Text = ": " + Convert.ToString(saniye);
            dakikalbl.Text = Convert.ToString(dakika - 1);
            if (saniye < 10)
            {
                saniyelbl.Text = ": " + "0" + Convert.ToString(saniye);
            }
            if (saniye == 0)
            {
                dakika = dakika - 1;
                dakikalbl.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (dakikalbl.Text == "-1")
            {
                zaman.Stop();
                dakikalbl.Text = "00";
                saniyelbl.Text = "00";
                basari = 1;
                DialogResult result;
                result = MessageBox.Show("Süreniz bitti", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    oyunsonu oyunsonufrm = new oyunsonu();
                    oyunsonufrm.kalansaniye = saniyelbl.Text;
                    oyunsonufrm.kalandakika = dakikalbl.Text;
                    oyunsonufrm.basari = basari;
                    oyunsonufrm.denemesayisi = deneme;
                    oyunsonufrm.alinanpuan = puan;
                    this.Hide();
                    oyunsonufrm.Show();
                }
            }


        }

        private void oyun_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kaybolmaani_Tick(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                System.Threading.Thread.Sleep(500);
                cnt = 1;
            }
            kutu.Location = new Point(kutu.Location.X, kutu.Location.Y - 10);
            ikincikutu.Location = new Point(ikincikutu.Location.X, ikincikutu.Location.Y - 10);

            if (kutu.Bottom > ikincikutu.Bottom)
            {
                if (kutu.Bottom < 0)
                {
                    kaybolmaani.Stop();
                }
            }
            else
            {

                if (ikincikutu.Bottom < 0)
                {
                    kaybolmaani.Stop();
                }
            }
        }

        private void donmeani2_Tick(object sender, EventArgs e)
        {

            int s = kutu.Location.X;
            if (animasyoncounter == 0)
            {
                kutu.Location = new Point(kutu.Location.X + 3, kutu.Location.Y);
                kutu.Width -= 6;
                if (kutu.Location.X == s + 15)
                {
                    animasyoncounter = 1;
                }
                if (kutu.Size.Width == MinimumSize.Width)
                {
                    animasyoncounter = 1;
                    kutu.Image = resimler[indeksNo];
                }
            }
            else if (animasyoncounter == 1)
            {
                kutu.BackgroundImage = Properties.Resources.empty;
                kutu.Location = new Point(kutu.Location.X - 3, kutu.Location.Y);
                kutu.Width += 6;
                if (kutu.Width == 150)
                {
                    System.Threading.Thread.Sleep(1000);
                    animasyoncounter = 0;
                    donmeani2.Stop();
                    kutu.BackgroundImage = Properties.Resources.bgp;
                    ilkkutu.BackgroundImage = Properties.Resources.bgp;
                    ilkkutu.Image = null;
                    kutu.Image = null;
                    pa++;
                    if (ilkindex == indeksNo)
                    {
                        bulunan++;
                        puan = puan + 100/pa;
                        pa = 0;
                        anlikpuanlbl.Text = puan.ToString();
                        kutu.Image = Properties.Resources.tik;
                        ilkkutu.Image = Properties.Resources.tik;
                        System.Media.SoundPlayer dogru = new System.Media.SoundPlayer();
                        dogru.SoundLocation = "C:\\Users\\Enesg\\source\\repos\\yazgellab2proj2\\yazgellab2proj2\\Resources\\dogru.wav";
                        dogru.Play();
                        System.Threading.Thread.Sleep(250);
                        kaybolmaani.Start();

                        ikincikutu = ilkkutu;
                        if (bulunan == btn_sayisi / 2)
                        {
                            DialogResult result;
                            zaman.Stop();
                            result = MessageBox.Show("Tebrikler hepsini buldunuz", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == System.Windows.Forms.DialogResult.OK)
                            {
                                oyunsonu oyunsonufrm = new oyunsonu();
                                oyunsonufrm.kalansaniye = saniyelbl.Text;
                                oyunsonufrm.kalandakika = dakikalbl.Text;
                                oyunsonufrm.denemesayisi = deneme;
                                oyunsonufrm.alinanpuan = puan;
                                this.Hide();
                                oyunsonufrm.Show();
                            }
                        }
                    }
                    else
                    {
                        System.Media.SoundPlayer wrong = new System.Media.SoundPlayer();
                        wrong.SoundLocation = "C:\\Users\\Enesg\\source\\repos\\yazgellab2proj2\\yazgellab2proj2\\Resources\\yanlis.wav";
                        wrong.Play();
                        System.Threading.Thread.Sleep(500);
                    }
                    ilkkutu = null;

                }
            }
        }

        private void donmeani1_Tick(object sender, EventArgs e)
        {
            if (animasyoncounter == 0)
            {
                int s = ilkkutu.Location.X;
                ilkkutu.Location = new Point(ilkkutu.Location.X + 3, ilkkutu.Location.Y);
                ilkkutu.Width -= 6;
                if (ilkkutu.Location.X == s + 15)
                {
                    animasyoncounter = 1;
                }
                if (ilkkutu.Size.Width == MinimumSize.Width)
                {
                    animasyoncounter = 1;
                    ilkkutu.Image = resimler[indeksNo];
                }
            }
            else if (animasyoncounter == 1)
            {
                kutu.BackgroundImage = Properties.Resources.empty;
                ilkkutu.Location = new Point(ilkkutu.Location.X - 3, ilkkutu.Location.Y);
                ilkkutu.Width += 6;
                if (ilkkutu.Width == 150)
                {
                    animasyoncounter = 0;
                    donmeani1.Stop();
                }

            }
        }

        private void oyun_Load(object sender, EventArgs e)
        {
            if (satir * sutun <= 10)
            {
                dakika = 1;
            }
            else if (satir * sutun <= 20 && satir * sutun > 10)
            {
                dakika = 2;
            }
            else if (satir * sutun <= 40 && satir * sutun > 20)
            {
                dakika = 3;
            }
            zaman.Start();
            Random rnd = new Random();
            gb_oyun.Controls.Clear();
            int satirboy, sutunboy;
            satirboy = this.Height;
            sutunboy = this.Width;
            this.Width = 5 + 155 * sutun + 150;
            this.Height = 43 + 155 * satir;

            anlikpuanlbl.Location = new Point(this.Width - 105, 128);
            gb_oyun.Controls.Add(anlikpuanlbl);//354, 128
            saniyelbl.Location = new Point(this.Width - 90, 58);//349, 58
            gb_oyun.Controls.Add(saniyelbl);
            dakikalbl.Location = new Point(this.Width - 116, 58);
            gb_oyun.Controls.Add(dakikalbl);//372, 58
            denemesayisi.Location = new Point(this.Width - 90, 198);
            gb_oyun.Controls.Add(denemesayisi);//372, 58


            Button menubtn = new Button();
            menubtn.Name = "btn_oyun_menu";
            menubtn.Text = "MENU";
            menubtn.Size = new Size(70, 50);
            menubtn.BackColor = Color.FromArgb(217, 164, 58);
            menubtn.Location = new Point(this.Width - 114, 230);
            menubtn.FlatAppearance.BorderSize = 0;
            menubtn.FlatStyle = FlatStyle.Flat;
            menubtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            menubtn.Click += menuBtn_Click;
            gb_oyun.Controls.Add(menubtn);//340,198

            Label sureblbl = new Label();
            sureblbl.Name = "lbl_oyun_sure";
            sureblbl.Text = "SÜRE";
            sureblbl.BackColor = Color.FromArgb(99, 15, 15);
            sureblbl.ForeColor = Color.FromArgb(217, 164, 58);
            sureblbl.Location = new Point(this.Width - 113, 25);
            sureblbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            gb_oyun.Controls.Add(sureblbl);

            Label puanlbl = new Label();
            puanlbl.Name = "lbl_oyun_sure";
            puanlbl.Text = "PUAN";
            puanlbl.BackColor = Color.FromArgb(99, 15, 15);
            puanlbl.ForeColor = Color.FromArgb(217, 164, 58);
            puanlbl.Location = new Point(this.Width - 116, 100);//349, 100
            puanlbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            gb_oyun.Controls.Add(puanlbl);

            Label denemelbl = new Label();
            denemelbl.Name = "lbl_oyun_sure";
            denemelbl.Text = "DENEME";
            denemelbl.BackColor = Color.FromArgb(99, 15, 15);
            denemelbl.ForeColor = Color.FromArgb(217, 164, 58);
            denemelbl.Location = new Point(this.Width - 128, 175);//349, 100
            denemelbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            gb_oyun.Controls.Add(denemelbl);

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    btn_sayisi++;
                    PictureBox pb = new PictureBox();
                    pb.Name = "d" + btn_sayisi;
                    pb.Text = Convert.ToString(btn_sayisi);
                    pb.Size = new Size(150, 150);
                    pb.BackgroundImage = Properties.Resources.bgp;
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Location = new Point(9 + 155 * j, 11 + 155 * i);
                    gb_oyun.Controls.Add(pb);
                    pb.Click += Btn_Click;
                }
            }

            ArrayList al = new ArrayList();
            ArrayList asd = new ArrayList();
            int kutusayisi = (satir) * (sutun);
            resimler = new Image[kutusayisi / 2];
            for (int i = 0; i < kutusayisi / 2; i++)
            {

                int s = rnd.Next(1, 19);
            ss:
                if (asd.Contains(s))
                {
                    s = rnd.Next(1, 19);
                    goto ss;
                }
                asd.Add(s);
                //resimler[i] = (Bitmap)Properties.Resources.ResourceManager.GetObject('_' + s.ToString());
                resimler[i] = Image.FromFile("C:\\Users\\Enesg\\source\\repos\\yazgellab2proj2\\yazgellab2proj2\\Resources\\" + tema + "\\" + s + ".png");
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < kutusayisi / 2; j++)
                {
                    al.Add(j);
                }
            }
            indeks = (int[])al.ToArray(typeof(int));



            resimleriKaristir(kutusayisi);



        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            zaman.Stop();
            DialogResult result;
            result = MessageBox.Show("Menüye dönmek istediğinizden emin misiniz?\r", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                giris girisfrm = new giris();
                this.Hide();
                girisfrm.Show();

            }
            else
            {
                zaman.Start();
            }
        }

        private void resimleriKaristir(int k)
        {
            for (int i = 0; i < k; i++)
            {
                int rndsayi = rnd.Next(0, resimler.Length);
                int gecici = indeks[i];
                indeks[i] = indeks[rndsayi];
                indeks[rndsayi] = gecici;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            kutu = (PictureBox)sender;
            kutuno = int.Parse(kutu.Name.Substring(1));
            indeksNo = indeks[kutuno - 1];
            if (ilkkutu == null)
            {
                donmeani1.Start();
                ilkkutu = kutu;
                ilkindex = indeksNo;
                deneme++;
                denemesayisi.Text = deneme.ToString();
            }
            else
            {
                if (ilkkutu.Name != kutu.Name)
                {
                    donmeani2.Start();
                }
            }
        }

        public oyun()
        {
            InitializeComponent();
        }
    }
}
