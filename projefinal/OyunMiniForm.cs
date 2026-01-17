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
    public partial class OyunMiniForm : Form
    {
        int hiz = 6;
        int eskiX;
        int eskiY;
        DateTime baslangicZamani;
        int saniye = 0;


        public OyunMiniForm()
        {
            InitializeComponent();
        }

        private void OyunMiniForm_KeyDown(object sender, KeyEventArgs e)
        {
            eskiX = pbOyuncu.Left;
            eskiY = pbOyuncu.Top;

            // Hareket
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                pbOyuncu.Left -= hiz;
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                pbOyuncu.Left += hiz;
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                pbOyuncu.Top -= hiz;
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                pbOyuncu.Top += hiz;

            // Duvar çarpışma kontrolü
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c.Tag == "Duvar")
                {
                    if (pbOyuncu.Bounds.IntersectsWith(c.Bounds))
                    {
                        // Çarpışma varsa geri al
                        pbOyuncu.Left = eskiX;
                        pbOyuncu.Top = eskiY;
                        break;
                    }
                }
            }
            // Hedefe ulaştı mı?
            if (pbOyuncu.Bounds.IntersectsWith(pbHedef.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler! Parkuru tamamladın 🎉");

                TimeSpan gecenSure = DateTime.Now - baslangicZamani;
                int saniye = (int)gecenSure.TotalSeconds;

                int kazanilanEglence;

                if (saniye <= 20)
                    kazanilanEglence = 90;
                else if (saniye <= 25)
                    kazanilanEglence = 60;
                else
                    kazanilanEglence = 30;

                // 👇 EN SON
                this.Tag = kazanilanEglence;
                this.DialogResult = DialogResult.OK;
                this.Close();
                

            }


        }

        private void OyunMiniForm_Load(object sender, EventArgs e)
        {
            baslangicZamani = DateTime.Now;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSecond.Text = "Süre: "+ saniye.ToString();
        }
    }
}
