namespace DXApplication2
{
    partial class FormPhieuxuat
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
            System.Windows.Forms.Label tENCNLabel;
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAPXLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mANVLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuxuat));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChinhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSetDSPM = new DXApplication2.QLVTDataSetDSPM();
            this.v_DS_PHANMANHTableAdapter = new DXApplication2.QLVTDataSetDSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new DXApplication2.QLVTDataSetDSPMTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bdsCtpx = new DevExpress.XtraGrid.GridControl();
            this.Listctpx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmCTPXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DXApplication2.DS();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsPhieuxuat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuXuatTableAdapter = new DXApplication2.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager1 = new DXApplication2.DSTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new DXApplication2.DSTableAdapters.CTPXTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbCtpx = new System.Windows.Forms.GroupBox();
            this.cbMavt = new System.Windows.Forms.ComboBox();
            this.spInDanhSachMaVatTuCTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhsachnhanvien = new DXApplication2.Danhsachnhanvien();
            this.btnOkctpx = new System.Windows.Forms.Button();
            this.txtDongia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoluong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMavt = new DevExpress.XtraEditors.TextEdit();
            this.txtMactpx = new DevExpress.XtraEditors.TextEdit();
            this.gbPhieuxuat = new System.Windows.Forms.GroupBox();
            this.sp_InDanhSachNhanVienDangLamViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet = new DXApplication2.QLVTDataSet();
            this.btnOkphieuxuat = new System.Windows.Forms.Button();
            this.txtManv = new DevExpress.XtraEditors.SpinEdit();
            this.txtTenkhachhang = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaphieuxuat = new DevExpress.XtraEditors.TextEdit();
            this.sp_InDanhSachNhanVienDangLamViecTableAdapter = new DXApplication2.QLVTDataSetTableAdapters.sp_InDanhSachNhanVienDangLamViecTableAdapter();
            this.tableAdapterManager2 = new DXApplication2.QLVTDataSetTableAdapters.TableAdapterManager();
            this.sp_InDanhSachMaVatTuCTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_InDanhSachMaVatTuCTPXTableAdapter = new DXApplication2.DanhsachnhanvienTableAdapters.sp_InDanhSachMaVatTuCTPXTableAdapter();
            this.tableAdapterManager3 = new DXApplication2.DanhsachnhanvienTableAdapters.TableAdapterManager();
            tENCNLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAPXLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mANVLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSetDSPM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCtpx)).BeginInit();
            this.Listctpx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuxuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.gbCtpx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spInDanhSachMaVatTuCTPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMavt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMactpx.Properties)).BeginInit();
            this.gbPhieuxuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachNhanVienDangLamViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenkhachhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaphieuxuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachMaVatTuCTPXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(311, 13);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(47, 13);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "TENCN:";
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(27, 43);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(40, 13);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "MAPX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(27, 82);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(27, 131);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(63, 13);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(27, 173);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAPXLabel1
            // 
            mAPXLabel1.AutoSize = true;
            mAPXLabel1.Location = new System.Drawing.Point(63, 43);
            mAPXLabel1.Name = "mAPXLabel1";
            mAPXLabel1.Size = new System.Drawing.Size(40, 13);
            mAPXLabel1.TabIndex = 0;
            mAPXLabel1.Text = "MAPX:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(63, 82);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(63, 131);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(63, 169);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(52, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // mANVLabel1
            // 
            mANVLabel1.AutoSize = true;
            mANVLabel1.Location = new System.Drawing.Point(342, 185);
            mANVLabel1.Name = "mANVLabel1";
            mANVLabel1.Size = new System.Drawing.Size(0, 13);
            mANVLabel1.TabIndex = 9;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnReload,
            this.btnHuy,
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
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
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHuy.Glyph")));
            this.btnHuy.Id = 3;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 4;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1036, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 597);
            this.barDockControlBottom.Size = new System.Drawing.Size(1036, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 557);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1036, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 557);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tENCNLabel);
            this.panel1.Controls.Add(this.cbChinhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 39);
            this.panel1.TabIndex = 4;
            // 
            // cbChinhanh
            // 
            this.cbChinhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cbChinhanh.DisplayMember = "TENCN";
            this.cbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChinhanh.FormattingEnabled = true;
            this.cbChinhanh.Location = new System.Drawing.Point(364, 10);
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
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DXApplication2.QLVTDataSetDSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bdsCtpx);
            this.panel2.Controls.Add(this.bdsPhieuxuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 191);
            this.panel2.TabIndex = 5;
            // 
            // bdsCtpx
            // 
            this.bdsCtpx.ContextMenuStrip = this.Listctpx;
            this.bdsCtpx.DataSource = this.cTPXBindingSource;
            this.bdsCtpx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bdsCtpx.Location = new System.Drawing.Point(551, 0);
            this.bdsCtpx.MainView = this.gridView2;
            this.bdsCtpx.MenuManager = this.barManager1;
            this.bdsCtpx.Name = "bdsCtpx";
            this.bdsCtpx.Size = new System.Drawing.Size(485, 191);
            this.bdsCtpx.TabIndex = 1;
            this.bdsCtpx.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // Listctpx
            // 
            this.Listctpx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmCTPXToolStripMenuItem,
            this.hủyToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.Listctpx.Name = "contextMenuStrip1";
            this.Listctpx.Size = new System.Drawing.Size(138, 70);
            // 
            // thêmCTPXToolStripMenuItem
            // 
            this.thêmCTPXToolStripMenuItem.Image = global::DXApplication2.Properties.Resources.baogia;
            this.thêmCTPXToolStripMenuItem.Name = "thêmCTPXToolStripMenuItem";
            this.thêmCTPXToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.thêmCTPXToolStripMenuItem.Text = "Thêm CTPX";
            this.thêmCTPXToolStripMenuItem.Click += new System.EventHandler(this.thêmCTPXToolStripMenuItem_Click);
            // 
            // hủyToolStripMenuItem
            // 
            this.hủyToolStripMenuItem.Image = global::DXApplication2.Properties.Resources.images;
            this.hủyToolStripMenuItem.Name = "hủyToolStripMenuItem";
            this.hủyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.hủyToolStripMenuItem.Text = "Hủy";
            this.hủyToolStripMenuItem.Click += new System.EventHandler(this.hủyToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = global::DXApplication2.Properties.Resources.arrow_sign_rotation_icon_reload_symbol_vector_13939029;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // cTPXBindingSource
            // 
            this.cTPXBindingSource.DataMember = "FK_CTPX_PX";
            this.cTPXBindingSource.DataSource = this.phieuXuatBindingSource;
            // 
            // phieuXuatBindingSource
            // 
            this.phieuXuatBindingSource.DataMember = "PhieuXuat";
            this.phieuXuatBindingSource.DataSource = this.dS;
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
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.bdsCtpx;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPX1
            // 
            this.colMAPX1.Caption = "Mã phiếu xuất";
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.OptionsColumn.AllowEdit = false;
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
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
            // bdsPhieuxuat
            // 
            this.bdsPhieuxuat.ContextMenuStrip = this.Listctpx;
            this.bdsPhieuxuat.DataSource = this.phieuXuatBindingSource;
            this.bdsPhieuxuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.bdsPhieuxuat.Location = new System.Drawing.Point(0, 0);
            this.bdsPhieuxuat.MainView = this.gridView1;
            this.bdsPhieuxuat.MenuManager = this.barManager1;
            this.bdsPhieuxuat.Name = "bdsPhieuxuat";
            this.bdsPhieuxuat.Size = new System.Drawing.Size(551, 191);
            this.bdsPhieuxuat.TabIndex = 0;
            this.bdsPhieuxuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.bdsPhieuxuat.Click += new System.EventHandler(this.bdsPhieuxuat_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV});
            this.gridView1.GridControl = this.bdsPhieuxuat;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã phiếu xuất";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.OptionsColumn.AllowEdit = false;
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
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
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên khách hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.OptionsColumn.AllowEdit = false;
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
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
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.CTDDHTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager1.DatHangTableAdapter = null;
            this.tableAdapterManager1.KhoTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager1.UpdateOrder = DXApplication2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VattuTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbCtpx);
            this.panel3.Controls.Add(this.gbPhieuxuat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 216);
            this.panel3.TabIndex = 6;
            // 
            // gbCtpx
            // 
            this.gbCtpx.Controls.Add(this.cbMavt);
            this.gbCtpx.Controls.Add(this.btnOkctpx);
            this.gbCtpx.Controls.Add(dONGIALabel);
            this.gbCtpx.Controls.Add(this.txtDongia);
            this.gbCtpx.Controls.Add(sOLUONGLabel);
            this.gbCtpx.Controls.Add(this.txtSoluong);
            this.gbCtpx.Controls.Add(mAVTLabel);
            this.gbCtpx.Controls.Add(this.txtMavt);
            this.gbCtpx.Controls.Add(mAPXLabel1);
            this.gbCtpx.Controls.Add(this.txtMactpx);
            this.gbCtpx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCtpx.Location = new System.Drawing.Point(551, 0);
            this.gbCtpx.Name = "gbCtpx";
            this.gbCtpx.Size = new System.Drawing.Size(485, 216);
            this.gbCtpx.TabIndex = 1;
            this.gbCtpx.TabStop = false;
            this.gbCtpx.Text = "THÔNG TIN CHI TIẾT PHIẾU XUẤT:";
            // 
            // cbMavt
            // 
            this.cbMavt.DataSource = this.spInDanhSachMaVatTuCTPXBindingSource;
            this.cbMavt.DisplayMember = "MAVT";
            this.cbMavt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMavt.Enabled = false;
            this.cbMavt.FormattingEnabled = true;
            this.cbMavt.Location = new System.Drawing.Point(143, 74);
            this.cbMavt.Name = "cbMavt";
            this.cbMavt.Size = new System.Drawing.Size(95, 21);
            this.cbMavt.TabIndex = 10;
            this.cbMavt.SelectedIndexChanged += new System.EventHandler(this.cbMavt_SelectedIndexChanged);
            // 
            // spInDanhSachMaVatTuCTPXBindingSource
            // 
            this.spInDanhSachMaVatTuCTPXBindingSource.DataMember = "sp_InDanhSachMaVatTuCTPX";
            this.spInDanhSachMaVatTuCTPXBindingSource.DataSource = this.danhsachnhanvien;
            // 
            // danhsachnhanvien
            // 
            this.danhsachnhanvien.DataSetName = "Danhsachnhanvien";
            this.danhsachnhanvien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOkctpx
            // 
            this.btnOkctpx.Enabled = false;
            this.btnOkctpx.Location = new System.Drawing.Point(347, 82);
            this.btnOkctpx.Name = "btnOkctpx";
            this.btnOkctpx.Size = new System.Drawing.Size(75, 36);
            this.btnOkctpx.TabIndex = 8;
            this.btnOkctpx.Text = "OK";
            this.btnOkctpx.UseVisualStyleBackColor = true;
            this.btnOkctpx.Click += new System.EventHandler(this.btnOkctpx_Click);
            // 
            // txtDongia
            // 
            this.txtDongia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "DONGIA", true));
            this.txtDongia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDongia.Enabled = false;
            this.txtDongia.Location = new System.Drawing.Point(143, 166);
            this.txtDongia.MenuManager = this.barManager1;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDongia.Size = new System.Drawing.Size(187, 20);
            this.txtDongia.TabIndex = 7;
            // 
            // txtSoluong
            // 
            this.txtSoluong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "SOLUONG", true));
            this.txtSoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoluong.Enabled = false;
            this.txtSoluong.Location = new System.Drawing.Point(143, 124);
            this.txtSoluong.MenuManager = this.barManager1;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoluong.Size = new System.Drawing.Size(187, 20);
            this.txtSoluong.TabIndex = 5;
            // 
            // txtMavt
            // 
            this.txtMavt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "MAVT", true));
            this.txtMavt.Enabled = false;
            this.txtMavt.Location = new System.Drawing.Point(244, 75);
            this.txtMavt.MenuManager = this.barManager1;
            this.txtMavt.Name = "txtMavt";
            this.txtMavt.Size = new System.Drawing.Size(86, 20);
            this.txtMavt.TabIndex = 3;
            // 
            // txtMactpx
            // 
            this.txtMactpx.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPXBindingSource, "MAPX", true));
            this.txtMactpx.Enabled = false;
            this.txtMactpx.Location = new System.Drawing.Point(143, 40);
            this.txtMactpx.MenuManager = this.barManager1;
            this.txtMactpx.Name = "txtMactpx";
            this.txtMactpx.Size = new System.Drawing.Size(187, 20);
            this.txtMactpx.TabIndex = 1;
            // 
            // gbPhieuxuat
            // 
            this.gbPhieuxuat.Controls.Add(mANVLabel1);
            this.gbPhieuxuat.Controls.Add(this.btnOkphieuxuat);
            this.gbPhieuxuat.Controls.Add(mANVLabel);
            this.gbPhieuxuat.Controls.Add(this.txtManv);
            this.gbPhieuxuat.Controls.Add(hOTENKHLabel);
            this.gbPhieuxuat.Controls.Add(this.txtTenkhachhang);
            this.gbPhieuxuat.Controls.Add(nGAYLabel);
            this.gbPhieuxuat.Controls.Add(this.txtNgay);
            this.gbPhieuxuat.Controls.Add(mAPXLabel);
            this.gbPhieuxuat.Controls.Add(this.txtMaphieuxuat);
            this.gbPhieuxuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPhieuxuat.Location = new System.Drawing.Point(0, 0);
            this.gbPhieuxuat.Name = "gbPhieuxuat";
            this.gbPhieuxuat.Size = new System.Drawing.Size(551, 216);
            this.gbPhieuxuat.TabIndex = 0;
            this.gbPhieuxuat.TabStop = false;
            this.gbPhieuxuat.Text = "THÔNG TIN PHIẾU XUẤT:";
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
            // btnOkphieuxuat
            // 
            this.btnOkphieuxuat.Enabled = false;
            this.btnOkphieuxuat.Location = new System.Drawing.Point(334, 82);
            this.btnOkphieuxuat.Name = "btnOkphieuxuat";
            this.btnOkphieuxuat.Size = new System.Drawing.Size(75, 36);
            this.btnOkphieuxuat.TabIndex = 8;
            this.btnOkphieuxuat.Text = "OK";
            this.btnOkphieuxuat.UseVisualStyleBackColor = true;
            this.btnOkphieuxuat.Click += new System.EventHandler(this.btnOkphieuxuat_Click);
            // 
            // txtManv
            // 
            this.txtManv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "MANV", true));
            this.txtManv.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(96, 166);
            this.txtManv.MenuManager = this.barManager1;
            this.txtManv.Name = "txtManv";
            this.txtManv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtManv.Size = new System.Drawing.Size(179, 20);
            this.txtManv.TabIndex = 7;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "HOTENKH", true));
            this.txtTenkhachhang.Enabled = false;
            this.txtTenkhachhang.Location = new System.Drawing.Point(96, 128);
            this.txtTenkhachhang.MenuManager = this.barManager1;
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(179, 20);
            this.txtTenkhachhang.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Enabled = false;
            this.txtNgay.Location = new System.Drawing.Point(96, 79);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(179, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaphieuxuat
            // 
            this.txtMaphieuxuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuXuatBindingSource, "MAPX", true));
            this.txtMaphieuxuat.Enabled = false;
            this.txtMaphieuxuat.Location = new System.Drawing.Point(96, 40);
            this.txtMaphieuxuat.MenuManager = this.barManager1;
            this.txtMaphieuxuat.Name = "txtMaphieuxuat";
            this.txtMaphieuxuat.Size = new System.Drawing.Size(179, 20);
            this.txtMaphieuxuat.TabIndex = 1;
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
            // sp_InDanhSachMaVatTuCTPXBindingSource
            // 
            this.sp_InDanhSachMaVatTuCTPXBindingSource.DataMember = "sp_InDanhSachMaVatTuCTPX";
            this.sp_InDanhSachMaVatTuCTPXBindingSource.DataSource = this.danhsachnhanvien;
            // 
            // sp_InDanhSachMaVatTuCTPXTableAdapter
            // 
            this.sp_InDanhSachMaVatTuCTPXTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = DXApplication2.DanhsachnhanvienTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormPhieuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPhieuxuat";
            this.Text = "FormPhieuxuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhieuxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSetDSPM)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCtpx)).EndInit();
            this.Listctpx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuxuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gbCtpx.ResumeLayout(false);
            this.gbCtpx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spInDanhSachMaVatTuCTPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMavt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMactpx.Properties)).EndInit();
            this.gbPhieuxuat.ResumeLayout(false);
            this.gbPhieuxuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachNhanVienDangLamViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenkhachhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaphieuxuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDanhSachMaVatTuCTPXBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVTDataSetDSPM qLVTDataSetDSPM;
        private System.Windows.Forms.Panel panel1;
        private QLVTDataSetDSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVTDataSetDSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbChinhanh;
        private DS dS;
        private System.Windows.Forms.BindingSource phieuXuatBindingSource;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl bdsPhieuxuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource cTPXBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbCtpx;
        private System.Windows.Forms.Button btnOkctpx;
        private DevExpress.XtraEditors.SpinEdit txtDongia;
        private DevExpress.XtraEditors.SpinEdit txtSoluong;
        private DevExpress.XtraEditors.TextEdit txtMavt;
        private DevExpress.XtraEditors.TextEdit txtMactpx;
        private System.Windows.Forms.GroupBox gbPhieuxuat;
        private System.Windows.Forms.Button btnOkphieuxuat;
        private DevExpress.XtraEditors.SpinEdit txtManv;
        private DevExpress.XtraEditors.TextEdit txtTenkhachhang;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtMaphieuxuat;
        private DevExpress.XtraGrid.GridControl bdsCtpx;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource sp_InDanhSachNhanVienDangLamViecBindingSource;
        private QLVTDataSetTableAdapters.sp_InDanhSachNhanVienDangLamViecTableAdapter sp_InDanhSachNhanVienDangLamViecTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.ContextMenuStrip Listctpx;
        private System.Windows.Forms.ToolStripMenuItem thêmCTPXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private Danhsachnhanvien danhsachnhanvien;
        private System.Windows.Forms.BindingSource sp_InDanhSachMaVatTuCTPXBindingSource;
        private DanhsachnhanvienTableAdapters.sp_InDanhSachMaVatTuCTPXTableAdapter sp_InDanhSachMaVatTuCTPXTableAdapter;
        private DanhsachnhanvienTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.ComboBox cbMavt;
        private System.Windows.Forms.BindingSource spInDanhSachMaVatTuCTPXBindingSource;

    }
}