namespace DXApplication2
{
    partial class FormDondathang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label tENCNLabel;
            System.Windows.Forms.Label mANVLabel1;
            System.Windows.Forms.Label mAVTLabel1;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDondathang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChinhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSetDSPM = new DXApplication2.QLVTDataSetDSPM();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bdsCtddh = new DevExpress.XtraGrid.GridControl();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DXApplication2.DS();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsDathang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbCtddh = new System.Windows.Forms.GroupBox();
            this.cbMavt = new System.Windows.Forms.ComboBox();
            this.sp_InDanhSachMaVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inDanhSachMaVatTu = new DXApplication2.InDanhSachMaVatTu();
            this.btnOkctddh = new System.Windows.Forms.Button();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoluong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMavt = new DevExpress.XtraEditors.TextEdit();
            this.txtMactddh = new DevExpress.XtraEditors.TextEdit();
            this.gbDathang = new System.Windows.Forms.GroupBox();
            this.Btnokdh = new System.Windows.Forms.Button();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.sp_InDanhSachNhanVienDangLamViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new DXApplication2.QLVTDataSet();
            this.txtManv = new DevExpress.XtraEditors.SpinEdit();
            this.txtNhacungcap = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaddh = new DevExpress.XtraEditors.TextEdit();
            this.datHangTableAdapter = new DXApplication2.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new DXApplication2.DSTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new DXApplication2.DSTableAdapters.CTDDHTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.v_DS_PHANMANHTableAdapter = new DXApplication2.QLVTDataSetDSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new DXApplication2.QLVTDataSetDSPMTableAdapters.TableAdapterManager();
            this.sp_InDanhSachNhanVienDangLamViecTableAdapter = new DXApplication2.QLVTDataSetTableAdapters.sp_InDanhSachNhanVienDangLamViecTableAdapter();
            this.tableAdapterManager2 = new DXApplication2.QLVTDataSetTableAdapters.TableAdapterManager();
            this.sp_InDanhSachMaVatTuTableAdapter = new DXApplication2.InDanhSachMaVatTuTableAdapters.sp_InDanhSachMaVatTuTableAdapter();
            this.tableAdapterManager3 = new DXApplication2.InDanhSachMaVatTuTableAdapters.TableAdapterManager();
            this.Listthem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoavattu = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            mANVLabel1 = new System.Windows.Forms.Label();
            mAVTLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSetDSPM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCtddh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDathang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.gbCtddh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachMaVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inDanhSachMaVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMavt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMactddh.Properties)).BeginInit();
            this.gbDathang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachNhanVienDangLamViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhacungcap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaddh.Properties)).BeginInit();
            this.Listthem.SuspendLayout();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(26, 32);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(26, 69);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(26, 103);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(47, 13);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nha CC:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(20, 103);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(20, 133);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(52, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(42, 19);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(47, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "TENCN:";
            tENCNLabel.Click += new System.EventHandler(this.tENCNLabel_Click);
            // 
            // mANVLabel1
            // 
            mANVLabel1.AutoSize = true;
            mANVLabel1.Location = new System.Drawing.Point(26, 141);
            mANVLabel1.Name = "mANVLabel1";
            mANVLabel1.Size = new System.Drawing.Size(41, 13);
            mANVLabel1.TabIndex = 9;
            mANVLabel1.Text = "MANV:";
            // 
            // mAVTLabel1
            // 
            mAVTLabel1.AutoSize = true;
            mAVTLabel1.Location = new System.Drawing.Point(20, 65);
            mAVTLabel1.Name = "mAVTLabel1";
            mAVTLabel1.Size = new System.Drawing.Size(40, 13);
            mAVTLabel1.TabIndex = 9;
            mAVTLabel1.Text = "MAVT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 11;
            label1.Text = "Maso DDH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnReload,
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 1;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 2;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 3;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1186, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 634);
            this.barDockControlBottom.Size = new System.Drawing.Size(1186, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 594);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1186, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 594);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tENCNLabel);
            this.panel1.Controls.Add(this.cbChinhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 40);
            this.panel1.TabIndex = 4;
            // 
            // cbChinhanh
            // 
            this.cbChinhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cbChinhanh.DisplayMember = "TENCN";
            this.cbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChinhanh.FormattingEnabled = true;
            this.cbChinhanh.Location = new System.Drawing.Point(104, 11);
            this.cbChinhanh.Name = "cbChinhanh";
            this.cbChinhanh.Size = new System.Drawing.Size(121, 21);
            this.cbChinhanh.TabIndex = 1;
            this.cbChinhanh.ValueMember = "TENSERVER";
            this.cbChinhanh.SelectedIndexChanged += new System.EventHandler(this.tENCNComboBox_SelectedIndexChanged_1);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLVTDataSetDSPM;
            // 
            // qLVTDataSetDSPM
            // 
            this.qLVTDataSetDSPM.DataSetName = "QLVTDataSetDSPM";
            this.qLVTDataSetDSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bdsCtddh);
            this.panel2.Controls.Add(this.bdsDathang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 216);
            this.panel2.TabIndex = 11;
            // 
            // bdsCtddh
            // 
            this.bdsCtddh.DataSource = this.cTDDHBindingSource;
            this.bdsCtddh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bdsCtddh.Location = new System.Drawing.Point(523, 0);
            this.bdsCtddh.MainView = this.gridView2;
            this.bdsCtddh.MenuManager = this.barManager1;
            this.bdsCtddh.Name = "bdsCtddh";
            this.bdsCtddh.Size = new System.Drawing.Size(663, 216);
            this.bdsCtddh.TabIndex = 1;
            this.bdsCtddh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "FK_CTDDH_DatHang";
            this.cTDDHBindingSource.DataSource = this.datHangBindingSource;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.bdsCtddh;
            this.gridView2.Name = "gridView2";
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.Caption = "Mã số đơn đặt hàng";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.OptionsColumn.AllowEdit = false;
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // bdsDathang
            // 
            this.bdsDathang.DataSource = this.datHangBindingSource;
            this.bdsDathang.Dock = System.Windows.Forms.DockStyle.Left;
            this.bdsDathang.Location = new System.Drawing.Point(0, 0);
            this.bdsDathang.MainView = this.gridView1;
            this.bdsDathang.MenuManager = this.barManager1;
            this.bdsDathang.Name = "bdsDathang";
            this.bdsDathang.Size = new System.Drawing.Size(523, 216);
            this.bdsDathang.TabIndex = 0;
            this.bdsDathang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV});
            this.gridView1.GridControl = this.bdsDathang;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số đơn đặt hàng";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà cung cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.OptionsColumn.AllowEdit = false;
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbCtddh);
            this.panel3.Controls.Add(this.gbDathang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1186, 170);
            this.panel3.TabIndex = 12;
            // 
            // gbCtddh
            // 
            this.gbCtddh.Controls.Add(label1);
            this.gbCtddh.Controls.Add(mAVTLabel1);
            this.gbCtddh.Controls.Add(this.cbMavt);
            this.gbCtddh.Controls.Add(this.btnOkctddh);
            this.gbCtddh.Controls.Add(dONGIALabel);
            this.gbCtddh.Controls.Add(this.txtDonGia);
            this.gbCtddh.Controls.Add(sOLUONGLabel);
            this.gbCtddh.Controls.Add(this.txtSoluong);
            this.gbCtddh.Controls.Add(this.txtMavt);
            this.gbCtddh.Controls.Add(this.txtMactddh);
            this.gbCtddh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCtddh.Location = new System.Drawing.Point(523, 0);
            this.gbCtddh.Name = "gbCtddh";
            this.gbCtddh.Size = new System.Drawing.Size(663, 170);
            this.gbCtddh.TabIndex = 1;
            this.gbCtddh.TabStop = false;
            this.gbCtddh.Text = "THÔNG TIN CHI TIẾT ĐƠN ĐẶT HÀNG";
            // 
            // cbMavt
            // 
            this.cbMavt.DataSource = this.sp_InDanhSachMaVatTuBindingSource;
            this.cbMavt.DisplayMember = "MAVT";
            this.cbMavt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMavt.Enabled = false;
            this.cbMavt.FormattingEnabled = true;
            this.cbMavt.Location = new System.Drawing.Point(105, 62);
            this.cbMavt.Name = "cbMavt";
            this.cbMavt.Size = new System.Drawing.Size(121, 21);
            this.cbMavt.TabIndex = 10;
            this.cbMavt.SelectedIndexChanged += new System.EventHandler(this.cbMavt_SelectedIndexChanged);
            this.cbMavt.SelectedValueChanged += new System.EventHandler(this.cbMavt_SelectedValueChanged);
            // 
            // sp_InDanhSachMaVatTuBindingSource
            // 
            this.sp_InDanhSachMaVatTuBindingSource.DataMember = "sp_InDanhSachMaVatTu";
            this.sp_InDanhSachMaVatTuBindingSource.DataSource = this.inDanhSachMaVatTu;
            // 
            // inDanhSachMaVatTu
            // 
            this.inDanhSachMaVatTu.DataSetName = "InDanhSachMaVatTu";
            this.inDanhSachMaVatTu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOkctddh
            // 
            this.btnOkctddh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkctddh.Enabled = false;
            this.btnOkctddh.Location = new System.Drawing.Point(386, 81);
            this.btnOkctddh.Name = "btnOkctddh";
            this.btnOkctddh.Size = new System.Drawing.Size(75, 35);
            this.btnOkctddh.TabIndex = 8;
            this.btnOkctddh.Text = "OK";
            this.btnOkctddh.UseVisualStyleBackColor = false;
            this.btnOkctddh.Click += new System.EventHandler(this.btnOkctddh_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "DONGIA", true));
            this.txtDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(105, 134);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Size = new System.Drawing.Size(237, 20);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtSoluong
            // 
            this.txtSoluong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "SOLUONG", true));
            this.txtSoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoluong.Enabled = false;
            this.txtSoluong.Location = new System.Drawing.Point(105, 100);
            this.txtSoluong.MenuManager = this.barManager1;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoluong.Size = new System.Drawing.Size(237, 20);
            this.txtSoluong.TabIndex = 5;
            // 
            // txtMavt
            // 
            this.txtMavt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "MAVT", true));
            this.txtMavt.Enabled = false;
            this.txtMavt.Location = new System.Drawing.Point(241, 62);
            this.txtMavt.MenuManager = this.barManager1;
            this.txtMavt.Name = "txtMavt";
            this.txtMavt.Size = new System.Drawing.Size(101, 20);
            this.txtMavt.TabIndex = 3;
            this.txtMavt.EditValueChanged += new System.EventHandler(this.txtMavt_EditValueChanged);
            // 
            // txtMactddh
            // 
            this.txtMactddh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "MasoDDH", true));
            this.txtMactddh.Enabled = false;
            this.txtMactddh.Location = new System.Drawing.Point(105, 25);
            this.txtMactddh.MenuManager = this.barManager1;
            this.txtMactddh.Name = "txtMactddh";
            this.txtMactddh.Size = new System.Drawing.Size(237, 20);
            this.txtMactddh.TabIndex = 1;
            // 
            // gbDathang
            // 
            this.gbDathang.Controls.Add(this.Btnokdh);
            this.gbDathang.Controls.Add(mANVLabel1);
            this.gbDathang.Controls.Add(this.cbManv);
            this.gbDathang.Controls.Add(this.txtManv);
            this.gbDathang.Controls.Add(nhaCCLabel);
            this.gbDathang.Controls.Add(this.txtNhacungcap);
            this.gbDathang.Controls.Add(nGAYLabel);
            this.gbDathang.Controls.Add(this.txtNgay);
            this.gbDathang.Controls.Add(masoDDHLabel);
            this.gbDathang.Controls.Add(this.txtMaddh);
            this.gbDathang.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDathang.Location = new System.Drawing.Point(0, 0);
            this.gbDathang.Name = "gbDathang";
            this.gbDathang.Size = new System.Drawing.Size(523, 170);
            this.gbDathang.TabIndex = 0;
            this.gbDathang.TabStop = false;
            this.gbDathang.Text = "THÔNG TIN ĐẶT HÀNG:";
            // 
            // Btnokdh
            // 
            this.Btnokdh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btnokdh.Location = new System.Drawing.Point(306, 84);
            this.Btnokdh.Name = "Btnokdh";
            this.Btnokdh.Size = new System.Drawing.Size(75, 32);
            this.Btnokdh.TabIndex = 11;
            this.Btnokdh.Text = "OK";
            this.Btnokdh.UseVisualStyleBackColor = false;
            this.Btnokdh.Click += new System.EventHandler(this.Btnokdh_Click);
            // 
            // cbManv
            // 
            this.cbManv.DataSource = this.sp_InDanhSachNhanVienDangLamViecBindingSource;
            this.cbManv.DisplayMember = "MANV";
            this.cbManv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManv.Enabled = false;
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(95, 138);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(73, 21);
            this.cbManv.TabIndex = 10;
            this.cbManv.SelectedIndexChanged += new System.EventHandler(this.cbManv_SelectedIndexChanged);
            // 
            // sp_InDanhSachNhanVienDangLamViecBindingSource
            // 
            this.sp_InDanhSachNhanVienDangLamViecBindingSource.DataMember = "sp_InDanhSachNhanVienDangLamViec";
            this.sp_InDanhSachNhanVienDangLamViecBindingSource.DataSource = this.qLVTDataSet;
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtManv
            // 
            this.txtManv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MANV", true));
            this.txtManv.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(186, 139);
            this.txtManv.MenuManager = this.barManager1;
            this.txtManv.Name = "txtManv";
            this.txtManv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtManv.Size = new System.Drawing.Size(66, 20);
            this.txtManv.TabIndex = 7;
            // 
            // txtNhacungcap
            // 
            this.txtNhacungcap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "NhaCC", true));
            this.txtNhacungcap.Enabled = false;
            this.txtNhacungcap.Location = new System.Drawing.Point(95, 100);
            this.txtNhacungcap.MenuManager = this.barManager1;
            this.txtNhacungcap.Name = "txtNhacungcap";
            this.txtNhacungcap.Size = new System.Drawing.Size(157, 20);
            this.txtNhacungcap.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Enabled = false;
            this.txtNgay.Location = new System.Drawing.Point(95, 66);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(157, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaddh
            // 
            this.txtMaddh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MasoDDH", true));
            this.txtMaddh.Enabled = false;
            this.txtMaddh.Location = new System.Drawing.Point(95, 29);
            this.txtMaddh.MenuManager = this.barManager1;
            this.txtMaddh.Name = "txtMaddh";
            this.txtMaddh.Size = new System.Drawing.Size(157, 20);
            this.txtMaddh.TabIndex = 1;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DXApplication2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = DXApplication2.QLVTDataSetDSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_InDanhSachNhanVienDangLamViecTableAdapter
            // 
            this.sp_InDanhSachNhanVienDangLamViecTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = DXApplication2.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_InDanhSachMaVatTuTableAdapter
            // 
            this.sp_InDanhSachMaVatTuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = DXApplication2.InDanhSachMaVatTuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Listthem
            // 
            this.Listthem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtHàngToolStripMenuItem,
            this.btnXoavattu,
            this.reloadToolStripMenuItem});
            this.Listthem.Name = "nhi";
            this.Listthem.Size = new System.Drawing.Size(153, 92);
            // 
            // đặtHàngToolStripMenuItem
            // 
            this.đặtHàngToolStripMenuItem.Image = global::DXApplication2.Properties.Resources.online_store;
            this.đặtHàngToolStripMenuItem.Name = "đặtHàngToolStripMenuItem";
            this.đặtHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đặtHàngToolStripMenuItem.Text = "Thêm vật tư";
            this.đặtHàngToolStripMenuItem.Click += new System.EventHandler(this.đặtHàngToolStripMenuItem_Click);
            // 
            // btnXoavattu
            // 
            this.btnXoavattu.Image = global::DXApplication2.Properties.Resources.baogia1;
            this.btnXoavattu.Name = "btnXoavattu";
            this.btnXoavattu.Size = new System.Drawing.Size(152, 22);
            this.btnXoavattu.Text = "Xóa vật tư";
            this.btnXoavattu.Click += new System.EventHandler(this.chiTiếtĐơnĐặtHàngToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = global::DXApplication2.Properties.Resources.arrow_sign_rotation_icon_reload_symbol_vector_13939029;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // FormDondathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 634);
            this.ContextMenuStrip = this.Listthem;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDondathang";
            this.Text = "FormDondathang";
            this.Load += new System.EventHandler(this.FormDondathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSetDSPM)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCtddh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDathang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gbCtddh.ResumeLayout(false);
            this.gbCtddh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachMaVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inDanhSachMaVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMavt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMactddh.Properties)).EndInit();
            this.gbDathang.ResumeLayout(false);
            this.gbDathang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachNhanVienDangLamViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhacungcap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaddh.Properties)).EndInit();
            this.Listthem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbCtddh;
        private System.Windows.Forms.GroupBox gbDathang;
        private System.Windows.Forms.Panel panel2;
        private DS dS;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bdsDathang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private DevExpress.XtraGrid.GridControl bdsCtddh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button btnOkctddh;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private DevExpress.XtraEditors.SpinEdit txtSoluong;
        private DevExpress.XtraEditors.TextEdit txtMavt;
        private DevExpress.XtraEditors.TextEdit txtMactddh;
        private DevExpress.XtraEditors.SpinEdit txtManv;
        private DevExpress.XtraEditors.TextEdit txtNhacungcap;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtMaddh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private QLVTDataSetDSPM qLVTDataSetDSPM;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVTDataSetDSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVTDataSetDSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbChinhanh;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource sp_InDanhSachNhanVienDangLamViecBindingSource;
        private QLVTDataSetTableAdapters.sp_InDanhSachNhanVienDangLamViecTableAdapter sp_InDanhSachNhanVienDangLamViecTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.ComboBox cbManv;
        private InDanhSachMaVatTu inDanhSachMaVatTu;
        private System.Windows.Forms.BindingSource sp_InDanhSachMaVatTuBindingSource;
        private InDanhSachMaVatTuTableAdapters.sp_InDanhSachMaVatTuTableAdapter sp_InDanhSachMaVatTuTableAdapter;
        private InDanhSachMaVatTuTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.ComboBox cbMavt;
        private System.Windows.Forms.ContextMenuStrip Listthem;
        private System.Windows.Forms.ToolStripMenuItem đặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnXoavattu;
        private System.Windows.Forms.Button Btnokdh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
    }
}