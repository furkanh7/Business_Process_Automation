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
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        private void frmanaform_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.tblgorevler select new
            {

               GörevAçıklaması =x.aciklama,
               GörevVeren =  x.tblpersonel.ad + " " +x.tblpersonel.soyad,
               x.durum

                
            }).Where(y=> y.durum == true).ToList();
            gridView1.Columns["durum"].Visible = false;
            // bugün yapılan görevler;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.tblgorevdetaylar select new
            {
                görev = x.tblgorevler.aciklama,
                x.aciklama,
                x.tarih
            }).Where(x=> x.tarih == bugun).ToList();
          
            //aktif çağrı listesi
            
            //fihrist komutları
           gridControl4.DataSource = (from x in db.tblfirmalar select new
           {
               x.ad,
               x.telefon,
               x.mail
           }).ToList();
            try
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
                lblaktifgörev.Text = db.tblgorevler.Where(x => x.durum == true).Count().ToString();
                lblpasifgörev.Text = db.tblgorevler.Where(x => x.durum == false).Count().ToString();
                lbltoplamdepartman.Text = db.tbldepartmanlar.Count().ToString();
                chartControl2.Series["durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblaktifgörev.Text));
                chartControl2.Series["durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblpasifgörev.Text));
               
            }
            catch (Exception)
            {

                
            }
           
        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
