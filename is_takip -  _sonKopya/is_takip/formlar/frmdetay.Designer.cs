namespace is_takip.formlar
{
    partial class frmdetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdetay));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsil = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(708, 434);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.66025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.71114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.766162F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 727);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButton2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnkaydet, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 658);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(708, 66);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(357, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(348, 60);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "İptal Et";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnkaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnkaydet.ImageOptions.SvgImage")));
            this.btnkaydet.Location = new System.Drawing.Point(3, 3);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(348, 60);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.buttonsil, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button34, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button35, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button36, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button37, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button39, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.button38, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.button40, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button41, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.button42, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.button44, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAdet, 2, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 443);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(708, 209);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.DimGray;
            this.buttonsil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsil.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsil.ForeColor = System.Drawing.Color.White;
            this.buttonsil.Location = new System.Drawing.Point(1, 157);
            this.buttonsil.Margin = new System.Windows.Forms.Padding(1);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(234, 51);
            this.buttonsil.TabIndex = 11;
            this.buttonsil.Text = "<";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click_1);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.DimGray;
            this.button34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(1, 1);
            this.button34.Margin = new System.Windows.Forms.Padding(1);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(234, 50);
            this.button34.TabIndex = 1;
            this.button34.Text = "1";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.DimGray;
            this.button35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button35.ForeColor = System.Drawing.Color.White;
            this.button35.Location = new System.Drawing.Point(237, 1);
            this.button35.Margin = new System.Windows.Forms.Padding(1);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(234, 50);
            this.button35.TabIndex = 2;
            this.button35.Text = "2";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.DimGray;
            this.button36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button36.ForeColor = System.Drawing.Color.White;
            this.button36.Location = new System.Drawing.Point(473, 1);
            this.button36.Margin = new System.Windows.Forms.Padding(1);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(234, 50);
            this.button36.TabIndex = 3;
            this.button36.Text = "3";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.DimGray;
            this.button37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button37.ForeColor = System.Drawing.Color.White;
            this.button37.Location = new System.Drawing.Point(1, 53);
            this.button37.Margin = new System.Windows.Forms.Padding(1);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(234, 50);
            this.button37.TabIndex = 4;
            this.button37.Text = "4";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.DimGray;
            this.button39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button39.ForeColor = System.Drawing.Color.White;
            this.button39.Location = new System.Drawing.Point(473, 53);
            this.button39.Margin = new System.Windows.Forms.Padding(1);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(234, 50);
            this.button39.TabIndex = 6;
            this.button39.Text = "6";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.DimGray;
            this.button38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button38.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button38.ForeColor = System.Drawing.Color.White;
            this.button38.Location = new System.Drawing.Point(237, 53);
            this.button38.Margin = new System.Windows.Forms.Padding(1);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(234, 50);
            this.button38.TabIndex = 5;
            this.button38.Text = "5";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.DimGray;
            this.button40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button40.ForeColor = System.Drawing.Color.White;
            this.button40.Location = new System.Drawing.Point(1, 105);
            this.button40.Margin = new System.Windows.Forms.Padding(1);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(234, 50);
            this.button40.TabIndex = 7;
            this.button40.Text = "7";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.DimGray;
            this.button41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button41.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button41.ForeColor = System.Drawing.Color.White;
            this.button41.Location = new System.Drawing.Point(237, 105);
            this.button41.Margin = new System.Windows.Forms.Padding(1);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(234, 50);
            this.button41.TabIndex = 8;
            this.button41.Text = "8";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.DimGray;
            this.button42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button42.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button42.ForeColor = System.Drawing.Color.White;
            this.button42.Location = new System.Drawing.Point(473, 105);
            this.button42.Margin = new System.Windows.Forms.Padding(1);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(234, 50);
            this.button42.TabIndex = 9;
            this.button42.Text = "9";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.DimGray;
            this.button44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button44.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button44.ForeColor = System.Drawing.Color.White;
            this.button44.Location = new System.Drawing.Point(237, 157);
            this.button44.Margin = new System.Windows.Forms.Padding(1);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(234, 51);
            this.button44.TabIndex = 12;
            this.button44.Text = "0";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdet.Location = new System.Drawing.Point(475, 159);
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.Size = new System.Drawing.Size(230, 45);
            this.textBoxAdet.TabIndex = 13;
            // 
            // frmdetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 727);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmdetay";
            this.Text = "frmdetay";
            this.Load += new System.EventHandler(this.frmdetay_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.TextBox textBoxAdet;
    }
}