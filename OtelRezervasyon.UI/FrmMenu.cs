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

namespace OtelRezervasyon.UI
{
    public partial class FrmMenu : Form
    {

        FrmMusteriKayit frmMusteriKayit = new FrmMusteriKayit();
        List<MusteriOda> rez = new List<MusteriOda>();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
              
            //todo mantıklı bir yöntem değil müşteri kayıt formu kapanınca bunu oluşturması gerek 

        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmMusteriKayit.MdiParent = this;
            frmMusteriKayit.Show();
        }

        private void tumRaporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriKayit.WindowState = FormWindowState.Minimized;

            rez = frmMusteriKayit.Tag as List<MusteriOda>;

            if (rez != null)
            {
            FrmRapor frmRapor = new FrmRapor(rez);
            frmRapor.MdiParent = this;
            frmRapor.Show();
            }
            else
            {
                MessageBox.Show("Raporda Görüntülenecek Veri Bulunmamaktadır.");
            }
        }

        private void musteriCikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rez = frmMusteriKayit.Tag as List<MusteriOda>;

            if (rez != null)
            {
                frmMusteriKayit.WindowState = FormWindowState.Minimized;
                FrmCikis frmCikis = new FrmCikis(rez);
                frmCikis.MdiParent = this;
                frmCikis.Show();
            }
            else
            {
                MessageBox.Show("Çıkışı Yapılacak Müşteri Bulunmamaktadır.");
            }
        }
    }
}
