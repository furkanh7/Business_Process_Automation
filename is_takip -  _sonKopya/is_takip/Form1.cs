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

namespace is_takip
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        formlar.frmdepartmanlar frm;
        private void btndepartmanlist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null||frm.IsDisposed)
            {
                frm = new formlar.frmdepartmanlar();
                frm.MdiParent = this;
                frm.Show();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        formlar.frmpersoneller frm2;
        private void btnpersonellistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 ==null||frm2.IsDisposed)
            {
                frm2 = new formlar.frmpersoneller();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        formlar.frmgorevlistesi frm4;
        private void btngorevlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new formlar.frmgorevlistesi();
                frm4.MdiParent = this;
                frm4.Show();
            }
            
        }

        private void btngörevtanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.frmgorev fr = new formlar.frmgorev();
            fr.Show();
        }
        formlar.frmgorevdetaylar fr;
        private void btngorevdetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr ==null||fr.IsDisposed)
            {
                fr = new formlar.frmgorevdetaylar();
                fr.MdiParent = this;
                fr.Show();
            }
           
        }
        formlar.frmanaform frmanaform;
        private void btnanaform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmanaform==null||frmanaform.IsDisposed)
            {
                frmanaform = new formlar.frmanaform();
                frmanaform.MdiParent = this;
                frmanaform.Show();
            }
        }
        formlar.frmpersonelistatistik frm3;
        private void btnistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null|| frm3.IsDisposed)
            {
                frm3 = new formlar.frmpersonelistatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }
            
        }
        formlar.frmfirmalistesi frm5;
        private void btnfirmalistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null|| frm5.IsDisposed)
            {
                frm5 = new formlar.frmfirmalistesi();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.haberler.com/");
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com");
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tr/maps/");
        }
        formlar.frmürünler frm9;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new formlar.frmürünler();
                frm9.MdiParent = this;
                frm9.Show();
            }
        }
        formlar.frmciro frm10;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new formlar.frmciro();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }
        formlar.frmkategori frm11;
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm11 == null || frm11.IsDisposed)
            {
                frm11 = new formlar.frmkategori();
                frm11.MdiParent = this;
                frm11.Show();
            }
        }
        formlar.frmsatis frm12;
        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new formlar.frmsatis();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }
        formlar.frmrapor frm13;
        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm13 == null || frm13.IsDisposed)
            {
                frm13 = new formlar.frmrapor();
                frm13.MdiParent = this;
                frm13.Show();
            }
        }
    }
}
