using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmpersonelistatistik : Form
    {
        public frmpersonelistatistik()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        private void frmpersonelistatistik_Load(object sender, EventArgs e)
        {
           lbltoplamdepartman.Text = db.tbldepartmanlar.Count().ToString();
            lbltoplafirma.Text= db.tblfirmalar.Count().ToString();
            lbltoplampersonel.Text = db.tblpersonel.Count().ToString();
            lblaktifis.Text = db.tblgorevler.Count(x=>x.durum==true).ToString();
            lblpasifis.Text = db.tblgorevler.Count(x=>x.durum==false).ToString();
            lblsongörev.Text = db.tblgorevler.OrderByDescending(x => x.id).Select(x => x.aciklama).FirstOrDefault();
            lblsongorevdetay.Text = db.tblgorevler.OrderByDescending(x => x.id).Select(x => x.tarih).FirstOrDefault().ToString();
            lblsehirsayısı.Text = db.tblfirmalar.Select(x=>x.il).Distinct().Count().ToString();
            lblsektor.Text = db.tblfirmalar.Select(x=> x.sektor).Distinct().Count().ToString();
            DateTime bugün = DateTime.Today;
            lblbugunacılangorevler.Text = db.tblgorevler.Count(x=> x.tarih == bugün).ToString();
            var d1 = db.tblgorevler.GroupBy(x=> x.gorevalan).OrderByDescending(z=> z.Count()).Select(y=>y.Key).FirstOrDefault();
            lblayınpersoneli.Text = db.tblpersonel.Where(x=>x.id==d1).Select(y=>y.ad + " "+y.soyad).FirstOrDefault().ToString();
            lblayındepartmanı.Text  = db.tbldepartmanlar.Where(x => x.id == db.tblpersonel.Where(t=>t.id==d1).Select(z=>z.departman).FirstOrDefault()).Select(y => y.ad).FirstOrDefault();


        }
    }
}
