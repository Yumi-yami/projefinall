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
    public partial class GameForm : Form
    {
       
        public GameForm()
        {

            InitializeComponent();
            button1.Parent = this;
            button1.BringToFront();

        }
        private void TilkiResmiGuncelle()
        {
            pbTilki.Image = Properties.Resources.mutlu_tilki;

            int enerji = barUyku.Value;
            int eglence = prgEglence.Value;
            int aclik = progressBarYemek.Value;


            // Hepsi yüksek
            if (enerji > 70 && eglence > 70 && aclik > 70)
            {
                pbTilki.Image = Properties.Resources.mutlu_tilki;
                return;
            }

            // Sadece enerji düşük
            if (enerji < 30 && eglence >= 30 && aclik >= 30)
            {
                pbTilki.Image = Properties.Resources.yorgun_tilki;
                return;
            }

            // Diğer durumlar → üzgün
            if (eglence <30 || aclik <30 || enerji <30 )
            {
                pbTilki.Image = Properties.Resources.üzgün_tilki;
                return;
            }
        }

        private void tmrDurumAzalma_Tick(object sender, EventArgs e)
        {
            barUyku.Value = Math.Max(0, barUyku.Value - 1);
            prgEglence.Value = Math.Max(0, prgEglence.Value - 1);
            progressBarYemek.Value = Math.Max(0, progressBarYemek.Value - 1);
            TilkiResmiGuncelle();

        }

        private void GameForm_Load_1(object sender, EventArgs e)
        {
            barUyku.Value = 50;
            prgEglence.Value = 50;
            progressBarYemek.Value = 50;

            tmrDurumAzalma.Start();   // 🔴 Barlar azalmaya başlar

            TilkiResmiGuncelle();
            pnlGece.Visible = false;
            
            // cikis butonunu en öne getir
        }

        private void pbTilki_Click(object sender, EventArgs e)
        {

        }

        private void Btnuyku_Click(object sender, EventArgs e)
        {
            tmrDurumAzalma.Stop();   // Barların azalmasını durdur
            pnlGece.BringToFront(); // Paneli öne al
            pnlGece.Visible = true; // Ekranı karart
            tmrUyku.Start();        // Uyku süresi başlasın

        }

        private void tmrUyku_Tick(object sender, EventArgs e)
        {
            tmrUyku.Stop();

            barUyku.Value = 100;

            pnlGece.Visible = false;

            tmrDurumAzalma.Start();
            TilkiResmiGuncelle();

        }

        private void btnoyun_Click(object sender, EventArgs e)
        {
            OyunMiniForm oyunForm = new OyunMiniForm();

            DialogResult sonuc = oyunForm.ShowDialog();

            if (sonuc == DialogResult.OK && oyunForm.Tag != null)
            {
                int artis = (int)oyunForm.Tag;
                prgEglence.Value = Math.Min(100, prgEglence.Value + artis);
                TilkiResmiGuncelle();
            }
        }

        private void btnyemek_Click(object sender, EventArgs e)
        {
            YemekMiniForm frm = new YemekMiniForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                int yeniDeger = progressBarYemek.Value + frm.KazanilanPuan;

                if (yeniDeger > progressBarYemek.Maximum)
                    yeniDeger = progressBarYemek.Maximum;
                else if (yeniDeger < progressBarYemek.Minimum)
                    yeniDeger = progressBarYemek.Minimum;

                progressBarYemek.Value = yeniDeger;

                TilkiResmiGuncelle(); // yemek sonrası tilki güncellensin
            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

