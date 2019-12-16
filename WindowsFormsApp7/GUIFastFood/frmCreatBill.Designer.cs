namespace WindowsFormsApp7.GUIFastFood
{
    partial class frmCreatBill
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GridItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGaCay = new System.Windows.Forms.Button();
            this.btnGaTruyenThong = new System.Windows.Forms.Button();
            this.btnCanhGaCay = new System.Windows.Forms.Button();
            this.btnCanhTruyenThong = new System.Windows.Forms.Button();
            this.btnUcGaCay = new System.Windows.Forms.Button();
            this.btnUcTruyenThong = new System.Windows.Forms.Button();
            this.btn34Cay = new System.Windows.Forms.Button();
            this.btn34tt = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.btnSpa = new System.Windows.Forms.Button();
            this.btnKhoaiLon = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.btnKemCay = new System.Windows.Forms.Button();
            this.btnGa = new System.Windows.Forms.Button();
            this.btnKhoaiNho = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnSalad = new System.Windows.Forms.Button();
            this.btnBanhCuon = new System.Windows.Forms.Button();
            this.btnPepsiLon = new System.Windows.Forms.Button();
            this.btnPepSiNho = new System.Windows.Forms.Button();
            this.btnSpriteLon = new System.Windows.Forms.Button();
            this.btnSpriteNho = new System.Windows.Forms.Button();
            this.btnCocaLon = new System.Windows.Forms.Button();
            this.btnCocaNho = new System.Windows.Forms.Button();
            this.btncb6 = new System.Windows.Forms.Button();
            this.btncb3 = new System.Windows.Forms.Button();
            this.btncbS = new System.Windows.Forms.Button();
            this.btncbL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateCheck = new System.Windows.Forms.DateTimePicker();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnOdered = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-7, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 354);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đồ ăn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-7, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 158);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đồ Uống";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-7, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 116);
            this.button3.TabIndex = 2;
            this.button3.Text = "Combo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // GridItem
            // 
            this.GridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.GridItem.Location = new System.Drawing.Point(642, 37);
            this.GridItem.Name = "GridItem";
            this.GridItem.ReadOnly = true;
            this.GridItem.RowHeadersWidth = 51;
            this.GridItem.RowTemplate.Height = 24;
            this.GridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItem.Size = new System.Drawing.Size(908, 358);
            this.GridItem.TabIndex = 3;
            this.GridItem.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GridItem_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // btnGaCay
            // 
            this.btnGaCay.Location = new System.Drawing.Point(105, 2);
            this.btnGaCay.Name = "btnGaCay";
            this.btnGaCay.Size = new System.Drawing.Size(156, 40);
            this.btnGaCay.TabIndex = 4;
            this.btnGaCay.Tag = "36000";
            this.btnGaCay.Text = "Gà cay";
            this.btnGaCay.UseVisualStyleBackColor = true;
            this.btnGaCay.Click += new System.EventHandler(this.btnGaCay_Click);
            // 
            // btnGaTruyenThong
            // 
            this.btnGaTruyenThong.Location = new System.Drawing.Point(105, 37);
            this.btnGaTruyenThong.Name = "btnGaTruyenThong";
            this.btnGaTruyenThong.Size = new System.Drawing.Size(156, 40);
            this.btnGaTruyenThong.TabIndex = 5;
            this.btnGaTruyenThong.Tag = "36000";
            this.btnGaTruyenThong.Text = "Gà truyền thống";
            this.btnGaTruyenThong.UseVisualStyleBackColor = true;
            this.btnGaTruyenThong.Click += new System.EventHandler(this.btnGaTruyenThong_Click);
            // 
            // btnCanhGaCay
            // 
            this.btnCanhGaCay.Location = new System.Drawing.Point(105, 74);
            this.btnCanhGaCay.Name = "btnCanhGaCay";
            this.btnCanhGaCay.Size = new System.Drawing.Size(156, 40);
            this.btnCanhGaCay.TabIndex = 6;
            this.btnCanhGaCay.Tag = "25000";
            this.btnCanhGaCay.Text = "Cánh gà cay";
            this.btnCanhGaCay.UseVisualStyleBackColor = true;
            this.btnCanhGaCay.Click += new System.EventHandler(this.btnCanhGaCay_Click);
            // 
            // btnCanhTruyenThong
            // 
            this.btnCanhTruyenThong.Location = new System.Drawing.Point(105, 110);
            this.btnCanhTruyenThong.Name = "btnCanhTruyenThong";
            this.btnCanhTruyenThong.Size = new System.Drawing.Size(156, 40);
            this.btnCanhTruyenThong.TabIndex = 7;
            this.btnCanhTruyenThong.Tag = "25000";
            this.btnCanhTruyenThong.Text = "Cánh truyền thống";
            this.btnCanhTruyenThong.UseVisualStyleBackColor = true;
            this.btnCanhTruyenThong.Click += new System.EventHandler(this.btnCanhTruyenThong_Click);
            // 
            // btnUcGaCay
            // 
            this.btnUcGaCay.Location = new System.Drawing.Point(105, 146);
            this.btnUcGaCay.Name = "btnUcGaCay";
            this.btnUcGaCay.Size = new System.Drawing.Size(156, 40);
            this.btnUcGaCay.TabIndex = 8;
            this.btnUcGaCay.Tag = "30000";
            this.btnUcGaCay.Text = "Ức gà cay";
            this.btnUcGaCay.UseVisualStyleBackColor = true;
            this.btnUcGaCay.Click += new System.EventHandler(this.btnUcGaCay_Click);
            // 
            // btnUcTruyenThong
            // 
            this.btnUcTruyenThong.Location = new System.Drawing.Point(105, 183);
            this.btnUcTruyenThong.Name = "btnUcTruyenThong";
            this.btnUcTruyenThong.Size = new System.Drawing.Size(156, 40);
            this.btnUcTruyenThong.TabIndex = 9;
            this.btnUcTruyenThong.Tag = "30000";
            this.btnUcTruyenThong.Text = "Ức truyền thống";
            this.btnUcTruyenThong.UseVisualStyleBackColor = true;
            this.btnUcTruyenThong.Click += new System.EventHandler(this.btnUcTruyenThong_Click);
            // 
            // btn34Cay
            // 
            this.btn34Cay.Location = new System.Drawing.Point(105, 218);
            this.btn34Cay.Name = "btn34Cay";
            this.btn34Cay.Size = new System.Drawing.Size(156, 40);
            this.btn34Cay.TabIndex = 10;
            this.btn34Cay.Tag = "75000";
            this.btn34Cay.Text = "Ba phần tư cay";
            this.btn34Cay.UseVisualStyleBackColor = true;
            this.btn34Cay.Click += new System.EventHandler(this.btn34Cay_Click);
            // 
            // btn34tt
            // 
            this.btn34tt.Location = new System.Drawing.Point(105, 254);
            this.btn34tt.Name = "btn34tt";
            this.btn34tt.Size = new System.Drawing.Size(156, 47);
            this.btn34tt.TabIndex = 11;
            this.btn34tt.Tag = "75000";
            this.btn34tt.Text = "Ba phần tư truyền thống";
            this.btn34tt.UseVisualStyleBackColor = true;
            this.btn34tt.Click += new System.EventHandler(this.btn34tt_Click);
            // 
            // btnBo
            // 
            this.btnBo.Location = new System.Drawing.Point(105, 299);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(156, 47);
            this.btnBo.TabIndex = 12;
            this.btnBo.Tag = "50000";
            this.btnBo.Text = "Hamburger bò";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // btnSpa
            // 
            this.btnSpa.Location = new System.Drawing.Point(410, 74);
            this.btnSpa.Name = "btnSpa";
            this.btnSpa.Size = new System.Drawing.Size(156, 40);
            this.btnSpa.TabIndex = 13;
            this.btnSpa.Tag = "65000";
            this.btnSpa.Text = "Spagheti";
            this.btnSpa.UseVisualStyleBackColor = true;
            this.btnSpa.Click += new System.EventHandler(this.btnSpa_Click);
            // 
            // btnKhoaiLon
            // 
            this.btnKhoaiLon.Location = new System.Drawing.Point(258, 74);
            this.btnKhoaiLon.Name = "btnKhoaiLon";
            this.btnKhoaiLon.Size = new System.Drawing.Size(156, 40);
            this.btnKhoaiLon.TabIndex = 14;
            this.btnKhoaiLon.Tag = "25000";
            this.btnKhoaiLon.Text = "Khoai tây lớn";
            this.btnKhoaiLon.UseVisualStyleBackColor = true;
            this.btnKhoaiLon.Click += new System.EventHandler(this.btnKhoaiLon_Click);
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(410, 37);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(156, 40);
            this.btnCom.TabIndex = 15;
            this.btnCom.Tag = "10000";
            this.btnCom.Text = "Cơm Thêm";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(258, 37);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(156, 40);
            this.btnSpecial.TabIndex = 16;
            this.btnSpecial.Tag = "80000";
            this.btnSpecial.Text = "Hamburger Special";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // btnKemCay
            // 
            this.btnKemCay.Location = new System.Drawing.Point(410, 2);
            this.btnKemCay.Name = "btnKemCay";
            this.btnKemCay.Size = new System.Drawing.Size(156, 40);
            this.btnKemCay.TabIndex = 17;
            this.btnKemCay.Tag = "10000";
            this.btnKemCay.Text = "Kem Cây";
            this.btnKemCay.UseVisualStyleBackColor = true;
            this.btnKemCay.Click += new System.EventHandler(this.btnKemCay_Click);
            // 
            // btnGa
            // 
            this.btnGa.Location = new System.Drawing.Point(258, 2);
            this.btnGa.Name = "btnGa";
            this.btnGa.Size = new System.Drawing.Size(156, 40);
            this.btnGa.TabIndex = 18;
            this.btnGa.Tag = "65000";
            this.btnGa.Text = "Hamburger gà";
            this.btnGa.UseVisualStyleBackColor = true;
            this.btnGa.Click += new System.EventHandler(this.btnGa_Click);
            // 
            // btnKhoaiNho
            // 
            this.btnKhoaiNho.Location = new System.Drawing.Point(258, 110);
            this.btnKhoaiNho.Name = "btnKhoaiNho";
            this.btnKhoaiNho.Size = new System.Drawing.Size(156, 40);
            this.btnKhoaiNho.TabIndex = 19;
            this.btnKhoaiNho.Tag = "35000";
            this.btnKhoaiNho.Text = "Khoai tây nhỏ";
            this.btnKhoaiNho.UseVisualStyleBackColor = true;
            this.btnKhoaiNho.Click += new System.EventHandler(this.btnKhoaiNho_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(410, 110);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(156, 40);
            this.btnPizza.TabIndex = 20;
            this.btnPizza.Tag = "100000";
            this.btnPizza.Text = "Pizza Special";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnSalad
            // 
            this.btnSalad.Location = new System.Drawing.Point(258, 146);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(156, 40);
            this.btnSalad.TabIndex = 21;
            this.btnSalad.Tag = "20000";
            this.btnSalad.Text = "Salad";
            this.btnSalad.UseVisualStyleBackColor = true;
            this.btnSalad.Click += new System.EventHandler(this.btnSalad_Click);
            // 
            // btnBanhCuon
            // 
            this.btnBanhCuon.Location = new System.Drawing.Point(258, 183);
            this.btnBanhCuon.Name = "btnBanhCuon";
            this.btnBanhCuon.Size = new System.Drawing.Size(156, 40);
            this.btnBanhCuon.TabIndex = 22;
            this.btnBanhCuon.Tag = "20000";
            this.btnBanhCuon.Text = "Bánh cuộn";
            this.btnBanhCuon.UseVisualStyleBackColor = true;
            this.btnBanhCuon.Click += new System.EventHandler(this.btnBanhCuon_Click);
            // 
            // btnPepsiLon
            // 
            this.btnPepsiLon.Location = new System.Drawing.Point(105, 352);
            this.btnPepsiLon.Name = "btnPepsiLon";
            this.btnPepsiLon.Size = new System.Drawing.Size(156, 40);
            this.btnPepsiLon.TabIndex = 23;
            this.btnPepsiLon.Tag = "20000";
            this.btnPepsiLon.Text = "Pepsi Lớn";
            this.btnPepsiLon.UseVisualStyleBackColor = true;
            this.btnPepsiLon.Click += new System.EventHandler(this.btnPepsiLon_Click);
            // 
            // btnPepSiNho
            // 
            this.btnPepSiNho.Location = new System.Drawing.Point(105, 388);
            this.btnPepSiNho.Name = "btnPepSiNho";
            this.btnPepSiNho.Size = new System.Drawing.Size(156, 40);
            this.btnPepSiNho.TabIndex = 24;
            this.btnPepSiNho.Tag = "30000";
            this.btnPepSiNho.Text = "PepSi Nhỏ";
            this.btnPepSiNho.UseVisualStyleBackColor = true;
            this.btnPepSiNho.Click += new System.EventHandler(this.btnPepSiNho_Click);
            // 
            // btnSpriteLon
            // 
            this.btnSpriteLon.Location = new System.Drawing.Point(258, 352);
            this.btnSpriteLon.Name = "btnSpriteLon";
            this.btnSpriteLon.Size = new System.Drawing.Size(156, 40);
            this.btnSpriteLon.TabIndex = 25;
            this.btnSpriteLon.Tag = "20000";
            this.btnSpriteLon.Text = "Sprite Lớn";
            this.btnSpriteLon.UseVisualStyleBackColor = true;
            this.btnSpriteLon.Click += new System.EventHandler(this.btnSpriteLon_Click);
            // 
            // btnSpriteNho
            // 
            this.btnSpriteNho.Location = new System.Drawing.Point(258, 388);
            this.btnSpriteNho.Name = "btnSpriteNho";
            this.btnSpriteNho.Size = new System.Drawing.Size(156, 40);
            this.btnSpriteNho.TabIndex = 26;
            this.btnSpriteNho.Tag = "30000";
            this.btnSpriteNho.Text = "Sprite Nhỏ";
            this.btnSpriteNho.UseVisualStyleBackColor = true;
            this.btnSpriteNho.Click += new System.EventHandler(this.btnSpriteNho_Click);
            // 
            // btnCocaLon
            // 
            this.btnCocaLon.Location = new System.Drawing.Point(105, 423);
            this.btnCocaLon.Name = "btnCocaLon";
            this.btnCocaLon.Size = new System.Drawing.Size(156, 40);
            this.btnCocaLon.TabIndex = 27;
            this.btnCocaLon.Tag = "20000";
            this.btnCocaLon.Text = "Coca Lớn";
            this.btnCocaLon.UseVisualStyleBackColor = true;
            this.btnCocaLon.Click += new System.EventHandler(this.btnCocaLon_Click);
            // 
            // btnCocaNho
            // 
            this.btnCocaNho.Location = new System.Drawing.Point(258, 423);
            this.btnCocaNho.Name = "btnCocaNho";
            this.btnCocaNho.Size = new System.Drawing.Size(156, 40);
            this.btnCocaNho.TabIndex = 28;
            this.btnCocaNho.Tag = "30000";
            this.btnCocaNho.Text = "Coca Nhỏ";
            this.btnCocaNho.UseVisualStyleBackColor = true;
            this.btnCocaNho.Click += new System.EventHandler(this.btnCocaNho_Click);
            // 
            // btncb6
            // 
            this.btncb6.Location = new System.Drawing.Point(105, 509);
            this.btncb6.Name = "btncb6";
            this.btncb6.Size = new System.Drawing.Size(156, 62);
            this.btncb6.TabIndex = 29;
            this.btncb6.Tag = "350000";
            this.btncb6.Text = "Combo 6 miếng gà +3 nước";
            this.btncb6.UseVisualStyleBackColor = true;
            this.btncb6.Click += new System.EventHandler(this.btncb6_Click);
            // 
            // btncb3
            // 
            this.btncb3.Location = new System.Drawing.Point(258, 509);
            this.btncb3.Name = "btncb3";
            this.btncb3.Size = new System.Drawing.Size(156, 62);
            this.btncb3.TabIndex = 30;
            this.btncb3.Tag = "250000";
            this.btncb3.Text = "combo 3 gà+1 nước";
            this.btncb3.UseVisualStyleBackColor = true;
            this.btncb3.Click += new System.EventHandler(this.btncb3_Click);
            // 
            // btncbS
            // 
            this.btncbS.Location = new System.Drawing.Point(105, 564);
            this.btncbS.Name = "btncbS";
            this.btncbS.Size = new System.Drawing.Size(156, 58);
            this.btncbS.TabIndex = 31;
            this.btncbS.Tag = "400000";
            this.btncbS.Text = "Combo Special Mini";
            this.btncbS.UseVisualStyleBackColor = true;
            this.btncbS.Click += new System.EventHandler(this.btncbS_Click);
            // 
            // btncbL
            // 
            this.btncbL.Location = new System.Drawing.Point(258, 564);
            this.btncbL.Name = "btncbL";
            this.btncbL.Size = new System.Drawing.Size(156, 58);
            this.btncbL.TabIndex = 32;
            this.btncbL.Tag = "300000";
            this.btncbL.Text = "Combo Special Lagre";
            this.btncbL.UseVisualStyleBackColor = true;
            this.btncbL.Click += new System.EventHandler(this.btncbL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1034, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "YourOrder";
            // 
            // dtpDateCheck
            // 
            this.dtpDateCheck.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpDateCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCheck.Location = new System.Drawing.Point(885, 551);
            this.dtpDateCheck.Name = "dtpDateCheck";
            this.dtpDateCheck.Size = new System.Drawing.Size(228, 22);
            this.dtpDateCheck.TabIndex = 34;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(960, 415);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(153, 22);
            this.txtTotalBill.TabIndex = 35;
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(960, 471);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.ReadOnly = true;
            this.txtExchange.Size = new System.Drawing.Size(153, 22);
            this.txtExchange.TabIndex = 36;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(960, 443);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(153, 22);
            this.txtTotal.TabIndex = 37;
            // 
            // btnOdered
            // 
            this.btnOdered.Location = new System.Drawing.Point(707, 470);
            this.btnOdered.Name = "btnOdered";
            this.btnOdered.Size = new System.Drawing.Size(156, 40);
            this.btnOdered.TabIndex = 39;
            this.btnOdered.Text = "Thanh Toán";
            this.btnOdered.UseVisualStyleBackColor = true;
            this.btnOdered.Click += new System.EventHandler(this.btnOdered_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(882, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tổng Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tiền nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(882, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tiền thối";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cachier";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbNumber.Location = new System.Drawing.Point(680, 423);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(183, 24);
            this.cbNumber.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Số Lượng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1196, 405);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 30);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(1196, 446);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(81, 31);
            this.button35.TabIndex = 47;
            this.button35.Text = "Ghi Chú";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(1283, 450);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(153, 22);
            this.txtNote.TabIndex = 48;
            // 
            // cbAccount
            // 
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(960, 509);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(153, 24);
            this.cbAccount.TabIndex = 38;
            // 
            // frmCreatBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1562, 616);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdered);
            this.Controls.Add(this.cbAccount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.dtpDateCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncbL);
            this.Controls.Add(this.btncbS);
            this.Controls.Add(this.btncb3);
            this.Controls.Add(this.btncb6);
            this.Controls.Add(this.btnCocaNho);
            this.Controls.Add(this.btnCocaLon);
            this.Controls.Add(this.btnSpriteNho);
            this.Controls.Add(this.btnSpriteLon);
            this.Controls.Add(this.btnPepSiNho);
            this.Controls.Add(this.btnPepsiLon);
            this.Controls.Add(this.btnBanhCuon);
            this.Controls.Add(this.btnSalad);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.btnKhoaiNho);
            this.Controls.Add(this.btnGa);
            this.Controls.Add(this.btnKemCay);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnKhoaiLon);
            this.Controls.Add(this.btnSpa);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.btn34tt);
            this.Controls.Add(this.btn34Cay);
            this.Controls.Add(this.btnUcTruyenThong);
            this.Controls.Add(this.btnUcGaCay);
            this.Controls.Add(this.btnCanhTruyenThong);
            this.Controls.Add(this.btnCanhGaCay);
            this.Controls.Add(this.btnGaTruyenThong);
            this.Controls.Add(this.btnGaCay);
            this.Controls.Add(this.GridItem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmCreatBill";
            this.Text = "frmCreatBill";
            this.Load += new System.EventHandler(this.frmCreatBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView GridItem;
        private System.Windows.Forms.Button btnGaCay;
        private System.Windows.Forms.Button btnGaTruyenThong;
        private System.Windows.Forms.Button btnCanhGaCay;
        private System.Windows.Forms.Button btnCanhTruyenThong;
        private System.Windows.Forms.Button btnUcGaCay;
        private System.Windows.Forms.Button btnUcTruyenThong;
        private System.Windows.Forms.Button btn34Cay;
        private System.Windows.Forms.Button btn34tt;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Button btnSpa;
        private System.Windows.Forms.Button btnKhoaiLon;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Button btnKemCay;
        private System.Windows.Forms.Button btnGa;
        private System.Windows.Forms.Button btnKhoaiNho;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnSalad;
        private System.Windows.Forms.Button btnBanhCuon;
        private System.Windows.Forms.Button btnPepsiLon;
        private System.Windows.Forms.Button btnPepSiNho;
        private System.Windows.Forms.Button btnSpriteLon;
        private System.Windows.Forms.Button btnSpriteNho;
        private System.Windows.Forms.Button btnCocaLon;
        private System.Windows.Forms.Button btnCocaNho;
        private System.Windows.Forms.Button btncb6;
        private System.Windows.Forms.Button btncb3;
        private System.Windows.Forms.Button btncbS;
        private System.Windows.Forms.Button btncbL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateCheck;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnOdered;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cbAccount;
    }
}