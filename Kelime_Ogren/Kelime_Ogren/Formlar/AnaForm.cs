using Kelime_Ogren.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Ogren.Formlar
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Btn_basla_Click(object sender, EventArgs e)
        {
            var Oyuna_Basla = (Oyuna_Basla)Application.OpenForms["Oyuna_Basla"];
            if (Oyuna_Basla==null)
                Oyuna_Basla = new Oyuna_Basla();

            Oyuna_Basla.Show();
        }

        private void Btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            var soruCevap = new SoruCecap();
            var sorununCevaplari = soruCevap.SorununCevabı();
            var verilenCevap = txt_cevap.Text;
            bool cevapDogrumu = false;
            string dogruCevaplar = "";

            foreach (var cevap in sorununCevaplari)
            {
                if (cevap.Trim()==verilenCevap.Trim())
                    cevapDogrumu = true;
            }

            if (cevapDogrumu)

            {
                    blb_dogrusayisi.Text = (Convert.ToInt32(blb_dogrusayisi.Text) + 1).ToString();
                    MessageBox.Show("Cevabınız Doğru", "Süpersinnn");
               
            }
                else
                {
                    foreach (var cevap in sorununCevaplari)
                    {
                        dogruCevaplar +=cevap;
                    }
                    lbl_yanlissayisi.Text = (Convert.ToInt32(lbl_yanlissayisi.Text) + 1).ToString();
                    MessageBox.Show("Cevabınız Yanlış!!!  Doğru Cevap = "+ dogruCevaplar, "Not Al ve Pes Etme...");
                }


            btn_onayla.Enabled = false;
            btn_digersoru.Enabled = true;
        }

        private void btn_digersoru_Click(object sender, EventArgs e)
        {
            SoruCecap soruCevap = new SoruCecap();
            soruCevap.SoruyuSec();

            string soru;
            if (DosyaIcerik.SoruDili == "Türkçe")
                soru = soruCevap.TurkceSoru();
            else if (DosyaIcerik.SoruDili == "İngilizce")
                soru = soruCevap.IngilizceSoru();
            else
                soru = soruCevap.KarisikSoru();

            lbl_kelime.Text = soru;
            btn_onayla.Enabled = true;
            btn_digersoru.Enabled = false;
            txt_cevap.Clear();

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            btn_onayla.Enabled = false;
            btn_digersoru.Enabled = false;
            
        }
    }
}
