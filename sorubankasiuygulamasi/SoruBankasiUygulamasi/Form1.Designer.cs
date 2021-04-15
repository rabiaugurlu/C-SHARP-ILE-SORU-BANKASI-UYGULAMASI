namespace SoruBankasiUygulamasi
{
    partial class Form1
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
            this.txtSoruNumarasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSoruUret = new System.Windows.Forms.Button();
            this.pdfAktar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.tcSorular = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nboxOrder = new System.Windows.Forms.NumericUpDown();
            this.cbMultiD = new System.Windows.Forms.RadioButton();
            this.cbMultiC = new System.Windows.Forms.RadioButton();
            this.cbMultiB = new System.Windows.Forms.RadioButton();
            this.cbMultiA = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMultiA = new System.Windows.Forms.TextBox();
            this.txtMultiC = new System.Windows.Forms.TextBox();
            this.txtMultiB = new System.Windows.Forms.TextBox();
            this.txtMultiD = new System.Windows.Forms.TextBox();
            this.btnMultiInsert = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdFalse = new System.Windows.Forms.RadioButton();
            this.rdTrue = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTrueFalseInsert = new System.Windows.Forms.Button();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tcSorular.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboxOrder)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSoruNumarasi
            // 
            this.txtSoruNumarasi.Enabled = false;
            this.txtSoruNumarasi.Location = new System.Drawing.Point(86, 22);
            this.txtSoruNumarasi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoruNumarasi.Name = "txtSoruNumarasi";
            this.txtSoruNumarasi.Size = new System.Drawing.Size(176, 20);
            this.txtSoruNumarasi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ders Kodu";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(11, 139);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(84, 30);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(100, 139);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 30);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(686, 198);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(194, 139);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 30);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoruNumarasi);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(288, 171);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İçerik Bölümü";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 119);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "Koşullu Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox3.Location = new System.Drawing.Point(86, 54);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 21);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Klasik",
            "Doğru-Yanlış/Boşluk Doldurma",
            "Test"});
            this.comboBox2.Location = new System.Drawing.Point(86, 87);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 21);
            this.comboBox2.TabIndex = 28;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(192, 119);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 39);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tür";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(4, 119);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(89, 40);
            this.btnListele.TabIndex = 20;
            this.btnListele.Text = "Tümünü Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(5, 400);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(702, 220);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veri Tabanı";
            // 
            // btnSoruUret
            // 
            this.btnSoruUret.Location = new System.Drawing.Point(4, 103);
            this.btnSoruUret.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoruUret.Name = "btnSoruUret";
            this.btnSoruUret.Size = new System.Drawing.Size(92, 41);
            this.btnSoruUret.TabIndex = 17;
            this.btnSoruUret.Text = "Random Soru Üret";
            this.btnSoruUret.UseVisualStyleBackColor = true;
            this.btnSoruUret.Click += new System.EventHandler(this.btnSoruUret_Click);
            // 
            // pdfAktar
            // 
            this.pdfAktar.Location = new System.Drawing.Point(100, 103);
            this.pdfAktar.Margin = new System.Windows.Forms.Padding(2);
            this.pdfAktar.Name = "pdfAktar";
            this.pdfAktar.Size = new System.Drawing.Size(92, 41);
            this.pdfAktar.TabIndex = 18;
            this.pdfAktar.Text = "PDF\'e aktar";
            this.pdfAktar.UseVisualStyleBackColor = true;
            this.pdfAktar.Click += new System.EventHandler(this.pdfAktar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 81);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Klasik";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(60, 81);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(128, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "D-Y/Boşluk Doldurma";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(188, 81);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Test";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliğine Giriş",
            "Bilgisayar Ağları ve Güvenliği",
            "Nesneye Dayalı Programlamaya Giriş"});
            this.comboBox1.Location = new System.Drawing.Point(76, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ders Seçiniz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.pdfAktar);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.btnSoruUret);
            this.groupBox3.Location = new System.Drawing.Point(5, 231);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(295, 163);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Soru Üret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Soru Sayısı";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 54);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(209, 20);
            this.numericUpDown1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Mail Gönder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(232, 81);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 17);
            this.radioButton4.TabIndex = 27;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Karışık";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // tcSorular
            // 
            this.tcSorular.Controls.Add(this.tabPage1);
            this.tcSorular.Controls.Add(this.tabPage2);
            this.tcSorular.Controls.Add(this.tabPage3);
            this.tcSorular.Location = new System.Drawing.Point(302, 124);
            this.tcSorular.Name = "tcSorular";
            this.tcSorular.SelectedIndex = 0;
            this.tcSorular.Size = new System.Drawing.Size(405, 270);
            this.tcSorular.TabIndex = 78;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klasik";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtCevap);
            this.panel3.Controls.Add(this.btnEkle);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.btnGuncelle);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 180);
            this.panel3.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Cevap";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(11, 22);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(351, 103);
            this.txtCevap.TabIndex = 71;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nboxOrder);
            this.panel4.Controls.Add(this.cbMultiD);
            this.panel4.Controls.Add(this.cbMultiC);
            this.panel4.Controls.Add(this.cbMultiB);
            this.panel4.Controls.Add(this.cbMultiA);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.txtMultiA);
            this.panel4.Controls.Add(this.txtMultiC);
            this.panel4.Controls.Add(this.txtMultiB);
            this.panel4.Controls.Add(this.txtMultiD);
            this.panel4.Controls.Add(this.btnMultiInsert);
            this.panel4.Location = new System.Drawing.Point(3, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 216);
            this.panel4.TabIndex = 76;
            // 
            // nboxOrder
            // 
            this.nboxOrder.Location = new System.Drawing.Point(122, 187);
            this.nboxOrder.Name = "nboxOrder";
            this.nboxOrder.Size = new System.Drawing.Size(60, 20);
            this.nboxOrder.TabIndex = 81;
            this.nboxOrder.Visible = false;
            // 
            // cbMultiD
            // 
            this.cbMultiD.AutoSize = true;
            this.cbMultiD.Location = new System.Drawing.Point(329, 159);
            this.cbMultiD.Name = "cbMultiD";
            this.cbMultiD.Size = new System.Drawing.Size(33, 17);
            this.cbMultiD.TabIndex = 80;
            this.cbMultiD.Text = "D";
            this.cbMultiD.UseVisualStyleBackColor = true;
            // 
            // cbMultiC
            // 
            this.cbMultiC.AutoSize = true;
            this.cbMultiC.Location = new System.Drawing.Point(329, 117);
            this.cbMultiC.Name = "cbMultiC";
            this.cbMultiC.Size = new System.Drawing.Size(32, 17);
            this.cbMultiC.TabIndex = 79;
            this.cbMultiC.Text = "C";
            this.cbMultiC.UseVisualStyleBackColor = true;
            // 
            // cbMultiB
            // 
            this.cbMultiB.AutoSize = true;
            this.cbMultiB.Location = new System.Drawing.Point(329, 79);
            this.cbMultiB.Name = "cbMultiB";
            this.cbMultiB.Size = new System.Drawing.Size(32, 17);
            this.cbMultiB.TabIndex = 78;
            this.cbMultiB.Text = "B";
            this.cbMultiB.UseVisualStyleBackColor = true;
            // 
            // cbMultiA
            // 
            this.cbMultiA.AutoSize = true;
            this.cbMultiA.Location = new System.Drawing.Point(329, 37);
            this.cbMultiA.Name = "cbMultiA";
            this.cbMultiA.Size = new System.Drawing.Size(32, 17);
            this.cbMultiA.TabIndex = 77;
            this.cbMultiA.Text = "A";
            this.cbMultiA.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Answer";
            // 
            // txtMultiA
            // 
            this.txtMultiA.Location = new System.Drawing.Point(29, 35);
            this.txtMultiA.Name = "txtMultiA";
            this.txtMultiA.Size = new System.Drawing.Size(286, 20);
            this.txtMultiA.TabIndex = 1;
            this.txtMultiA.Text = "a)";
            // 
            // txtMultiC
            // 
            this.txtMultiC.Location = new System.Drawing.Point(29, 116);
            this.txtMultiC.Name = "txtMultiC";
            this.txtMultiC.Size = new System.Drawing.Size(287, 20);
            this.txtMultiC.TabIndex = 3;
            this.txtMultiC.Text = "c)";
            // 
            // txtMultiB
            // 
            this.txtMultiB.Location = new System.Drawing.Point(29, 77);
            this.txtMultiB.Name = "txtMultiB";
            this.txtMultiB.Size = new System.Drawing.Size(286, 20);
            this.txtMultiB.TabIndex = 2;
            this.txtMultiB.Tag = "";
            this.txtMultiB.Text = "b)";
            // 
            // txtMultiD
            // 
            this.txtMultiD.Location = new System.Drawing.Point(29, 158);
            this.txtMultiD.Name = "txtMultiD";
            this.txtMultiD.Size = new System.Drawing.Size(287, 20);
            this.txtMultiD.TabIndex = 4;
            this.txtMultiD.Text = "d)";
            // 
            // btnMultiInsert
            // 
            this.btnMultiInsert.Location = new System.Drawing.Point(28, 182);
            this.btnMultiInsert.Name = "btnMultiInsert";
            this.btnMultiInsert.Size = new System.Drawing.Size(71, 23);
            this.btnMultiInsert.TabIndex = 76;
            this.btnMultiInsert.Tag = "2";
            this.btnMultiInsert.Text = "Insert";
            this.btnMultiInsert.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(397, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "D/Y";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdFalse);
            this.panel2.Controls.Add(this.rdTrue);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnTrueFalseInsert);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 88);
            this.panel2.TabIndex = 74;
            // 
            // rdFalse
            // 
            this.rdFalse.AutoSize = true;
            this.rdFalse.Location = new System.Drawing.Point(95, 31);
            this.rdFalse.Name = "rdFalse";
            this.rdFalse.Size = new System.Drawing.Size(58, 17);
            this.rdFalse.TabIndex = 82;
            this.rdFalse.Text = "FALSE";
            this.rdFalse.UseVisualStyleBackColor = true;
            // 
            // rdTrue
            // 
            this.rdTrue.AutoSize = true;
            this.rdTrue.Location = new System.Drawing.Point(30, 31);
            this.rdTrue.Name = "rdTrue";
            this.rdTrue.Size = new System.Drawing.Size(55, 17);
            this.rdTrue.TabIndex = 81;
            this.rdTrue.Text = "TRUE";
            this.rdTrue.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Answer";
            // 
            // btnTrueFalseInsert
            // 
            this.btnTrueFalseInsert.Location = new System.Drawing.Point(30, 54);
            this.btnTrueFalseInsert.Name = "btnTrueFalseInsert";
            this.btnTrueFalseInsert.Size = new System.Drawing.Size(75, 23);
            this.btnTrueFalseInsert.TabIndex = 75;
            this.btnTrueFalseInsert.Tag = "3";
            this.btnTrueFalseInsert.Text = "Insert";
            this.btnTrueFalseInsert.UseVisualStyleBackColor = true;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.txtSoru);
            this.pnlQuestion.Controls.Add(this.label13);
            this.pnlQuestion.Location = new System.Drawing.Point(302, 13);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(405, 103);
            this.pnlQuestion.TabIndex = 80;
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(20, 27);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(351, 69);
            this.txtSoru.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Soru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 609);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tcSorular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Soru Bankası Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tcSorular.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboxOrder)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoruNumarasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSoruUret;
        private System.Windows.Forms.Button pdfAktar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tcSorular;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nboxOrder;
        private System.Windows.Forms.RadioButton cbMultiD;
        private System.Windows.Forms.RadioButton cbMultiC;
        private System.Windows.Forms.RadioButton cbMultiB;
        private System.Windows.Forms.RadioButton cbMultiA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMultiA;
        private System.Windows.Forms.TextBox txtMultiC;
        private System.Windows.Forms.TextBox txtMultiB;
        private System.Windows.Forms.TextBox txtMultiD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdFalse;
        private System.Windows.Forms.RadioButton rdTrue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMultiInsert;
        private System.Windows.Forms.Button btnTrueFalseInsert;
    }
}

