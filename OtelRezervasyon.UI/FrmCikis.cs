using OtelRezervasyon.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon.UI
{
    public partial class FrmCikis : Form
    {
        private List<MusteriOda> musteriOdalar;
        Dictionary<string,int> myHashMap = new Dictionary<string, int>();
        int sayac=1 ,toplamBorc =0;

        public FrmCikis()
        {
            InitializeComponent();
        }

        public FrmCikis(List<MusteriOda> musteriOdalar) :this()
        {
            this.musteriOdalar = musteriOdalar;
        }

        private void FrmCikis_Load(object sender, EventArgs e)
        {
            foreach (var item in musteriOdalar)
            {
                cmbAdSoyad.Items.Add(item.Musteri);
               
            }
            myHashMap.Add("Cikolata", 5);
            myHashMap.Add("Su", 6);
            myHashMap.Add("Kola", 5);
            myHashMap.Add("Icki", 5);
            listBoxMiniDolap.Items.AddRange(myHashMap.Keys.ToArray());
        }

        private void cmbAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Musteri musteri = cmbAdSoyad.SelectedItem as Musteri;
            var sorgu = musteriOdalar.Where(a => a.Musteri.MusteriAd == musteri.MusteriAd);
            foreach (MusteriOda item in sorgu)
            {
                toplamBorc = item.KalinacakOda.OdaUcreti;
               

            }
            lblBorc.Text = toplamBorc.ToString();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            FrmRapor frmRapor = new FrmRapor(musteriOdalar);
            frmRapor.Show();
        }

        private void listBoxMiniDolap_SelectedIndexChanged(object sender, EventArgs e)
        {

            //listbox textine x2 falan yazsın 
            //if (listBox1.Items.Contains(listBoxMiniDolap.SelectedItem))
            //{
            //string flbItem = "";

            //listBox1.Items.Remove(listBoxMiniDolap.SelectedItem);
            //listBox1.Items.Add(listBoxMiniDolap.SelectedItem);
            //if (true)
            //{

            //}
            if (label.Text == listBoxMiniDolap.SelectedItem.ToString())
            {

                sayac++;
                label.Text = listBoxMiniDolap.SelectedItem.ToString() + "x" + sayac.ToString();
                foreach (Control item in flpAlinan.Controls)
                {



                    toplamBorc += myHashMap[listBoxMiniDolap.SelectedItem.ToString()];

                    flpAlinan.Controls.Add(label);asdas
                    lblBorc.Text = toplamBorc.ToString();
                }
            }
            else
            {
                label.Text = listBoxMiniDolap.SelectedItem.ToString();
            }


            //}
            //else
            //{
            //    label.Text = listBoxMiniDolap.SelectedItem.ToString();
            //    flpAlinan.Controls.Add(label);

            //    listBox1.Items.Add(listBoxMiniDolap.SelectedItem);
            //    toplamBorc += myHashMap[listBoxMiniDolap.SelectedItem.ToString()];
            //}


            //}

        }
    }
}
