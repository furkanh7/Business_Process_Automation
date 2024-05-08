using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmfirmalistesi : Form
    {
        public frmfirmalistesi()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        void firmalarlist()
        {
            var degerler = from x in db.tblfirmalar
                           select new
                           {
                               İD=x.id,
                               Adı=x.ad,
                               Telefon=x.telefon,
                               Mail=x.mail,
                               Yetkili=x.yetkili,
                               Adres=x.adres,
                               Durum=x.durum,
                               Sektör=x.sektor,
                               İL=x.il,
                               İLÇE=x.ilce




                           };
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
        }

        private void frmfirmalistesi_Load(object sender, EventArgs e)
        {
            firmalarlist();
            var firmalar = (from x in db.tblfirmalar
                                select new
                                {
                                    x.id,
                                    x.ad
                                }).ToList();
            txtid.Enabled = false;
            var iller = db.tbliller.ToList();
            lookUpEdit1.Properties.DataSource = iller;
            lookUpEdit1.Properties.DisplayMember = "sehiradi";
            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.EditValueChanged += lookUpEdit1_EditValueChanged;
            //lookUpEdit2.Properties.Columns["id"].Visible = false;
            //lookUpEdit2.Properties.Columns["sehirid"].Visible = false;
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int sehirId = Convert.ToInt32(lookUpEdit1.EditValue); // LookupEdit1'de seçilen şehrin ID değeri
            var ilceler = db.tblilceler.Where(ilce => ilce.Plaka == sehirId).ToList(); // Seçilen şehre ait ilçeleri çekiyoruz
            lookUpEdit2.Properties.DataSource = ilceler;
            lookUpEdit2.Properties.DisplayMember = "ilceadi";
            lookUpEdit2.Properties.ValueMember = "id";
           
        }

        private void btnlistelee_Click(object sender, EventArgs e)
        {
            firmalarlist();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                tblfirmalar t = new tblfirmalar();
                t.durum = true;
                t.ad = txtad.Text;
                t.yetkili = txtyetkili.Text;
                t.telefon = txttelefon.Text;
                t.mail = txtmail.Text;
                t.sektor = txtsektör.Text;
                t.adres = richTextBox1.Text;
                t.il = lookUpEdit1.Text;
                t.ilce = lookUpEdit2.Text;

                db.tblfirmalar.Add(t);
                db.SaveChanges(); firmalarlist();
                XtraMessageBox.Show("Yeni Firma Kaydı Oluşturuldu", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    var deger = db.tblfirmalar.Find(x);
                    deger.durum = false;
                    db.SaveChanges();
                    firmalarlist();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("girilen id ye uygun firma bulunamadı");
                return;
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtid.Text);
            var deger = db.tblfirmalar.Find(x);
            deger.ad = txtad.Text;
            deger.telefon = txttelefon.Text;
            deger.mail = txtmail.Text;
            deger.yetkili = txtyetkili.Text;
            deger.sektor = txtsektör.Text;
            deger.adres = richTextBox1.Text;
            deger.il = lookUpEdit1.Text;
            deger.ilce = lookUpEdit2.Text;
            db.SaveChanges();
            firmalarlist();
            XtraMessageBox.Show("Firma başarılı bir şekilde güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("İD").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("Adı").ToString();
            txtyetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
            txtmail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txttelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtsektör.Text = gridView1.GetFocusedRowCellValue("Sektör").ToString();
            richTextBox1.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("İL").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("İLÇE").ToString();

        }

        
    }
}
