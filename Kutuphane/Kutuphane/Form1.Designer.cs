namespace Kutuphane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uye_adsoyad = new System.Windows.Forms.TextBox();
            this.uye_tc = new System.Windows.Forms.TextBox();
            this.uye_yas = new System.Windows.Forms.TextBox();
            this.uye_cinsiyet = new System.Windows.Forms.ComboBox();
            this.uye_telefon = new System.Windows.Forms.TextBox();
            this.uye_email = new System.Windows.Forms.TextBox();
            this.uye_adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.kitap_stok = new System.Windows.Forms.TextBox();
            this.kitap_sayfa = new System.Windows.Forms.TextBox();
            this.kitap_yazari = new System.Windows.Forms.TextBox();
            this.kitap_adi = new System.Windows.Forms.TextBox();
            this.kitap_barkod = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.kitap_raf = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.kitap_aciklama = new System.Windows.Forms.RichTextBox();
            this.uye_submit = new System.Windows.Forms.Button();
            this.kitap_submit = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ara_list = new System.Windows.Forms.ComboBox();
            this.ara_submit = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.kitap_turu = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.kitap_yayinevi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uyeId = new System.Windows.Forms.TextBox();
            this.kitapId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uye_adsoyad
            // 
            this.uye_adsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uye_adsoyad.Location = new System.Drawing.Point(14, 116);
            this.uye_adsoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uye_adsoyad.Name = "uye_adsoyad";
            this.uye_adsoyad.Size = new System.Drawing.Size(135, 27);
            this.uye_adsoyad.TabIndex = 0;
            // 
            // uye_tc
            // 
            this.uye_tc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uye_tc.Location = new System.Drawing.Point(157, 116);
            this.uye_tc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uye_tc.Name = "uye_tc";
            this.uye_tc.Size = new System.Drawing.Size(135, 27);
            this.uye_tc.TabIndex = 1;
            this.uye_tc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // uye_yas
            // 
            this.uye_yas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uye_yas.Location = new System.Drawing.Point(14, 183);
            this.uye_yas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uye_yas.Name = "uye_yas";
            this.uye_yas.Size = new System.Drawing.Size(135, 27);
            this.uye_yas.TabIndex = 2;
            // 
            // uye_cinsiyet
            // 
            this.uye_cinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uye_cinsiyet.FormattingEnabled = true;
            this.uye_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "LGBTI+",
            "Diğer"});
            this.uye_cinsiyet.Location = new System.Drawing.Point(157, 183);
            this.uye_cinsiyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uye_cinsiyet.Name = "uye_cinsiyet";
            this.uye_cinsiyet.Size = new System.Drawing.Size(135, 28);
            this.uye_cinsiyet.TabIndex = 3;
            // 
            // uye_telefon
            // 
            this.uye_telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uye_telefon.Location = new System.Drawing.Point(14, 249);
            this.uye_telefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uye_telefon.Name = "uye_telefon";
            this.uye_telefon.Size = new System.Drawing.Size(135, 27);
            this.uye_telefon.TabIndex = 4;
            // 
            // uye_email
            // 
            this.uye_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uye_email.Location = new System.Drawing.Point(157, 249);
            this.uye_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uye_email.Name = "uye_email";
            this.uye_email.Size = new System.Drawing.Size(135, 27);
            this.uye_email.TabIndex = 5;
            // 
            // uye_adres
            // 
            this.uye_adres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uye_adres.Location = new System.Drawing.Point(14, 316);
            this.uye_adres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uye_adres.Name = "uye_adres";
            this.uye_adres.Size = new System.Drawing.Size(278, 27);
            this.uye_adres.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Üye Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(157, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "TC Kimlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(157, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(157, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(511, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 28);
            this.label9.TabIndex = 34;
            this.label9.Text = "Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(368, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 28);
            this.label10.TabIndex = 33;
            this.label10.Text = "Stok Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(368, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 28);
            this.label11.TabIndex = 32;
            this.label11.Text = "Sayfa Sayısı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(511, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 28);
            this.label12.TabIndex = 31;
            this.label12.Text = "Yayın Evi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(511, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 28);
            this.label13.TabIndex = 30;
            this.label13.Text = "Kitap Adı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(360, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 36);
            this.label14.TabIndex = 29;
            this.label14.Text = "Kitap Ekle";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(368, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 28);
            this.label15.TabIndex = 28;
            this.label15.Text = "Barkod No";
            // 
            // kitap_stok
            // 
            this.kitap_stok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_stok.Location = new System.Drawing.Point(368, 316);
            this.kitap_stok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_stok.Name = "kitap_stok";
            this.kitap_stok.Size = new System.Drawing.Size(135, 27);
            this.kitap_stok.TabIndex = 27;
            // 
            // kitap_sayfa
            // 
            this.kitap_sayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_sayfa.Location = new System.Drawing.Point(368, 249);
            this.kitap_sayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_sayfa.Name = "kitap_sayfa";
            this.kitap_sayfa.Size = new System.Drawing.Size(135, 27);
            this.kitap_sayfa.TabIndex = 25;
            // 
            // kitap_yazari
            // 
            this.kitap_yazari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_yazari.Location = new System.Drawing.Point(368, 183);
            this.kitap_yazari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_yazari.Name = "kitap_yazari";
            this.kitap_yazari.Size = new System.Drawing.Size(135, 27);
            this.kitap_yazari.TabIndex = 23;
            // 
            // kitap_adi
            // 
            this.kitap_adi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_adi.Location = new System.Drawing.Point(511, 116);
            this.kitap_adi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_adi.Name = "kitap_adi";
            this.kitap_adi.Size = new System.Drawing.Size(135, 27);
            this.kitap_adi.TabIndex = 22;
            // 
            // kitap_barkod
            // 
            this.kitap_barkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_barkod.Location = new System.Drawing.Point(368, 116);
            this.kitap_barkod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_barkod.Name = "kitap_barkod";
            this.kitap_barkod.Size = new System.Drawing.Size(135, 27);
            this.kitap_barkod.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(368, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 28);
            this.label16.TabIndex = 35;
            this.label16.Text = "Yazarı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(511, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 28);
            this.label17.TabIndex = 37;
            this.label17.Text = "Raf Numarası";
            // 
            // kitap_raf
            // 
            this.kitap_raf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_raf.Location = new System.Drawing.Point(511, 316);
            this.kitap_raf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_raf.Name = "kitap_raf";
            this.kitap_raf.Size = new System.Drawing.Size(135, 27);
            this.kitap_raf.TabIndex = 36;
            this.kitap_raf.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(367, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 28);
            this.label18.TabIndex = 39;
            this.label18.Text = "Açıklama";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // kitap_aciklama
            // 
            this.kitap_aciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_aciklama.Location = new System.Drawing.Point(368, 383);
            this.kitap_aciklama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_aciklama.Name = "kitap_aciklama";
            this.kitap_aciklama.Size = new System.Drawing.Size(278, 127);
            this.kitap_aciklama.TabIndex = 40;
            this.kitap_aciklama.Text = "";
            // 
            // uye_submit
            // 
            this.uye_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uye_submit.Location = new System.Drawing.Point(207, 355);
            this.uye_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uye_submit.Name = "uye_submit";
            this.uye_submit.Size = new System.Drawing.Size(86, 31);
            this.uye_submit.TabIndex = 41;
            this.uye_submit.Text = "Ekle";
            this.uye_submit.UseVisualStyleBackColor = false;
            this.uye_submit.Click += new System.EventHandler(this.uye_submit_Click);
            // 
            // kitap_submit
            // 
            this.kitap_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_submit.Location = new System.Drawing.Point(561, 519);
            this.kitap_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_submit.Name = "kitap_submit";
            this.kitap_submit.Size = new System.Drawing.Size(86, 31);
            this.kitap_submit.TabIndex = 42;
            this.kitap_submit.Text = "Ekle";
            this.kitap_submit.UseVisualStyleBackColor = false;
            this.kitap_submit.Click += new System.EventHandler(this.kitap_submit_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 20;
            this.Result.Location = new System.Drawing.Point(701, 128);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(346, 384);
            this.Result.TabIndex = 43;
            this.Result.SelectedIndexChanged += new System.EventHandler(this.Result_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(701, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 36);
            this.label19.TabIndex = 44;
            this.label19.Text = "Arama";
            // 
            // ara_list
            // 
            this.ara_list.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ara_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ara_list.FormattingEnabled = true;
            this.ara_list.Items.AddRange(new object[] {
            "Kitap",
            "Üye"});
            this.ara_list.Location = new System.Drawing.Point(701, 80);
            this.ara_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara_list.Name = "ara_list";
            this.ara_list.Size = new System.Drawing.Size(87, 28);
            this.ara_list.TabIndex = 45;
            // 
            // ara_submit
            // 
            this.ara_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ara_submit.Location = new System.Drawing.Point(961, 85);
            this.ara_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara_submit.Name = "ara_submit";
            this.ara_submit.Size = new System.Drawing.Size(86, 31);
            this.ara_submit.TabIndex = 46;
            this.ara_submit.Text = "Ara";
            this.ara_submit.UseVisualStyleBackColor = false;
            this.ara_submit.Click += new System.EventHandler(this.ara_submit_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 533);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 20);
            this.label20.TabIndex = 47;
            this.label20.Text = "Esmanur Erdiş - 2022 ";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // kitap_turu
            // 
            this.kitap_turu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_turu.FormattingEnabled = true;
            this.kitap_turu.Items.AddRange(new object[] {
            "Felsefe",
            "Şiir",
            "Bilim&Teknik",
            "Polisiye",
            "Tiyatro",
            "Lirik",
            "Ansiklopedi",
            "Diğer"});
            this.kitap_turu.Location = new System.Drawing.Point(511, 249);
            this.kitap_turu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_turu.Name = "kitap_turu";
            this.kitap_turu.Size = new System.Drawing.Size(138, 28);
            this.kitap_turu.TabIndex = 48;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(795, 81);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(158, 27);
            this.searchBox.TabIndex = 49;
            // 
            // kitap_yayinevi
            // 
            this.kitap_yayinevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitap_yayinevi.Location = new System.Drawing.Point(517, 183);
            this.kitap_yayinevi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap_yayinevi.Name = "kitap_yayinevi";
            this.kitap_yayinevi.Size = new System.Drawing.Size(130, 27);
            this.kitap_yayinevi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(961, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 50;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyeId
            // 
            this.uyeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uyeId.Location = new System.Drawing.Point(14, 356);
            this.uyeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uyeId.Name = "uyeId";
            this.uyeId.Size = new System.Drawing.Size(135, 27);
            this.uyeId.TabIndex = 51;
            this.uyeId.Visible = false;
            // 
            // kitapId
            // 
            this.kitapId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kitapId.Location = new System.Drawing.Point(368, 519);
            this.kitapId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitapId.Name = "kitapId";
            this.kitapId.Size = new System.Drawing.Size(135, 27);
            this.kitapId.TabIndex = 52;
            this.kitapId.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1078, 576);
            this.Controls.Add(this.kitapId);
            this.Controls.Add(this.uyeId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kitap_yayinevi);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.kitap_turu);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ara_submit);
            this.Controls.Add(this.ara_list);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.kitap_submit);
            this.Controls.Add(this.uye_submit);
            this.Controls.Add(this.kitap_aciklama);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.kitap_raf);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.kitap_stok);
            this.Controls.Add(this.kitap_sayfa);
            this.Controls.Add(this.kitap_yazari);
            this.Controls.Add(this.kitap_adi);
            this.Controls.Add(this.kitap_barkod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uye_adres);
            this.Controls.Add(this.uye_email);
            this.Controls.Add(this.uye_telefon);
            this.Controls.Add(this.uye_cinsiyet);
            this.Controls.Add(this.uye_yas);
            this.Controls.Add(this.uye_tc);
            this.Controls.Add(this.uye_adsoyad);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox uye_adsoyad;
        private TextBox uye_tc;
        private TextBox uye_yas;
        private ComboBox uye_cinsiyet;
        private TextBox uye_telefon;
        private TextBox uye_email;
        private TextBox uye_adres;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox kitap_stok;
        private TextBox kitap_sayfa;
        private TextBox kitap_yazari;
        private TextBox kitap_adi;
        private TextBox kitap_barkod;
        private Label label16;
        private Label label17;
        private TextBox kitap_raf;
        private Label label18;
        private RichTextBox kitap_aciklama;
        private Button uye_submit;
        private Button kitap_submit;
        private ListBox Result;
        private Label label19;
        private ComboBox ara_list;
        private Button ara_submit;
        private Label label20;
        private ComboBox kitap_turu;
        private TextBox searchBox;
        private TextBox kitap_yayinevi;
        private Button button1;
        private TextBox uyeId;
        private TextBox kitapId;
    }
}