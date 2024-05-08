using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmkategori : Form
    {
        public frmkategori()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        void listele()
        {

            var degerler = (from x in db.tblkategori
                            select new
                            {
                                İD = x.id,
                                KategoriAdı = x.kategori,
                                Durum = x.durum
                            }).ToList();
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
        }

        private void frmkategori_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("İD").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("KategoriAdı").ToString();
        }

        private void btnlistelee_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string inputValue = txtad.Text.Trim();         //aynı veri girişini engelleyen kod
            tblkategori existingData = db.tblkategori.FirstOrDefault(x => x.kategori == inputValue);

            if (existingData != null)
            {
                if (existingData.durum)
                {
                    MessageBox.Show("Bu Kategori zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    existingData.durum = true; // Durumu false olan veriyi güncelle
                }
            }
            else
            {
                tblkategori t = new tblkategori();
                t.kategori = txtad.Text;
                t.durum = true;
                db.tblkategori.Add(t);
            }
           
            db.SaveChanges();
            listele();
            XtraMessageBox.Show("Kategori başarılı bir şekilde eklendi", "BİLGİ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtad.Text = string.Empty;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            try
            {
                if (XtraMessageBox.Show("silmek istiyor musunuz?", "silme işlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = int.Parse(txtid.Text);
                    var deger = db.tblkategori.Find(x);
                    deger.durum = false;
                    db.SaveChanges();
                    listele();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("girilen id ye uygun değer bulunamadı");
                return;
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string inputValue = txtad.Text.Trim();         //aynı veri girişini engelleyen kod
            tblkategori existingData = db.tblkategori.FirstOrDefault(x => x.kategori == inputValue);

            if (existingData != null)
            {
                if (existingData.durum)
                {
                    MessageBox.Show("Bu Kategori zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    existingData.durum = true; // Durumu false olan veriyi güncelle
                }
            }
            else
            {
                int x = int.Parse(txtid.Text);
                var deger = db.tblkategori.Find(x);
                deger.kategori = txtad.Text;
                db.SaveChanges();
                listele();
                XtraMessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
    }
}
