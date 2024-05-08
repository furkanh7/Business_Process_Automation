using DevExpress.XtraEditors;
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
    public partial class frmgorev : Form
    {
        public frmgorev()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        private void frmgörev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.tblpersonel
                                select new
                                {
                                    x.id,
                                   adsoyad =  x.ad + " " +x.soyad
                                   
                                }).ToList();
            lookUpEditveren.Properties.ValueMember = "id";
            lookUpEditveren.Properties.DisplayMember = "adsoyad";
            lookUpEditgörevalan.Properties.ValueMember = "id";
            lookUpEditgörevalan.Properties.DisplayMember = "adsoyad";
           lookUpEditveren.Properties.DataSource = degerler;
            lookUpEditgörevalan.Properties.DataSource = degerler;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            tblgorevler t = new tblgorevler();
            t.aciklama = txtaciklama.Text;
            t.durum = true;
            t.tarih = DateTime.Parse(txttarih.Text);
            t.gorevalan = int.Parse(lookUpEditgörevalan.EditValue.ToString());
            t.gorevveren = int.Parse(lookUpEditveren.EditValue.ToString());
            db.tblgorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başaarılı Bir Şekilde Tanımlandı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("İptal Etmek İstediğinize Emin Misiniz", "iptal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();

                }

            }
            catch (Exception)
            {
                return;
                throw;
            }
            
        }
    }
}
