using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Customization;
using is_takip.entity;

namespace is_takip.formlar
{
    public partial class frmdetay : Form
    {

        private string buttonName;
        private frmsatis parentForm;

        public frmdetay(string buttonName, frmsatis parentForm)
        {
            InitializeComponent();
            this.buttonName = buttonName;
            this.parentForm = parentForm;
        }
       
       
        private void frmdetay_Load_1(object sender, EventArgs e)
        {
            parentForm.gridViewsatis.CustomUnboundColumnData += gridViewSatis_CustomUnboundColumnData;

            using (var context = new dbistakipEntities())
            {
                List<tblurunler> urunListesi = context.tblurunler.Where(u => u.kategori == buttonName).ToList();

                gridControl1.DataSource = urunListesi;

                GridView gridView1 = gridControl1.MainView as GridView;


                gridView1.Columns["durum"].Visible = false;
                gridView1.Columns["aciklama"].Visible = false;
                gridView1.Columns["firma"].Visible = false;
                gridView1.Columns["birimfiyat"].Visible = false;
                gridView1.Columns["urunkodu"].Visible = false;
                gridView1.Columns["id"].Visible = false;
                gridView1.Columns["kategori"].Visible = false;
                gridView1.Columns["adı"].Caption = "Adı";
                gridView1.Columns["satisfiyat"].Caption = "Satış Fiyatı";
                gridView1.Columns["urunadet"].Caption = "Adet";
                gridView1.FocusedColumn = gridView1.Columns["urunadet"];
                gridView1.Columns["adı"].Width = 200;
                gridView1.Columns["satisfiyat"].Width = 100;
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    gridView1.SetRowCellValue(i, "urunadet", 1);
                }
                gridView1.BestFitColumns();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;
            string numericValue = numericButton.Text;

            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (string.IsNullOrEmpty(urunAdet))
            {
                urunAdet = numericValue;
            }
            else
            {
                urunAdet += numericValue;
            }

            gridView1.SetFocusedRowCellValue("urunadet", urunAdet);
        }

        private void buttonsil_Click_1(object sender, EventArgs e)
        {
            GridView gridView1 = gridControl1.MainView as GridView;
            string urunAdet = gridView1.GetFocusedRowCellValue("urunadet")?.ToString();

            if (!string.IsNullOrEmpty(urunAdet))
            {
                gridView1.SetFocusedRowCellValue("urunadet", "");
            }
        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {



            GridView gridView1 = gridControl1.MainView as GridView;
            int[] selectedRows = gridView1.GetSelectedRows(); // Seçili satırların dizisini al

            if (selectedRows.Length > 0)
            {
                List<object> selectedData = new List<object>();

                foreach (int rowHandle in selectedRows)
                {
                    object data = gridView1.GetRow(rowHandle); // Seçili satırın verisini al
                    selectedData.Add(data);
                }

                // Eğer gridControlsatis'e veri atanmamışsa, veri kaynağını set et
                if (parentForm.gridControlsatis.DataSource == null)
                {
                    parentForm.gridControlsatis.DataSource = selectedData;
                }
                else // Eğer gridControlsatis'e veri atanmışsa, mevcut veri kaynağını güncelle
                {
                    List<object> existingData = parentForm.gridControlsatis.DataSource as List<object>;
                    existingData.AddRange(selectedData);
                    parentForm.gridControlsatis.RefreshDataSource();
                }

                GridView gridViewSatis = parentForm.gridViewsatis;

                // Yeni sütunu sadece ilk kayıtta oluştur
                if (gridViewSatis.Columns["ToplamFiyat"] == null)
                {
                    GridColumn toplamFiyatColumn = new GridColumn();
                    toplamFiyatColumn.FieldName = "ToplamFiyat";
                    toplamFiyatColumn.Caption = "Toplam Fiyat";
                    toplamFiyatColumn.Visible = true;
                    toplamFiyatColumn.OptionsColumn.AllowEdit = false;
                    toplamFiyatColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                    toplamFiyatColumn.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridViewSatis.Columns.Add(toplamFiyatColumn);

                }
                
                parentForm.gridViewsatis.Columns["durum"].Visible = false;
                parentForm.gridViewsatis.Columns["aciklama"].Visible = false;
                parentForm.gridViewsatis.Columns["firma"].Visible = false;
                parentForm.gridViewsatis.Columns["birimfiyat"].Visible = false;
                parentForm.gridViewsatis.Columns["urunkodu"].Visible = false;
                parentForm.gridViewsatis.Columns["id"].Visible = false;
                parentForm.gridViewsatis.Columns["kategori"].Visible = false;
                parentForm.gridViewsatis.Columns["adı"].Caption = "Adı";
                parentForm.gridViewsatis.Columns["satisfiyat"].Caption = "Birim Fiyatı";
                parentForm.gridViewsatis.Columns["urunadet"].Caption = "Adet";   
            }         
            this.Close();
        }
        private void gridViewSatis_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "ToplamFiyat" && e.IsGetData)
            {
                GridView view = sender as GridView;
                decimal urunadet = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "urunadet"));
                decimal birimfiyat = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "satisfiyat"));
                e.Value = urunadet * birimfiyat;
            }
        }
    }


}




