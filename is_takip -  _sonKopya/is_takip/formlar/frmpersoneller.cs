using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmpersoneller : Form
    {
        public frmpersoneller()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        void personeller()
        {
            var degerler = from x in db.tblpersonel 
                           select new
                           {
                                İD=x.id,
                               Adı=x.ad,
                               Soyadı=x.soyad,
                              Mail= x.mail,
                              Telefon= x.telefon,
                              //Departman=  x.tbldepartmanlar.ad,
                              Departman =x.departman2,
                              Durum= x.durum,
                              CV= x.cv 
                           };
            gridControl1.DataSource = degerler.Where(x=> x.Durum == true).ToList();
        }

        private void frmpersoneller_Load(object sender, EventArgs e)
        {
            try
            {
                personeller();
                var departmanlar = (from x in db.tbldepartmanlar
                                    select new
                                    {
                                        x.id,
                                        x.ad
                                    }).ToList();
                //lookUpEdit1.Properties.ValueMember = "id";
                //lookUpEdit1.Properties.DisplayMember = "ad";
                //lookUpEdit1.Properties.DataSource = departmanlar;
                lookUpEdit2.Properties.ValueMember = "id";
                lookUpEdit2.Properties.DisplayMember = "ad";
                lookUpEdit2.Properties.DataSource = departmanlar;
                txtid.Enabled = false;
                gridView1.Columns["Durum"].Visible = false;
                gridView1.Columns["İD"].Width = 15;
            }
            catch (Exception)
            {

                throw;
            }
           


        }

        private void btnlistelee_Click(object sender, EventArgs e)
        {
            personeller();
        }
       
        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                string inputValue = lookUpEdit2.Text;
                bool isUnique = !db.tblpersonel.Any(x => x.departman2 == inputValue && x.departman2 == "müdür");

                if (!isUnique)
                {
                    MessageBox.Show("Şirketinizde müdür 1 tane olabilir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (db.tblpersonel.Any(x => x.telefon == txttelefon.Text))
                {
                    MessageBox.Show("Bu telefon numarası ile kayıtlı bir personel zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (db.tblpersonel.Any(x => x.mail == txtmail.Text))
                {
                    MessageBox.Show("Bu telefon numarası ile kayıtlı bir personel zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tblpersonel t = new tblpersonel();
                    t.durum = true;
                    t.ad = txtad.Text;
                    t.soyad = txtsoyad.Text;
                    t.telefon = txttelefon.Text;
                    t.mail = txtmail.Text;
                    t.cv = richTextBox1.Text;
                    //t.departman = int.Parse(lookUpEdit1.EditValue.ToString());
                    t.departman2 = lookUpEdit2.Text;
                    db.tblpersonel.Add(t);
                    db.SaveChanges(); personeller();
                    XtraMessageBox.Show("Yeni personel kaydı oluşturuldu", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btngüncelle_Click(object sender, EventArgs e)
        {

            string inputValue = lookUpEdit2.Text;
            bool isUnique = !db.tblpersonel.Any(A => A.departman2 == inputValue && A.departman2 == "müdür");

            if (!isUnique)
            {
                MessageBox.Show("Şirketinizde müdür 1 tane olabilir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int x = int.Parse(txtid.Text);
            var deger = db.tblpersonel.Find(x);
            deger.ad = txtad.Text;
            deger.soyad = txtsoyad.Text;
            deger.mail = txtmail.Text;
            deger.cv = richTextBox1.Text;
            deger.telefon = txttelefon.Text;
            //deger.departman = int.Parse(lookUpEdit1.EditValue.ToString());
            deger.departman2 = lookUpEdit2.Text;
            db.SaveChanges();
            personeller();
            XtraMessageBox.Show("Personel başarılı bir şekilde güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("silmek istiyor musunuz?", "silme işlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int x = int.Parse(txtid.Text);
                    var deger = db.tblpersonel.Find(x);
                    deger.durum = false;
                    db.SaveChanges();
                    personeller();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("girilen id ye uygun personel bulunamadı");
                return;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("İD").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("Adı").ToString();
            txtsoyad.Text = gridView1.GetFocusedRowCellValue("Soyadı").ToString();
            txtmail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txttelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            //lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
            richTextBox1.Text = gridView1.GetFocusedRowCellValue("CV").ToString();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
           
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == gridView1.FocusedRowHandle)
            {
                var departmanValue = gridView1.GetRowCellValue(e.RowHandle, "Departman").ToString();

                if (departmanValue == "Müdür")
                {
                    btnsil.Enabled = false;
                }
                else
                {
                    btnsil.Enabled = true;
                }
            }
        }
    }
}
