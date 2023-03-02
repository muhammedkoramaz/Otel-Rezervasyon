using OtelRezervasyon.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelRezervasyon.UI
{
    public partial class FrmRapor : Form
    {
        private List<MusteriOda> musteriOdalar;

        public FrmRapor()
        {
            InitializeComponent();
        }

        public FrmRapor(List<MusteriOda> musteriOdalar) :this()
        {
            this.musteriOdalar = musteriOdalar;
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = musteriOdalar;
            ListViewYazdir();

        }
        private void ListViewYazdir()
        {
            listView1.Items.Clear();
            foreach (MusteriOda item in musteriOdalar)
            {
                ListViewItem h1 = new ListViewItem(item.Musteri.MusteriAd, 0);
                h1.SubItems.Add(item.GirisTarihi.ToString());
                h1.SubItems.Add(item.CikisTarihi.ToString());
                h1.SubItems.Add(item.KalinacakOda.OdaIsmi.ToString());
                h1.SubItems.Add(item.ToplamBorc.ToString());

                listView1.Items.AddRange(new ListViewItem[] { h1 });
            }
        }
    }
}
