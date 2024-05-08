using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmrapor : Form
    {
        public frmrapor()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        private void frmrapor_Load(object sender, EventArgs e)
        {
            listele();
            using (var context = new dbistakipEntities())
            {
                var data = context.tblsatis
                    .GroupBy(x => new { Ay = x.tarih.Month, Yil = x.tarih.Year })
                    .Select(g => new { Tarih = g.Key, ToplamFiyat = g.Sum(x => x.toplamfiyat) })
                    .ToList();

                var series = chartControl1.Series["Series 1"];
                series.Points.Clear();
                foreach (var item in data)
                {
                    series.Points.Add(new SeriesPoint(item.Tarih.Ay + "/" + item.Tarih.Yil, item.ToplamFiyat));
                }
            }
        }
        void listele()
        {

            var degerler = (from x in db.tblsatis
                            select new
                            {
                                İD = x.id,
                                ÜrünAdı = x.urunAdı,
                                SatışFiyat = x.birimfiyat,
                                ToplamFiyat = x.toplamfiyat,
                                Tarih = x.tarih,
                            }).ToList();
            gridControl1.DataSource = degerler.ToList();
            gridView1.Columns["İD"].Width = 15;
        }
    }
}
