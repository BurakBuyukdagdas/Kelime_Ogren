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
    public partial class Oyuna_Basla : Form
    {
        private string _dosyaYolu = "";
        public Oyuna_Basla()
        {
            InitializeComponent();
        }

        private void Btn_dosyasec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "Txt File | *.txt",
                Multiselect = false
            };
            if (file.ShowDialog()==DialogResult.OK)
            {
                _dosyaYolu = file.FileName;
                btn_dosyasec.Text = _dosyaYolu;
            }
            
                _dosyaYolu=file.FileName;
            

        }

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_dosyaYolu))
                DosyaIcerik.Icerik = DosyaIslemleri.ReadLinesOfFile(_dosyaYolu);
            else MessageBox.Show("Hata! Lütfen Dosya Ekleyin");

        }

        private void Btn_oyunabasla_Click(object sender, EventArgs e)
        {
            if (DosyaIcerik.Icerik == null || DosyaIcerik.Icerik.Count == 0)
            {
                MessageBox.Show("Hata: Dosya içeriği boş veya dosya seçilmemiş. Lütfen önce bir dosya seçip ekleye basınız.");
            }
            else
            {
                if (rbtn_turkce.Checked)
                    DosyaIcerik.SoruDili = "Türkçe";
                else if (rbtn_ingilizce.Checked)
                    DosyaIcerik.SoruDili = "İngilizce";
                else if (rbtn_karisik.Checked)
                    DosyaIcerik.SoruDili = "Karışık";

                SoruCecap soruCevap = new SoruCecap();
                soruCevap.SoruyuSec();

                string soru;

                if (DosyaIcerik.SoruDili == "Türkçe")
                    soru = soruCevap.TurkceSoru();
                else if (DosyaIcerik.SoruDili == "İngilizce")
                    soru = soruCevap.IngilizceSoru();
                else
                    soru = soruCevap.KarisikSoru();

                var anaForm = (AnaForm)Application.OpenForms["AnaForm"];
                anaForm.lbl_kelime.Text = soru;
                anaForm.btn_onayla.Enabled = true;

                this.Hide();
            }
        }

        private void Btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
