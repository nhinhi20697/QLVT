namespace DXApplication2
{
    partial class FormPhieunhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label tENCNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieunhap));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelChinhanh = new System.Windows.Forms.Panel();
            this.cbChinhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSetDSPM = new DXApplication2.QLVTDataSetDSPM();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bdsCtpn = new DevExpress.XtraGrid.GridControl();
            this.listVattu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemvt = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReloadvt = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DXApplication2.DS();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsPhieunhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuNhapTableAdapter = new DXApplication2.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new DXApplication2.DSTableAdapters.TableAdapterManager();
            this.cTPNTableAdapter = new DXApplication2.DSTableAdapters.CTPNTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCtpn = new System.Windows.Forms.GroupBox();
            this.cbMavt = new System.Windows.Forms.ComboBox();
            this.btnOkctpn = new System.Windows.Forms.Button();
            this.txtDongia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoluong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMavt = new DevExpress.XtraEditors.TextEdit();
            this.txtMactpn = new DevExpress.XtraEditors.TextEdit();
            this.gbPhieunhap = new System.Windows.Forms.GroupBox();
            this.cbMaddh = new System.Windows.Forms.ComboBox();
            this.sp_InDanhSachMaCTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet1 = new DXApplication2.QLVTDataSet1();
            this.btnOkphieunhap = new System.Windows.Forms.Button();
            this.txtManv = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaddh = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaphieunhap = new DevExpress.XtraEditors.TextEdit();
            this.sp_InDanhSachNhanVienDangLamViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new DXApplication2.QLVTDataSet();
            this.spInMaVatTuCTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhsachnhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhsachnhanvien = new DXApplication2.Danhsachnhanvien();
            this.v_DS_PHANMANHTableAdapter = new DXApplication2.QLVTDataSetDSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new DXApplication2.QLVTDataSetDSPMTableAdapters.TableAdapterManager();
            this.sp_InDanhSachMaCTDDHTableAdapter = new DXApplication2.QLVTDataSet1TableAdapters.sp_InDanhSachMaCTDDHTableAdapter();
            this.tableAdapterManager2 = new DXApplication2.QLVTDataSet1TableAdapters.TableAdapterManager();
            this.sp_InDanhSachNhanVienDangLamViecTableAdapter = new DXApplication2.QLVTDataSetTableAdapters.sp_InDanhSachNhanVienDangLamViecTableAdapter();
            this.tableAdapterManager3 = new DXApplication2.QLVTDataSetTableAdapters.TableAdapterManager();
            this.sp_InMaVatTuCTPNTableAdapter = new DXApplication2.DanhsachnhanvienTableAdapters.sp_InMaVatTuCTPNTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panelChinhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSetDSPM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCtpn)).BeginInit();
            this.listVattu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieunhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbCtpn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMavt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMactpn.Properties)).BeginInit();
            this.gbPhieunhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachMaCTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaddh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaphieunhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachNhanVienDangLamViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spInMaVatTuCTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(27, 44);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(41, 13);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(27, 93);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(27, 144);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(27, 183);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(53, 44);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(41, 13);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "MAPN:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(53, 93);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(56, 144);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(56, 187);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(52, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(295, 19);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(47, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "TENCN:";
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
            this.btnExit,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 2;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 3;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 4;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHuy.Glyph")));
            this.btnHuy.Id = 5;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1126, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 737);
            this.barDockControlBottom.Size = new System.Drawing.Size(1126, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 697);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1126, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 697);
            // 
            // panelChinhanh
            // 
            this.panelChinhanh.Controls.Add(tENCNLabel);
            this.panelChinhanh.Controls.Add(this.cbChinhanh);
            this.panelChinhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChinhanh.Location = new System.Drawing.Point(0, 40);
            this.panelChinhanh.Name = "panelChinhanh";
            this.panelChinhanh.Size = new System.Drawing.Size(1126, 41);
            this.panelChinhanh.TabIndex = 4;
            // 
            // cbChinhanh
            // 
            this.cbChinhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cbChinhanh.DisplayMember = "TENCN";
            this.cbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChinhanh.FormattingEnabled = true;
            this.cbChinhanh.Location = new System.Drawing.Point(348, 11);
            this.cbChinhanh.Name = "cbChinhanh";
            this.cbChinhanh.Size = new System.Drawing.Size(121, 21);
            this.cbChinhanh.TabIndex = 1;
            this.cbChinhanh.ValueMember = "TENSERVER";
            this.cbChinhanh.SelectedIndexChanged += new System.EventHandler(this.tENCNComboBox_SelectedIndexChanged);
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
            this.panel2.Controls.Add(this.bdsCtpn);
            this.panel2.Controls.Add(this.bdsPhieunhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 240);
            this.panel2.TabIndex = 11;
            // 
            // bdsCtpn
            // 
            this.bdsCtpn.ContextMenuStrip = this.listVattu;
            this.bdsCtpn.DataSource = this.cTPNBindingSource;
            this.bdsCtpn.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.bdsCtpn.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.bdsCtpn.Location = new System.Drawing.Point(559, 0);
            this.bdsCtpn.MainView = this.gridView2;
            this.bdsCtpn.MenuManager = this.barManager1;
            this.bdsCtpn.Name = "bdsCtpn";
            this.bdsCtpn.Size = new System.Drawing.Size(567, 240);
            this.bdsCtpn.TabIndex = 1;
            this.bdsCtpn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // listVattu
            // 
            this.listVattu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemvt,
            this.btnReloadvt,
            this.hủyToolStripMenuItem});
            this.listVattu.Name = "listVattu";
            this.listVattu.Size = new System.Drawing.Size(215, 70);
            // 
            // btnThemvt
            // 
            this.btnThemvt.Checked = true;
            this.btnThemvt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnThemvt.Image = global::DXApplication2.Properties.Resources.baogia;
            this.btnThemvt.Name = "btnThemvt";
            this.btnThemvt.Size = new System.Drawing.Size(214, 22);
            this.btnThemvt.Text = "Thêm Chi Tiết Phiếu Nhập";
            this.btnThemvt.Click += new System.EventHandler(this.btnThemvt_Click);
            // 
            // btnReloadvt
            // 
            this.btnReloadvt.Image = global::DXApplication2.Properties.Resources.arrow_sign_rotation_icon_reload_symbol_vector_13939029;
            this.btnReloadvt.Name = "btnReloadvt";
            this.btnReloadvt.Size = new System.Drawing.Size(214, 22);
            this.btnReloadvt.Text = "Reload";
            this.btnReloadvt.Click += new System.EventHandler(this.btnReloadvt_Click);
            // 
            // hủyToolStripMenuItem
            // 
            this.hủyToolStripMenuItem.Image = global::DXApplication2.Properties.Resources.back;
            this.hủyToolStripMenuItem.Name = "hủyToolStripMenuItem";
            this.hủyToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.hủyToolStripMenuItem.Text = "Hủy";
            this.hủyToolStripMenuItem.Click += new System.EventHandler(this.hủyToolStripMenuItem_Click);
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "FK_CTPN_PhieuNhap";
            this.cTPNBindingSource.DataSource = this.phieuNhapBindingSource;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.dS;
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
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.bdsCtpn;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "Mã phiếu nhập";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.OptionsColumn.AllowEdit = false;
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
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
            // bdsPhieunhap
            // 
            this.bdsPhieunhap.DataSource = this.phieuNhapBindingSource;
            this.bdsPhieunhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.bdsPhieunhap.Location = new System.Drawing.Point(0, 0);
            this.bdsPhieunhap.MainView = this.gridView1;
            this.bdsPhieunhap.MenuManager = this.barManager1;
            this.bdsPhieunhap.Name = "bdsPhieunhap";
            this.bdsPhieunhap.Size = new System.Drawing.Size(559, 240);
            this.bdsPhieunhap.TabIndex = 0;
            this.bdsPhieunhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV});
            this.gridView1.GridControl = this.bdsPhieunhap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã phiếu nhập";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.OptionsColumn.AllowEdit = false;
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
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
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số đơn đặt hàng";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
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
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DXApplication2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbCtpn);
            this.panel1.Controls.Add(this.gbPhieunhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 264);
            this.panel1.TabIndex = 21;
            // 
            // gbCtpn
            // 
            this.gbCtpn.ContextMenuStrip = this.listVattu;
            this.gbCtpn.Controls.Add(this.cbMavt);
            this.gbCtpn.Controls.Add(this.btnOkctpn);
            this.gbCtpn.Controls.Add(dONGIALabel);
            this.gbCtpn.Controls.Add(this.txtDongia);
            this.gbCtpn.Controls.Add(sOLUONGLabel);
            this.gbCtpn.Controls.Add(this.txtSoluong);
            this.gbCtpn.Controls.Add(mAVTLabel);
            this.gbCtpn.Controls.Add(this.txtMavt);
            this.gbCtpn.Controls.Add(mAPNLabel1);
            this.gbCtpn.Controls.Add(this.txtMactpn);
            this.gbCtpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCtpn.Location = new System.Drawing.Point(559, 0);
            this.gbCtpn.Name = "gbCtpn";
            this.gbCtpn.Size = new System.Drawing.Size(567, 264);
            this.gbCtpn.TabIndex = 1;
            this.gbCtpn.TabStop = false;
            this.gbCtpn.Text = "THÔNG TIN CHI TIẾT PHIẾU NHẬP:";
            // 
            // cbMavt
            // 
            this.cbMavt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMavt.Enabled = false;
            this.cbMavt.FormattingEnabled = true;
            this.cbMavt.Location = new System.Drawing.Point(138, 85);
            this.cbMavt.Name = "cbMavt";
            this.cbMavt.Size = new System.Drawing.Size(100, 21);
            this.cbMavt.TabIndex = 9;
            this.cbMavt.SelectedIndexChanged += new System.EventHandler(this.v);
            // 
            // btnOkctpn
            // 
            this.btnOkctpn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkctpn.Enabled = false;
            this.btnOkctpn.Location = new System.Drawing.Point(390, 122);
            this.btnOkctpn.Name = "btnOkctpn";
            this.btnOkctpn.Size = new System.Drawing.Size(75, 31);
            this.btnOkctpn.TabIndex = 8;
            this.btnOkctpn.Text = "OK";
            this.btnOkctpn.UseVisualStyleBackColor = false;
            this.btnOkctpn.Click += new System.EventHandler(this.btnOkctpn_Click);
            // 
            // txtDongia
            // 
            this.txtDongia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "DONGIA", true));
            this.txtDongia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDongia.Enabled = false;
            this.txtDongia.Location = new System.Drawing.Point(138, 180);
            this.txtDongia.MenuManager = this.barManager1;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDongia.Size = new System.Drawing.Size(210, 20);
            this.txtDongia.TabIndex = 7;
            this.txtDongia.EditValueChanged += new System.EventHandler(this.txtDongia_EditValueChanged);
            // 
            // txtSoluong
            // 
            this.txtSoluong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "SOLUONG", true));
            this.txtSoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoluong.Enabled = false;
            this.txtSoluong.Location = new System.Drawing.Point(138, 137);
            this.txtSoluong.MenuManager = this.barManager1;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoluong.Size = new System.Drawing.Size(210, 20);
            this.txtSoluong.TabIndex = 5;
            // 
            // txtMavt
            // 
            this.txtMavt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAVT", true));
            this.txtMavt.Enabled = false;
            this.txtMavt.Location = new System.Drawing.Point(244, 86);
            this.txtMavt.MenuManager = this.barManager1;
            this.txtMavt.Name = "txtMavt";
            this.txtMavt.Size = new System.Drawing.Size(104, 20);
            this.txtMavt.TabIndex = 3;
            // 
            // txtMactpn
            // 
            this.txtMactpn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAPN", true));
            this.txtMactpn.Enabled = false;
            this.txtMactpn.Location = new System.Drawing.Point(138, 41);
            this.txtMactpn.MenuManager = this.barManager1;
            this.txtMactpn.Name = "txtMactpn";
            this.txtMactpn.Size = new System.Drawing.Size(210, 20);
            this.txtMactpn.TabIndex = 1;
            // 
            // gbPhieunhap
            // 
            this.gbPhieunhap.Controls.Add(this.cbMaddh);
            this.gbPhieunhap.Controls.Add(this.btnOkphieunhap);
            this.gbPhieunhap.Controls.Add(mANVLabel);
            this.gbPhieunhap.Controls.Add(this.txtManv);
            this.gbPhieunhap.Controls.Add(masoDDHLabel);
            this.gbPhieunhap.Controls.Add(this.txtMaddh);
            this.gbPhieunhap.Controls.Add(nGAYLabel);
            this.gbPhieunhap.Controls.Add(this.txtNgay);
            this.gbPhieunhap.Controls.Add(mAPNLabel);
            this.gbPhieunhap.Controls.Add(this.txtMaphieunhap);
            this.gbPhieunhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPhieunhap.Location = new System.Drawing.Point(0, 0);
            this.gbPhieunhap.Name = "gbPhieunhap";
            this.gbPhieunhap.Size = new System.Drawing.Size(559, 264);
            this.gbPhieunhap.TabIndex = 0;
            this.gbPhieunhap.TabStop = false;
            this.gbPhieunhap.Text = "THÔNG TIN PHIẾU NHẬP:";
            // 
            // cbMaddh
            // 
            this.cbMaddh.DataSource = this.sp_InDanhSachMaCTDDHBindingSource;
            this.cbMaddh.DisplayMember = "MasoDDH";
            this.cbMaddh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaddh.Enabled = false;
            this.cbMaddh.FormattingEnabled = true;
            this.cbMaddh.Location = new System.Drawing.Point(96, 140);
            this.cbMaddh.Name = "cbMaddh";
            this.cbMaddh.Size = new System.Drawing.Size(93, 21);
            this.cbMaddh.TabIndex = 10;
            this.cbMaddh.SelectedIndexChanged += new System.EventHandler(this.masoDDHComboBox_SelectedIndexChanged);
            // 
            // sp_InDanhSachMaCTDDHBindingSource
            // 
            this.sp_InDanhSachMaCTDDHBindingSource.DataMember = "sp_InDanhSachMaCTDDH";
            this.sp_InDanhSachMaCTDDHBindingSource.DataSource = this.qLVTDataSet1;
            // 
            // qLVTDataSet1
            // 
            this.qLVTDataSet1.DataSetName = "QLVTDataSet1";
            this.qLVTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOkphieunhap
            // 
            this.btnOkphieunhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkphieunhap.Enabled = false;
            this.btnOkphieunhap.Location = new System.Drawing.Point(449, 89);
            this.btnOkphieunhap.Name = "btnOkphieunhap";
            this.btnOkphieunhap.Size = new System.Drawing.Size(75, 31);
            this.btnOkphieunhap.TabIndex = 8;
            this.btnOkphieunhap.Text = "OK";
            this.btnOkphieunhap.UseVisualStyleBackColor = false;
            this.btnOkphieunhap.Click += new System.EventHandler(this.btnOkphieunhap_Click);
            // 
            // txtManv
            // 
            this.txtManv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MANV", true));
            this.txtManv.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(96, 180);
            this.txtManv.MenuManager = this.barManager1;
            this.txtManv.Name = "txtManv";
            this.txtManv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtManv.Size = new System.Drawing.Size(195, 20);
            this.txtManv.TabIndex = 7;
            // 
            // txtMaddh
            // 
            this.txtMaddh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MasoDDH", true));
            this.txtMaddh.Enabled = false;
            this.txtMaddh.Location = new System.Drawing.Point(195, 141);
            this.txtMaddh.MenuManager = this.barManager1;
            this.txtMaddh.Name = "txtMaddh";
            this.txtMaddh.Size = new System.Drawing.Size(96, 20);
            this.txtMaddh.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Enabled = false;
            this.txtNgay.Location = new System.Drawing.Point(96, 90);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(195, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaphieunhap
            // 
            this.txtMaphieunhap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAPN", true));
            this.txtMaphieunhap.Enabled = false;
            this.txtMaphieunhap.Location = new System.Drawing.Point(96, 41);
            this.txtMaphieunhap.MenuManager = this.barManager1;
            this.txtMaphieunhap.Name = "txtMaphieunhap";
            this.txtMaphieunhap.Size = new System.Drawing.Size(195, 20);
            this.txtMaphieunhap.TabIndex = 1;
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
            // spInMaVatTuCTPNBindingSource
            // 
            this.spInMaVatTuCTPNBindingSource.DataMember = "sp_InMaVatTuCTPN";
            this.spInMaVatTuCTPNBindingSource.DataSource = this.danhsachnhanvienBindingSource;
            // 
            // danhsachnhanvienBindingSource
            // 
            this.danhsachnhanvienBindingSource.DataSource = this.danhsachnhanvien;
            this.danhsachnhanvienBindingSource.Position = 0;
            // 
            // danhsachnhanvien
            // 
            this.danhsachnhanvien.DataSetName = "Danhsachnhanvien";
            this.danhsachnhanvien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sp_InDanhSachMaCTDDHTableAdapter
            // 
            this.sp_InDanhSachMaCTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = DXApplication2.QLVTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_InDanhSachNhanVienDangLamViecTableAdapter
            // 
            this.sp_InDanhSachNhanVienDangLamViecTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = DXApplication2.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_InMaVatTuCTPNTableAdapter
            // 
            this.sp_InMaVatTuCTPNTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChinhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPhieunhap";
            this.Text = "FormPhieunhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhieunhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panelChinhanh.ResumeLayout(false);
            this.panelChinhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSetDSPM)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCtpn)).EndInit();
            this.listVattu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieunhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbCtpn.ResumeLayout(false);
            this.gbCtpn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMavt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMactpn.Properties)).EndInit();
            this.gbPhieunhap.ResumeLayout(false);
            this.gbPhieunhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachMaCTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaddh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaphieunhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachNhanVienDangLamViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spInMaVatTuCTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLVTDataSetDSPM qLVTDataSetDSPM;
        private System.Windows.Forms.Panel panelChinhanh;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private DS dS;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bdsPhieunhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCtpn;
        private System.Windows.Forms.Button btnOkctpn;
        private DevExpress.XtraEditors.SpinEdit txtDongia;
        private DevExpress.XtraEditors.SpinEdit txtSoluong;
        private DevExpress.XtraEditors.TextEdit txtMavt;
        private DevExpress.XtraEditors.TextEdit txtMactpn;
        private System.Windows.Forms.GroupBox gbPhieunhap;
        private System.Windows.Forms.Button btnOkphieunhap;
        private DevExpress.XtraEditors.SpinEdit txtManv;
        private DevExpress.XtraEditors.TextEdit txtMaddh;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtMaphieunhap;
        private DevExpress.XtraGrid.GridControl bdsCtpn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.ContextMenuStrip listVattu;
        private System.Windows.Forms.ToolStripMenuItem btnThemvt;
        private System.Windows.Forms.ToolStripMenuItem btnReloadvt;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVTDataSetDSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVTDataSetDSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbChinhanh;
        private QLVTDataSet1 qLVTDataSet1;
        private System.Windows.Forms.BindingSource sp_InDanhSachMaCTDDHBindingSource;
        private QLVTDataSet1TableAdapters.sp_InDanhSachMaCTDDHTableAdapter sp_InDanhSachMaCTDDHTableAdapter;
        private QLVTDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.ComboBox cbMaddh;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource sp_InDanhSachNhanVienDangLamViecBindingSource;
        private QLVTDataSetTableAdapters.sp_InDanhSachNhanVienDangLamViecTableAdapter sp_InDanhSachNhanVienDangLamViecTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.ComboBox cbMavt;
        private System.Windows.Forms.BindingSource spInMaVatTuCTPNBindingSource;
        private System.Windows.Forms.BindingSource danhsachnhanvienBindingSource;
        private Danhsachnhanvien danhsachnhanvien;
        private DanhsachnhanvienTableAdapters.sp_InMaVatTuCTPNTableAdapter sp_InMaVatTuCTPNTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem;
    }
}