using OtelRezervasyon.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.UI
{
    public partial class FrmMusteriKayit : Form
    {
        public FrmMusteriKayit()
        {
            InitializeComponent();
        }
        List<MusteriOda> musteriOdalar = new List<MusteriOda>();
        Oda oda1 = new Oda();
        MusteriOda secilenOda;
        private void FrmMusteriKayit_Load(object sender, EventArgs e)
        {
            for (int row = 1; row < 4; row++)
            {
                Label label = new Label();
                label.Text = row.ToString() + " Kişilik Odalar";
                flRooms.Controls.Add(label);
                flRooms.SetFlowBreak(label, true);
                for (int column = 1; column <= 10; column++)
                {
                    Button btn = new Button();
                    btn.Text = ((row * 100) + column).ToString();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.BackColor = Color.Green;
                    btn.Tag = new MusteriOda()
                    {
                        KalinacakOda = new Oda()
                        {
                            OdaIsmi = ((row * 100) + column).ToString(),
                            OdaKisiSayisi = row,
                            OdaUcreti = row * 50,
                            OdaDurum = OdaDurum.Bos,
                        },
                    };
                    btn.MouseUp += Btn_Click;

                    flRooms.Controls.Add(btn);
                }
            }
            btnKral.Tag = new MusteriOda()
            {
                KalinacakOda = new Oda()
                {
                    OdaIsmi = "Kral Dairesi",
                    OdaKisiSayisi = 5,
                    OdaUcreti = 1000,
                    OdaDurum = OdaDurum.Bos,
                },
                Musteri = new Musteri()
                {
                    MusteriAd = "",
                    MusteriTC = "",
                    Tel = "",
                }
            };
        }
        Button tiklanilanButton = null;

        private void Btn_Click(object sender, MouseEventArgs e)
        {
            string odaAdi = ((Button)sender).Text.ToString();
            tiklanilanButton = sender as Button;
            secilenOda = tiklanilanButton.Tag as MusteriOda;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    //label4.Tag = ((Button)sender).Tag;
                    tiklanilanButton.Tag  = ((Button)sender).Tag;
                    label4.Text = odaAdi + " no'lu oda seçili.";
                    gbMusteriBilgiler.Enabled = true;
                    break;
                case MouseButtons.Right:
                    OdaDurumDegistir(secilenOda.KalinacakOda.OdaDurum);
                    break;

            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MusteriOda odaRez = tiklanilanButton.Tag as MusteriOda;
            if (odaRez.KalinacakOda.OdaDurum == OdaDurum.Bos 
                || odaRez.KalinacakOda.OdaDurum == OdaDurum.Temizlik)
            {
                odaRez.Musteri = new Musteri()
                {
                    MusteriAd = txtMusteriAd.Text,
                    MusteriTC = txtTC.Text,
                    Tel = txtTel.Text,
                };
                odaRez.KalinacakOda.OdaDurum = OdaDurum.Dolu;
                musteriOdalar.Add(odaRez);
                tiklanilanButton.BackColor = Color.Red;
                MessageBox.Show("Kayıt Başarılı.");
                this.Tag = musteriOdalar;
                MusteriBilgileriniTemizle();
                //MusteriOlustur();

            }
            else
            {
                MessageBox.Show("Oda Dolu.");
            }
        }
        private void MusteriBilgileriniTemizle()
        {
            foreach (Control item in gbMusteriBilgiler.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        void MusteriOlustur()
        {
            //todo if kontrolleri yapılacak 
            musteriOdalar.Add(new MusteriOda()
            {
                Musteri = new Musteri()
                {
                    MusteriAd = txtMusteriAd.Text,
                    MusteriTC = txtTC.Text,
                    Tel = txtTel.Text,
                },
                GirisTarihi = dateTimePicker1.Value,
                KalinacakOda = label4.Tag as Oda,

            });

        }
        void ButonuEtkisizlestir()
        {
            //todo oda sayısı kontrolu
            Oda oda = label4.Tag as Oda;
            foreach (Control item in flRooms.Controls)
            {
                if (item is Button)
                {
                    if (item.Text.ToString() == oda.OdaIsmi.ToString()
                        )
                    {
                        item.BackColor = Color.Red;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void btnKral_Click(object sender, EventArgs e)
        {
            gbMusteriBilgiler.Enabled = true;
            tiklanilanButton = sender as Button;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCikis frmCikis = new FrmCikis(musteriOdalar);
            frmCikis.Show();
        }
        private void OdaDurumDegistir(OdaDurum odaDurum)
        {
            if (odaDurum == OdaDurum.Bos)
            {
                secilenOda = tiklanilanButton.Tag as MusteriOda;
                secilenOda.KalinacakOda.OdaDurum = OdaDurum.Temizlik;
                tiklanilanButton.BackColor = Color.Cyan;
                MessageBox.Show("Oda Durumu " + OdaDurum.Temizlik.ToString() + " Olarak Değiştirildi.");
            }
            else if (odaDurum == OdaDurum.Temizlik)
            {
                secilenOda = tiklanilanButton.Tag as MusteriOda;
                secilenOda.KalinacakOda.OdaDurum = OdaDurum.Bos;
                tiklanilanButton.BackColor = Color.Green;
                MessageBox.Show("Oda Durumu " + OdaDurum.Bos.ToString() + " Olarak Değiştirildi.");

            }
        }
    }
}
