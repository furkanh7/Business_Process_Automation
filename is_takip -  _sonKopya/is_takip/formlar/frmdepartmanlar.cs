using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using is_takip.entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Contexts;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraCharts;

namespace is_takip.formlar
{
    public partial class frmdepartmanlar : Form
    {

        public frmdepartmanlar()
        {
            InitializeComponent();
        }

        private void frmdepartmanlar_Load(object sender, EventArgs e)
        {
            using (var context = new dbistakipEntities())
            {
                var sorgu = from veri in context.tblpersonel
                            where veri.durum == true
                            group veri by veri.departman2 into grup
                            select new { Sutun = grup.Key, Sayi = grup.Count() };

                var sıralıSorgu = sorgu.OrderByDescending(x => x.Sayi);

                var series = new DevExpress.XtraCharts.Series("", DevExpress.XtraCharts.ViewType.Bar);


                foreach (var item in sıralıSorgu)
                {
                    series.Points.Add(new DevExpress.XtraCharts.SeriesPoint(item.Sutun, item.Sayi));
                }

                chartControl1.Series.Clear();
                chartControl1.Series.Add(series);
            }
            txtid.Enabled = false;
            listele();

        }
        dbistakipEntities db = new dbistakipEntities();



        void listele()
        {

            var degerler = (from x in db.tbldepartmanlar
                            select new
                            {
                                İD = x.id,
                                DepartmanAdı = x.ad,
                                Durum = x.durum
                            }).ToList();
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("İD").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("DepartmanAdı").ToString();
        }

        private void btnlistelee_Click_1(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string inputValue = txtad.Text.Trim();         //aynı veri girişini engelleyen kod
            tbldepartmanlar existingData = db.tbldepartmanlar.FirstOrDefault(x => x.ad == inputValue);

            if (existingData != null)
            {
                if (existingData.durum)
                {
                    MessageBox.Show("Bu departman zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    existingData.durum = true; // Durumu false olan veriyi güncelle
                }
            }
            else
            {
                tbldepartmanlar t = new tbldepartmanlar();
                t.ad = txtad.Text;
                t.durum = true;
                db.tbldepartmanlar.Add(t);
            }

            db.SaveChanges();
            listele();
            XtraMessageBox.Show("Kayıt başarılı bir şekilde eklendi", "BİLGİ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtad.Text = string.Empty;
        }
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string inputValue = txtad.Text.Trim();         //aynı veri girişini engelleyen kod
            tbldepartmanlar existingData = db.tbldepartmanlar.FirstOrDefault(y => y.ad == inputValue);

            if (existingData != null)
            {
                if (existingData.durum)
                {
                    MessageBox.Show("Bu departman zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var deger = db.tbldepartmanlar.Find(x);
                deger.ad = txtad.Text;
                db.SaveChanges();
                listele();
                XtraMessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            try
            {
                if (XtraMessageBox.Show("silmek istiyor musunuz?", "silme işlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = int.Parse(txtid.Text);
                    var deger = db.tbldepartmanlar.Find(x);
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



    }

}
