using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmgorevdetaylar : Form
    {
        public frmgorevdetaylar()
        {
            InitializeComponent();
        }
        dbistakipEntities db = new dbistakipEntities();

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmgorevdetaylar_Load(object sender, EventArgs e)
        {
            db.tblgorevdetaylar.Load();
            bindingSource1.DataSource = db.tblgorevdetaylar.Local;
           
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();

            }
            catch (Exception)
            {
                MessageBox.Show("Doğru Personel Bulunamadı!");
                return;
                throw;
            }
           
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
