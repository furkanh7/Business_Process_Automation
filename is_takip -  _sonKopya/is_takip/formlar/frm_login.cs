using DevExpress.XtraBars.Ribbon;
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
    public partial class frm_login : Form
    {
        dbistakipEntities db = new dbistakipEntities();
        public frm_login()
        {
            InitializeComponent();
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Silver;

            panel3.BackColor = SystemColors.Control;
        }

        private void textEdit3_Click(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.Control;

            panel3.BackColor = Color.Silver;

        }
        


        

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_kullanici.Focus();
        }
        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            if (txt_sifre.Text.Length < 8)
            {
                errorProvider1.SetError(txt_sifre, "Şifreniz 8 Karakter Olmalıdır.");
                btn_admin.Enabled = false;
                btn_personel.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txt_sifre, null);
                btn_admin.Enabled = true;
                btn_personel.Enabled = true;
            }
        }
        private void txt_kullanici_Leave(object sender, EventArgs e)
        {
            if (txt_kullanici.Text.Length == 0)
            {
                errorProvider1.SetError(txt_kullanici, "Kullanıcı adını giriniz");
                btn_admin.Enabled = false;
                btn_personel.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txt_kullanici, null);
                btn_admin.Enabled = true;
                btn_personel.Enabled = true;
            }
        }

        private void btn_admin_Click_1(object sender, EventArgs e)
        {
            var adminvalue = db.tbladmin.Where(x => x.kullanici == txt_kullanici.Text &&
x.sifre == txt_sifre.Text).FirstOrDefault();
            if (adminvalue != null)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void btn_personel_Click_1(object sender, EventArgs e)
        {

            var personel = db.tblpersonel.Where(x => x.mail == txt_kullanici.Text && x.sifre == txt_sifre.Text).FirstOrDefault();
            if (personel != null)
            {
                formlar.frmsatis fr = new formlar.frmsatis();

                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
