using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projefinal
{
    public partial class YemekMiniForm : Form
    {
        public int KazanilanPuan { get; private set; }

        int puan = 0;
        int sure = 10;
        Random rnd = new Random();
        Image[] iyiYemekler;
        Image[] kotuYemekler;




        public YemekMiniForm()
        {
            InitializeComponent();

        }

        void YemekTiklandi(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb == null) return;

            string tur = pb.Tag.ToString();

            if (tur == "iyi")
                puan += 20;
            else if (tur == "kotu")
                puan -= 10;
            else if (tur == "bomba")
                puan = 0;

            lblPuan.Text = "Puan: " + puan;
        }
        void YemekOlustur(string tur)
        {
            PictureBox pb = new PictureBox();
            pb.Width = 50;
            pb.Height = 50;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            pb.Left = rnd.Next(0, this.ClientSize.Width - pb.Width);
            pb.Top = rnd.Next(40, this.ClientSize.Height - pb.Height);

            pb.Tag = tur;

            // 🔹 RESİMLER
            if (tur == "iyi")
                pb.Image = Image.FromFile("resimler/elma.png");
            else if (tur == "kotu")
                pb.Image = Image.FromFile("resimler/cikolata.png");
            else if (tur == "bomba")
                pb.Image = Image.FromFile("resimler/bomba.png");

            pb.Click += YemekTiklandi;

            this.Controls.Add(pb);
            pb.BringToFront();
        }
        private void YemekMiniForm_Load(object sender, EventArgs e)
        {
            lblPuan.Text = "Puan: 0";
            lblSüre.Text = "Süre: 10";
            tmrSure.Start();
            tmrHareket.Start();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox)
                {
                    PictureBox pb = ctrl as PictureBox;

                    if (pb.Tag != null)
                        pb.Click += YemekTiklandi;
                }
            }

        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSüre.Text = "Süre: " + sure;

            if (sure <= 0)
            {
                tmrSure.Stop();
                tmrHareket.Stop();

                KazanilanPuan = puan; // 👈 ANA FORMA GİDECEK PUAN

                MessageBox.Show("Oyun bitti!\nPuan: " + puan);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }


           

            // TIKLAMA OLUNCA
           
        }

        private void tmrHareket_Tick(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox)
                {
                    PictureBox pb = ctrl as PictureBox;

                    if (pb.Tag != null) // sadece yemekler
                    {
                        pb.Left = rnd.Next(0, this.ClientSize.Width - pb.Width);
                        pb.Top = rnd.Next(40, this.ClientSize.Height - pb.Height);
                    }
                }
            }
        }
    }
}