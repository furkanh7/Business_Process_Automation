using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.RichTextBox;
using is_takip.entity;
namespace is_takip.formlar
{
    public partial class frmürünler : Form
    {
        public frmürünler()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        void urunlist()
        {
            var degerler = from x in db.tblurunler
                           select new
                           {
                               İD = x.id,
                               ÜrünAdı = x.adı,
                               ÜrünKodu = x.urunkodu,
                               Durum = x.durum,
                               Firma = x.firma,
                               Kategori = x.kategori,
                               BirimFiyat = x.birimfiyat,
                               Açıklama = x.aciklama,
                               ÜrünAdet = x.urunadet,
                               SatışFiyatı = x.satisfiyat,
                               ToplamFiyat = (x.urunadet * x.birimfiyat),
                           };
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["İD"].Width = 15;
            gridView1.Columns["ÜrünKodu"].Width = 80;
        }

        private void frmürünler_Load(object sender, EventArgs e)
        {
            urunlist();
            var firmalar = (from x in db.tblfirmalar
                            select new
                            {
                                x.id,
                                x.ad
                            }).ToList();
            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.Properties.DisplayMember = "ad";
            lookUpEdit1.Properties.DataSource = firmalar;
            var kategori = (from x in db.tblkategori
                            select new
                            {
                                x.id,
                                x.kategori
                            }).ToList();
            lookUpEdit3.Properties.ValueMember = "id";
            lookUpEdit3.Properties.DisplayMember = "kategori";
            lookUpEdit3.Properties.DataSource = kategori;
            txtid.Enabled = false;
        }

        private void btnlistelee_Click(object sender, EventArgs e)
        {
            urunlist();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                string inputValue = txtkod.Text.Trim();
                tblurunler existingData = db.tblurunler.FirstOrDefault(x => x.urunkodu == inputValue);

                if (existingData != null)
                {
                    if (existingData.durum)
                    {
                        MessageBox.Show("Bu kod ile eşleşen ürün zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        existingData.durum = true; // Durumu false olan veriyi güncelle
                    }
                }
                else
                {
                    tblurunler t = new tblurunler();
                    t.durum = true;
                    t.adı = txtad.Text;
                    t.urunkodu = txtkod.Text;
                    t.urunadet = int.Parse(txtadet.Text);
                    t.firma = lookUpEdit1.Text;
                    t.birimfiyat = double.Parse(txtfiyat.Text);
                    t.satisfiyat = double.Parse(txtsatisfiyat.Text);
                    t.aciklama = txtaciklama.Text;
                    t.kategori = lookUpEdit3.Text;
                    db.tblurunler.Add(t);
                }
                db.SaveChanges(); urunlist();
                XtraMessageBox.Show("Yeni Ürün Kaydı Oluşturuldu", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("silmek istiyor musunuz?", "silme işlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = int.Parse(txtid.Text);
                    var deger = db.tblurunler.Find(x);
                    deger.durum = false;
                    db.SaveChanges();
                    urunlist();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("İD").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("ÜrünAdı").ToString();
            txtkod.Text = gridView1.GetFocusedRowCellValue("ÜrünKodu").ToString();
            txtadet.Text = gridView1.GetFocusedRowCellValue("ÜrünAdet").ToString();
            txtfiyat.Text = gridView1.GetFocusedRowCellValue("BirimFiyat").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Firma").ToString();
            lookUpEdit3.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
            txtsatisfiyat.Text = gridView1.GetFocusedRowCellValue("SatışFiyatı").ToString();
            txtaciklama.Text = gridView1.GetFocusedRowCellValue("Açıklama").ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtid.Text);
                var deger = db.tblurunler.Find(x);

                if (deger != null)
                {
                    if (deger.urunkodu == txtkod.Text.Trim())
                    {
                        deger.adı = txtad.Text;
                        deger.urunkodu = txtkod.Text;
                        deger.urunadet = int.Parse(txtadet.Text);
                        deger.birimfiyat = double.Parse(txtfiyat.Text);
                        deger.firma = lookUpEdit1.Text;
                        deger.kategori = lookUpEdit3.Text;
                        deger.satisfiyat = double.Parse(txtsatisfiyat.Text);
                        deger.aciklama = txtaciklama.Text;

                        db.SaveChanges();
                        urunlist();
                        XtraMessageBox.Show("Ürün başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var existingData = db.tblurunler.FirstOrDefault(y => y.urunkodu == txtkod.Text.Trim());
                        if (existingData != null)
                        {
                            MessageBox.Show("Bu kod ile eşleşen ürün zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            deger.adı = txtad.Text;
                            deger.urunkodu = txtkod.Text;
                            deger.urunadet = int.Parse(txtadet.Text);
                            deger.birimfiyat = double.Parse(txtfiyat.Text);
                            deger.firma = lookUpEdit1.Text;
                            deger.kategori = lookUpEdit3.Text;
                            deger.satisfiyat = double.Parse(txtsatisfiyat.Text);
                            deger.aciklama = txtaciklama.Text;

                            db.SaveChanges();
                            urunlist();
                            XtraMessageBox.Show("Ürün başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
