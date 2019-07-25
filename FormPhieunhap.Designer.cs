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
            this.panelChinhanh = new System.Windows.Forms.Panel();
            this.cbChinhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSetDSPM = new DXApplication2.QLVTDataSetDSPM();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cTPNGridControl = new DevExpress.XtraGrid.GridControl();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DXApplication2.DS();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
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
            this.btnOkctpn = new System.Windows.Forms.Button();
            this.dONGIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sOLUONGSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAPNTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gbPhieunhap = new System.Windows.Forms.GroupBox();
            this.btnOkphieunhap = new System.Windows.Forms.Button();
            this.mANVSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.masoDDHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.mAPNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.listVattu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemvt = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoavt = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReloadvt = new System.Windows.Forms.ToolStripMenuItem();
            this.v_DS_PHANMANHTableAdapter = new DXApplication2.QLVTDataSetDSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new DXApplication2.QLVTDataSetDSPMTableAdapters.TableAdapterManager();
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
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbCtpn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit1.Properties)).BeginInit();
            this.gbPhieunhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit.Properties)).BeginInit();
            this.listVattu.SuspendLayout();
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
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 2;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 3;
            this.btnReload.Name = "btnReload";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 4;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 659);
            this.barDockControlBottom.Size = new System.Drawing.Size(1126, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 619);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1126, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 619);
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
            this.panel2.Controls.Add(this.cTPNGridControl);
            this.panel2.Controls.Add(this.phieuNhapGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 240);
            this.panel2.TabIndex = 11;
            // 
            // cTPNGridControl
            // 
            this.cTPNGridControl.DataSource = this.cTPNBindingSource;
            this.cTPNGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPNGridControl.Location = new System.Drawing.Point(559, 0);
            this.cTPNGridControl.MainView = this.gridView2;
            this.cTPNGridControl.MenuManager = this.barManager1;
            this.cTPNGridControl.Name = "cTPNGridControl";
            this.cTPNGridControl.Size = new System.Drawing.Size(567, 240);
            this.cTPNGridControl.TabIndex = 1;
            this.cTPNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.gridView2.GridControl = this.cTPNGridControl;
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
            // phieuNhapGridControl
            // 
            this.phieuNhapGridControl.DataSource = this.phieuNhapBindingSource;
            this.phieuNhapGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.phieuNhapGridControl.Location = new System.Drawing.Point(0, 0);
            this.phieuNhapGridControl.MainView = this.gridView1;
            this.phieuNhapGridControl.MenuManager = this.barManager1;
            this.phieuNhapGridControl.Name = "phieuNhapGridControl";
            this.phieuNhapGridControl.Size = new System.Drawing.Size(559, 240);
            this.phieuNhapGridControl.TabIndex = 0;
            this.phieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV});
            this.gridView1.GridControl = this.phieuNhapGridControl;
            this.gridView1.Name = "gridView1";
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
            this.gbCtpn.Controls.Add(this.btnOkctpn);
            this.gbCtpn.Controls.Add(dONGIALabel);
            this.gbCtpn.Controls.Add(this.dONGIASpinEdit);
            this.gbCtpn.Controls.Add(sOLUONGLabel);
            this.gbCtpn.Controls.Add(this.sOLUONGSpinEdit);
            this.gbCtpn.Controls.Add(mAVTLabel);
            this.gbCtpn.Controls.Add(this.mAVTTextEdit);
            this.gbCtpn.Controls.Add(mAPNLabel1);
            this.gbCtpn.Controls.Add(this.mAPNTextEdit1);
            this.gbCtpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCtpn.Location = new System.Drawing.Point(559, 0);
            this.gbCtpn.Name = "gbCtpn";
            this.gbCtpn.Size = new System.Drawing.Size(567, 264);
            this.gbCtpn.TabIndex = 1;
            this.gbCtpn.TabStop = false;
            this.gbCtpn.Text = "THÔNG TIN CHI TIẾT PHIẾU NHẬP:";
            // 
            // btnOkctpn
            // 
            this.btnOkctpn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkctpn.Location = new System.Drawing.Point(323, 93);
            this.btnOkctpn.Name = "btnOkctpn";
            this.btnOkctpn.Size = new System.Drawing.Size(75, 31);
            this.btnOkctpn.TabIndex = 8;
            this.btnOkctpn.Text = "OK";
            this.btnOkctpn.UseVisualStyleBackColor = false;
            // 
            // dONGIASpinEdit
            // 
            this.dONGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "DONGIA", true));
            this.dONGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dONGIASpinEdit.Location = new System.Drawing.Point(138, 180);
            this.dONGIASpinEdit.MenuManager = this.barManager1;
            this.dONGIASpinEdit.Name = "dONGIASpinEdit";
            this.dONGIASpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dONGIASpinEdit.Size = new System.Drawing.Size(130, 20);
            this.dONGIASpinEdit.TabIndex = 7;
            // 
            // sOLUONGSpinEdit
            // 
            this.sOLUONGSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "SOLUONG", true));
            this.sOLUONGSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOLUONGSpinEdit.Location = new System.Drawing.Point(138, 137);
            this.sOLUONGSpinEdit.MenuManager = this.barManager1;
            this.sOLUONGSpinEdit.Name = "sOLUONGSpinEdit";
            this.sOLUONGSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOLUONGSpinEdit.Size = new System.Drawing.Size(130, 20);
            this.sOLUONGSpinEdit.TabIndex = 5;
            // 
            // mAVTTextEdit
            // 
            this.mAVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAVT", true));
            this.mAVTTextEdit.Location = new System.Drawing.Point(138, 86);
            this.mAVTTextEdit.MenuManager = this.barManager1;
            this.mAVTTextEdit.Name = "mAVTTextEdit";
            this.mAVTTextEdit.Size = new System.Drawing.Size(130, 20);
            this.mAVTTextEdit.TabIndex = 3;
            // 
            // mAPNTextEdit1
            // 
            this.mAPNTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAPN", true));
            this.mAPNTextEdit1.Location = new System.Drawing.Point(138, 41);
            this.mAPNTextEdit1.MenuManager = this.barManager1;
            this.mAPNTextEdit1.Name = "mAPNTextEdit1";
            this.mAPNTextEdit1.Size = new System.Drawing.Size(130, 20);
            this.mAPNTextEdit1.TabIndex = 1;
            // 
            // gbPhieunhap
            // 
            this.gbPhieunhap.Controls.Add(this.btnOkphieunhap);
            this.gbPhieunhap.Controls.Add(mANVLabel);
            this.gbPhieunhap.Controls.Add(this.mANVSpinEdit);
            this.gbPhieunhap.Controls.Add(masoDDHLabel);
            this.gbPhieunhap.Controls.Add(this.masoDDHTextEdit);
            this.gbPhieunhap.Controls.Add(nGAYLabel);
            this.gbPhieunhap.Controls.Add(this.txtNgay);
            this.gbPhieunhap.Controls.Add(mAPNLabel);
            this.gbPhieunhap.Controls.Add(this.mAPNTextEdit);
            this.gbPhieunhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPhieunhap.Location = new System.Drawing.Point(0, 0);
            this.gbPhieunhap.Name = "gbPhieunhap";
            this.gbPhieunhap.Size = new System.Drawing.Size(559, 264);
            this.gbPhieunhap.TabIndex = 0;
            this.gbPhieunhap.TabStop = false;
            this.gbPhieunhap.Text = "THÔNG TIN PHIẾU NHẬP:";
            // 
            // btnOkphieunhap
            // 
            this.btnOkphieunhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOkphieunhap.Location = new System.Drawing.Point(297, 93);
            this.btnOkphieunhap.Name = "btnOkphieunhap";
            this.btnOkphieunhap.Size = new System.Drawing.Size(75, 31);
            this.btnOkphieunhap.TabIndex = 8;
            this.btnOkphieunhap.Text = "OK";
            this.btnOkphieunhap.UseVisualStyleBackColor = false;
            // 
            // mANVSpinEdit
            // 
            this.mANVSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MANV", true));
            this.mANVSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mANVSpinEdit.Location = new System.Drawing.Point(96, 180);
            this.mANVSpinEdit.MenuManager = this.barManager1;
            this.mANVSpinEdit.Name = "mANVSpinEdit";
            this.mANVSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mANVSpinEdit.Size = new System.Drawing.Size(146, 20);
            this.mANVSpinEdit.TabIndex = 7;
            // 
            // masoDDHTextEdit
            // 
            this.masoDDHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MasoDDH", true));
            this.masoDDHTextEdit.Location = new System.Drawing.Point(96, 141);
            this.masoDDHTextEdit.MenuManager = this.barManager1;
            this.masoDDHTextEdit.Name = "masoDDHTextEdit";
            this.masoDDHTextEdit.Size = new System.Drawing.Size(146, 20);
            this.masoDDHTextEdit.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(96, 90);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(146, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // mAPNTextEdit
            // 
            this.mAPNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAPN", true));
            this.mAPNTextEdit.Location = new System.Drawing.Point(96, 41);
            this.mAPNTextEdit.MenuManager = this.barManager1;
            this.mAPNTextEdit.Name = "mAPNTextEdit";
            this.mAPNTextEdit.Size = new System.Drawing.Size(146, 20);
            this.mAPNTextEdit.TabIndex = 1;
            // 
            // listVattu
            // 
            this.listVattu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemvt,
            this.btnXoavt,
            this.btnReloadvt});
            this.listVattu.Name = "listVattu";
            this.listVattu.Size = new System.Drawing.Size(139, 70);
            // 
            // btnThemvt
            // 
            this.btnThemvt.Checked = true;
            this.btnThemvt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnThemvt.Image = global::DXApplication2.Properties.Resources.baogia;
            this.btnThemvt.Name = "btnThemvt";
            this.btnThemvt.Size = new System.Drawing.Size(138, 22);
            this.btnThemvt.Text = "Thêm vật tư";
            // 
            // btnXoavt
            // 
            this.btnXoavt.Image = global::DXApplication2.Properties.Resources.online_store;
            this.btnXoavt.Name = "btnXoavt";
            this.btnXoavt.Size = new System.Drawing.Size(138, 22);
            this.btnXoavt.Text = "Xóa vật tư";
            // 
            // btnReloadvt
            // 
            this.btnReloadvt.Image = global::DXApplication2.Properties.Resources.arrow_sign_rotation_icon_reload_symbol_vector_13939029;
            this.btnReloadvt.Name = "btnReloadvt";
            this.btnReloadvt.Size = new System.Drawing.Size(138, 22);
            this.btnReloadvt.Text = "Reload";
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
            // FormPhieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 659);
            this.ContextMenuStrip = this.listVattu;
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
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbCtpn.ResumeLayout(false);
            this.gbCtpn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit1.Properties)).EndInit();
            this.gbPhieunhap.ResumeLayout(false);
            this.gbPhieunhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit.Properties)).EndInit();
            this.listVattu.ResumeLayout(false);
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
        private DevExpress.XtraGrid.GridControl phieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCtpn;
        private System.Windows.Forms.Button btnOkctpn;
        private DevExpress.XtraEditors.SpinEdit dONGIASpinEdit;
        private DevExpress.XtraEditors.SpinEdit sOLUONGSpinEdit;
        private DevExpress.XtraEditors.TextEdit mAVTTextEdit;
        private DevExpress.XtraEditors.TextEdit mAPNTextEdit1;
        private System.Windows.Forms.GroupBox gbPhieunhap;
        private System.Windows.Forms.Button btnOkphieunhap;
        private DevExpress.XtraEditors.SpinEdit mANVSpinEdit;
        private DevExpress.XtraEditors.TextEdit masoDDHTextEdit;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit mAPNTextEdit;
        private DevExpress.XtraGrid.GridControl cTPNGridControl;
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
        private System.Windows.Forms.ToolStripMenuItem btnXoavt;
        private System.Windows.Forms.ToolStripMenuItem btnReloadvt;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVTDataSetDSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVTDataSetDSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbChinhanh;
    }
}