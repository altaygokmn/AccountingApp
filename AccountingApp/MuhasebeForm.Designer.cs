namespace AccountingApp
{
    partial class MuhasebeForm
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
            dgwProductsPurchasing = new DataGridView();
            salesProcess = new GroupBox();
            cbxProductType2 = new ComboBox();
            cbxDistance2 = new ComboBox();
            tbxAmount2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tbxUnitPrice2 = new TextBox();
            label8 = new Label();
            btn2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            purchasProcess = new GroupBox();
            btn1 = new Button();
            tbxUnitPrice1 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            cbxDistance1 = new ComboBox();
            label3 = new Label();
            tbxAmount1 = new TextBox();
            label2 = new Label();
            cbxProductType1 = new ComboBox();
            label1 = new Label();
            dgwProductsSale = new DataGridView();
            btnShowInformations = new Button();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwProductsPurchasing).BeginInit();
            salesProcess.SuspendLayout();
            purchasProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProductsSale).BeginInit();
            SuspendLayout();
            // 
            // dgwProductsPurchasing
            // 
            dgwProductsPurchasing.AllowUserToDeleteRows = false;
            dgwProductsPurchasing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProductsPurchasing.Location = new Point(113, 83);
            dgwProductsPurchasing.Name = "dgwProductsPurchasing";
            dgwProductsPurchasing.RowHeadersWidth = 51;
            dgwProductsPurchasing.RowTemplate.Height = 29;
            dgwProductsPurchasing.Size = new Size(803, 424);
            dgwProductsPurchasing.TabIndex = 31;
            dgwProductsPurchasing.CellContentClick += dgwProductsPurchasing_CellContentClick;
            // 
            // salesProcess
            // 
            salesProcess.Controls.Add(cbxProductType2);
            salesProcess.Controls.Add(cbxDistance2);
            salesProcess.Controls.Add(tbxAmount2);
            salesProcess.Controls.Add(label9);
            salesProcess.Controls.Add(label10);
            salesProcess.Controls.Add(tbxUnitPrice2);
            salesProcess.Controls.Add(label8);
            salesProcess.Controls.Add(btn2);
            salesProcess.Controls.Add(dateTimePicker2);
            salesProcess.Controls.Add(label6);
            salesProcess.Controls.Add(label4);
            salesProcess.Location = new Point(1012, 534);
            salesProcess.Name = "salesProcess";
            salesProcess.Size = new Size(804, 347);
            salesProcess.TabIndex = 30;
            salesProcess.TabStop = false;
            salesProcess.Text = "Satış İşlemi Ekle";
            // 
            // cbxProductType2
            // 
            cbxProductType2.FormattingEnabled = true;
            cbxProductType2.Items.AddRange(new object[] { "iPhone 13 Pro Max", "iPhone 13 Pro", "iPhone 13", "iPhone 13 mini", "iPhone SE (2020)", "Samsung Galaxy S23 Ultra", "Samsung Galaxy S23+", "Samsung Galaxy S23", "Samsung Galaxy S22 Ultra", "Samsung Galaxy S22+", "Samsung Galaxy S22", "Xiaomi Mi 11 Ultra", "Xiaomi Mi 11 Pro", "Xiaomi Mi 11", "Xiaomi Mi 10T Pro", "Xiaomi Mi 10T" });
            cbxProductType2.Location = new Point(259, 44);
            cbxProductType2.Name = "cbxProductType2";
            cbxProductType2.Size = new Size(180, 28);
            cbxProductType2.TabIndex = 36;
            // 
            // cbxDistance2
            // 
            cbxDistance2.FormattingEnabled = true;
            cbxDistance2.Items.AddRange(new object[] { "Akdeniz Bölgesi", "Doğu Anadolu Bölgesi", "Ege Bölgesi", "Güney Doğu Anadolu Bölgesi", "Karadeniz Bölgesi", "Marmara Bölgesi", "İç Anadolu Bölgesi" });
            cbxDistance2.Location = new Point(259, 150);
            cbxDistance2.Name = "cbxDistance2";
            cbxDistance2.Size = new Size(180, 28);
            cbxDistance2.TabIndex = 35;
            // 
            // tbxAmount2
            // 
            tbxAmount2.Location = new Point(259, 95);
            tbxAmount2.Name = "tbxAmount2";
            tbxAmount2.Size = new Size(180, 27);
            tbxAmount2.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 95);
            label9.Name = "label9";
            label9.Size = new Size(185, 20);
            label9.TabIndex = 32;
            label9.Text = "Satılan Ürün Miktarı (Adet)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(168, 47);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 30;
            label10.Text = "Ürün Türü";
            // 
            // tbxUnitPrice2
            // 
            tbxUnitPrice2.Location = new Point(259, 202);
            tbxUnitPrice2.Name = "tbxUnitPrice2";
            tbxUnitPrice2.Size = new Size(180, 27);
            tbxUnitPrice2.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 205);
            label8.Name = "label8";
            label8.Size = new Size(183, 20);
            label8.TabIndex = 28;
            label8.Text = "Satılan Ürünün Birim Fiyatı";
            // 
            // btn2
            // 
            btn2.Location = new Point(415, 294);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 27;
            btn2.Text = "Onayla";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(259, 247);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 252);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 25;
            label6.Text = "Ürün Satış Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 153);
            label4.Name = "label4";
            label4.Size = new Size(196, 20);
            label4.TabIndex = 23;
            label4.Text = "Ürünün Gönderileceği Bölge";
            // 
            // purchasProcess
            // 
            purchasProcess.Controls.Add(btn1);
            purchasProcess.Controls.Add(tbxUnitPrice1);
            purchasProcess.Controls.Add(label7);
            purchasProcess.Controls.Add(dateTimePicker1);
            purchasProcess.Controls.Add(label5);
            purchasProcess.Controls.Add(cbxDistance1);
            purchasProcess.Controls.Add(label3);
            purchasProcess.Controls.Add(tbxAmount1);
            purchasProcess.Controls.Add(label2);
            purchasProcess.Controls.Add(cbxProductType1);
            purchasProcess.Controls.Add(label1);
            purchasProcess.Location = new Point(113, 534);
            purchasProcess.Name = "purchasProcess";
            purchasProcess.Size = new Size(803, 347);
            purchasProcess.TabIndex = 29;
            purchasProcess.TabStop = false;
            purchasProcess.Text = "Satın Alma İşlemi Ekle";
            // 
            // btn1
            // 
            btn1.Location = new Point(416, 294);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 37;
            btn1.Text = "Onayla";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // tbxUnitPrice1
            // 
            tbxUnitPrice1.Location = new Point(260, 202);
            tbxUnitPrice1.Name = "tbxUnitPrice1";
            tbxUnitPrice1.Size = new Size(180, 27);
            tbxUnitPrice1.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 209);
            label7.Name = "label7";
            label7.Size = new Size(217, 20);
            label7.TabIndex = 35;
            label7.Text = "Satın Alınan Ürünün Birim Fiyatı";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(260, 247);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 252);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 33;
            label5.Text = "Ürün Alış Tarihi";
            // 
            // cbxDistance1
            // 
            cbxDistance1.FormattingEnabled = true;
            cbxDistance1.Items.AddRange(new object[] { "Akdeniz Bölgesi", "Doğu Anadolu Bölgesi", "Ege Bölgesi", "Güney Doğu Anadolu Bölgesi", "Karadeniz Bölgesi", "Marmara Bölgesi", "İç Anadolu Bölgesi" });
            cbxDistance1.Location = new Point(260, 150);
            cbxDistance1.Name = "cbxDistance1";
            cbxDistance1.Size = new Size(180, 28);
            cbxDistance1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 153);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 31;
            label3.Text = "Ürünün Geldiği Bölge";
            // 
            // tbxAmount1
            // 
            tbxAmount1.Location = new Point(260, 98);
            tbxAmount1.Name = "tbxAmount1";
            tbxAmount1.Size = new Size(180, 27);
            tbxAmount1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 102);
            label2.Name = "label2";
            label2.Size = new Size(219, 20);
            label2.TabIndex = 29;
            label2.Text = "Satın Alınan Ürün Miktarı (Adet)";
            // 
            // cbxProductType1
            // 
            cbxProductType1.FormattingEnabled = true;
            cbxProductType1.Items.AddRange(new object[] { "iPhone 13 Pro Max", "iPhone 13 Pro", "iPhone 13", "iPhone 13 mini", "iPhone SE (2020)", "Samsung Galaxy S23 Ultra", "Samsung Galaxy S23+", "Samsung Galaxy S23", "Samsung Galaxy S22 Ultra", "Samsung Galaxy S22+", "Samsung Galaxy S22", "Xiaomi Mi 11 Ultra", "Xiaomi Mi 11 Pro", "Xiaomi Mi 11", "Xiaomi Mi 10T Pro", "Xiaomi Mi 10T" });
            cbxProductType1.Location = new Point(260, 47);
            cbxProductType1.Name = "cbxProductType1";
            cbxProductType1.Size = new Size(180, 28);
            cbxProductType1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 50);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 27;
            label1.Text = "Ürün Türü";
            // 
            // dgwProductsSale
            // 
            dgwProductsSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProductsSale.Location = new Point(1012, 83);
            dgwProductsSale.Name = "dgwProductsSale";
            dgwProductsSale.RowHeadersWidth = 51;
            dgwProductsSale.RowTemplate.Height = 29;
            dgwProductsSale.Size = new Size(804, 424);
            dgwProductsSale.TabIndex = 32;
            // 
            // btnShowInformations
            // 
            btnShowInformations.Location = new Point(1660, 909);
            btnShowInformations.Name = "btnShowInformations";
            btnShowInformations.Size = new Size(156, 41);
            btnShowInformations.TabIndex = 33;
            btnShowInformations.Text = "Bilgileri Görüntüle";
            btnShowInformations.UseVisualStyleBackColor = true;
            btnShowInformations.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(148, 40);
            label11.Name = "label11";
            label11.Size = new Size(141, 20);
            label11.TabIndex = 34;
            label11.Text = "Satın Alma İşlemleri";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.Location = new Point(1082, 40);
            label12.Name = "label12";
            label12.Size = new Size(100, 20);
            label12.TabIndex = 35;
            label12.Text = "Satış İşlemleri";
            // 
            // MuhasebeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1920, 962);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnShowInformations);
            Controls.Add(dgwProductsSale);
            Controls.Add(dgwProductsPurchasing);
            Controls.Add(salesProcess);
            Controls.Add(purchasProcess);
            Name = "MuhasebeForm";
            Text = "MuhasebeForm";
            Load += MuhasebeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProductsPurchasing).EndInit();
            salesProcess.ResumeLayout(false);
            salesProcess.PerformLayout();
            purchasProcess.ResumeLayout(false);
            purchasProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProductsSale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwProductsPurchasing;
        private GroupBox salesProcess;
        private ComboBox cbxDistance2;
        private TextBox tbxAmount2;
        private Label label9;
        private Label label10;
        private TextBox tbxUnitPrice2;
        private Label label8;
        private Button btn2;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private Label label4;
        private GroupBox purchasProcess;
        private Button btn1;
        private TextBox tbxUnitPrice1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox cbxDistance1;
        private Label label3;
        private TextBox tbxAmount1;
        private Label label2;
        private ComboBox cbxProductType1;
        private Label label1;
        private DataGridView dgwProductsSale;
        private Button btnShowInformations;
        private ComboBox cbxProductType2;
        private Label label11;
        private Label label12;
    }
}