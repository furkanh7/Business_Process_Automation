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
    public partial class frmgorevlistesi : Form
    {
        public frmgorevlistesi()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();
        private void frmgörevlistesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.tblgorevler
                                      
                                       select new
                                       {      
                                           GörevVeren= x.tblpersonel.ad + " "+ x.tblpersonel.soyad,
                                           GörevAlan = x.tblpersonel1.ad +" "+ x.tblpersonel1.soyad,
                                           GörevAçıklaması = x.aciklama

                                       }).ToList();
            lblaktifgörev.Text = db.tblgorevler.Where(x=> x.durum == true).Count().ToString();  
            lblpasifgörev.Text = db.tblgorevler.Where(x=>x.durum == false).Count().ToString();
            lbltoplamdepartman.Text = db.tbldepartmanlar.Count().ToString();
            chartControl1.Series["durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblaktifgörev.Text));
            chartControl1.Series["durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblpasifgörev.Text));

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
