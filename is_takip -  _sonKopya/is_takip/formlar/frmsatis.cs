using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Customization;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmsatis : Form
    {
        public frmsatis()
        {
            InitializeComponent();
        }
        private void KategoriButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonName = button.Text;
            // Burada butona tıklandığında yapılmasını istediğiniz işlemleri gerçekleştirebilirsiniz
            frmdetay frmDetay = new frmdetay(buttonName,this);
            frmDetay.Show();
          
        }
      
        private void frmsatis_Load(object sender, EventArgs e)
        {
            

            using (var context = new dbistakipEntities())
            {

                List<tblkategori> kategoriListesi = context.tblkategori.ToList();

                // Mevcut satır ve sütun sayısını saklayın
                int rowCount = tableLayoutPanel4.RowCount;
                int columnCount = tableLayoutPanel4.ColumnCount;

                // Mevcut butonları ve satır/sütun stilini temizleyin
                tableLayoutPanel4.Controls.Clear();
                tableLayoutPanel4.RowStyles.Clear();
                tableLayoutPanel4.RowCount = 0;
                tableLayoutPanel4.ColumnCount = 0;

                // Yeterli satır sayısını hesaplayın
                int newRowCount = (int)Math.Ceiling((double)kategoriListesi.Count / 5);
                tableLayoutPanel4.RowCount = newRowCount;

                // Satır ve sütun oranlarını ayarlayın
                float rowHeight = 100f / tableLayoutPanel4.RowCount;
                float columnWidth = 100f / 5;

                for (int row = 0; row < tableLayoutPanel4.RowCount; row++)
                {
                    // Satır oranlarını ayarlayın
                    tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, rowHeight));

                    for (int column = 0; column < 5; column++)
                    {
                        // Sütun oranlarını ayarlayın
                        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnWidth));

                        // İlgili hücreye butonu oluşturun
                        int kategoriIndex = row * 5 + column;
                        if (kategoriIndex < kategoriListesi.Count)
                        {
                            Button kategoriButton = new Button();
                            kategoriButton.Text = kategoriListesi[kategoriIndex].kategori;
                            kategoriButton.Name = "btn" + kategoriListesi[kategoriIndex].id.ToString();
                            kategoriButton.Click += KategoriButton_Click;

                            // Butonun boyutunu ve hücreye oturma ayarlarını yapın
                            kategoriButton.AutoSize = true;
                            kategoriButton.Dock = DockStyle.Fill;
                            kategoriButton.BackColor = Color.White;

                            // Butonu ilgili hücreye ekle
                            tableLayoutPanel4.Controls.Add(kategoriButton, column, row);
                        }
                    }
                }
                tableLayoutPanel4.RowCount = rowCount;
                tableLayoutPanel4.ColumnCount = columnCount;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            // Veritabanı bağlantısını açın
            using (var context = new dbistakipEntities())
            {
                // Yetersiz ürünleri saklamak için bir liste oluşturun
                List<string> yetersizUrunler = new List<string>();

                // gridViewsatis'teki tüm satırları döngüye alın
                for (int i = 0; i < gridViewsatis.DataRowCount; i++)
                {
                    // Satırdaki verileri alın
                    int urunId = Convert.ToInt32(gridViewsatis.GetRowCellValue(i, "id"));
                    string urunAdi = gridViewsatis.GetRowCellValue(i, "adı").ToString();
                    float birimFiyat = Convert.ToSingle(gridViewsatis.GetRowCellValue(i, "satisfiyat"));
                    int urunAdet = Convert.ToInt32(gridViewsatis.GetRowCellValue(i, "urunadet"));
                    float toplamFiyat = Convert.ToSingle(gridViewsatis.GetRowCellValue(i, "ToplamFiyat"));

                    // Veritabanındaki ilgili ürünü bulun
                    tblurunler urun = context.tblurunler.FirstOrDefault(u => u.id == urunId);
                    if (urun != null)
                    {
                        // Ürün adedinin yeterli olup olmadığını kontrol edin
                        if (urun.urunadet - urunAdet < 0)
                        {
                            yetersizUrunler.Add(urunAdi);
                        }
                        else
                        {
                            // Ürünün adetini güncelleyin
                            urun.urunadet -= urunAdet;

                            // Satış işlemini veritabanına kaydedin
                            tblsatis satis = new tblsatis();
                            satis.urunAdı = urunAdi;
                            satis.birimfiyat = birimFiyat;
                            satis.toplamfiyat = toplamFiyat;
                            satis.tarih = DateTime.Now;
                            context.tblsatis.Add(satis);
                        }
                    }
                }

                // Eğer yetersiz ürün varsa hata mesajı gösterin
                if (yetersizUrunler.Count > 0)
                {
                    string hataMesaji = string.Join(" ve ", yetersizUrunler.Select(u => $"\"{u}\"")) + " ürünlerinin adedi yetersiz!";
                    MessageBox.Show(hataMesaji);
                    return;
                }

                // Değişiklikleri kaydedin
                context.SaveChanges();
            }

            // gridViewsatis'teki verileri temizleyin
            gridControlsatis.DataSource = null;
           
        }

        private void gridControlsatis_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            decimal toplamFiyat = 0;
            for (int i = 0; i < gridViewsatis.DataRowCount; i++)
            {
                decimal fiyat = Convert.ToDecimal(gridViewsatis.GetRowCellValue(i, "ToplamFiyat"));
                toplamFiyat += fiyat;
            }
            textBoxtoplam.Text = toplamFiyat.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridControlsatis.DataSource = null;
        }

       
    }
}

