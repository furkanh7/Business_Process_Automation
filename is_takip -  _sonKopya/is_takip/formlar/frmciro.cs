using DevExpress.Data.Helpers;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using is_takip.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip.formlar
{
    public partial class frmciro : Form
    {
        public frmciro()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmciro_Load(object sender, EventArgs e)
        {
            using (var context = new dbistakipEntities()) // YourDbContext, Entity Framework veritabanı bağlantınızı temsil eden sınıf adıdır.
            {
                var ciroVerileri = context.tblciro.ToList(); // tblciro tablosundaki verileri çekme
                chartControl1.DataSource = ciroVerileri;
            }
            Series series1 = new Series("", ViewType.Line); // Ciro verilerini göstermek için Line grafik türünü kullanıyoruz
            series1.ArgumentDataMember = "tarih"; // X ekseninde tarih sütununu kullanıyoruz
            series1.ValueDataMembers.AddRange(new string[] { "ciro" }); // Y ekseninde ciro sütununu kullanıyoruz
            chartControl1.Series.Add(series1);
           
            txtid.Enabled = false;
            listele();
        }
        dbistakipEntities db = new dbistakipEntities();
        void listele()
        {

            var degerler = (from x in db.tblciro
                            select new
                            {
                                İD = x.id,
                                CiroMiktarı = x.ciro,
                                Tarih = x.tarih,
                                Durum = x.durum
                            }).ToList();
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
        }

        private void btnlistelee_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
           
            tblciro t = new tblciro();
            t.ciro = double.Parse(txtciro.Text);
            t.tarih = DateTime.Parse(dateTimePicker1.Text);
            t.durum = true;
            db.tblciro.Add(t);
            db.SaveChanges();
            listele();
            chartControl1.RefreshData();
            XtraMessageBox.Show("Ciro başarılı bir şekilde eklendi", "BİLGİ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtid.Text);
            var deger = db.tblciro.Find(x);
            deger.ciro = double.Parse(txtciro.Text);
            deger.tarih = DateTime.Parse(dateTimePicker1.Text);
            db.SaveChanges();
            listele();
            XtraMessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("silmek istiyor musunuz?", "silme işlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = int.Parse(txtid.Text);
                    var deger = db.tblciro.Find(x);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("İD").ToString();
            txtciro.Text = gridView1.GetFocusedRowCellValue("CiroMiktarı").ToString();
            dateTimePicker1.Text = gridView1.GetFocusedRowCellValue("Tarih").ToString();
        }
    }
}
