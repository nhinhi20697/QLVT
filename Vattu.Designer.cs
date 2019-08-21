namespace DXApplication2
{
    partial class Vattu
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
            System.Windows.Forms.Label mAVTLabel1;
            System.Windows.Forms.Label tENVTLabel1;
            System.Windows.Forms.Label dVTLabel1;
            System.Windows.Forms.Label sOLUONGTONLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vattu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new DXApplication2.DS();
            this.gbVattu = new System.Windows.Forms.Panel();
            this.txtSlt = new DevExpress.XtraEditors.SpinEdit();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDvt = new DevExpress.XtraEditors.TextEdit();
            this.txtTenvt = new DevExpress.XtraEditors.TextEdit();
            this.txtMavt = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.vattuTableAdapter = new DXApplication2.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new DXApplication2.DSTableAdapters.TableAdapterManager();
            this.bdsVattu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            mAVTLabel1 = new System.Windows.Forms.Label();
            tENVTLabel1 = new System.Windows.Forms.Label();
            dVTLabel1 = new System.Windows.Forms.Label();
            sOLUONGTONLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.gbVattu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDvt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenvt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMavt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel1
            // 
            mAVTLabel1.AutoSize = true;
            mAVTLabel1.Location = new System.Drawing.Point(65, 17);
            mAVTLabel1.Name = "mAVTLabel1";
            mAVTLabel1.Size = new System.Drawing.Size(65, 21);
            mAVTLabel1.TabIndex = 8;
            mAVTLabel1.Text = "MAVT:";
            // 
            // tENVTLabel1
            // 
            tENVTLabel1.AutoSize = true;
            tENVTLabel1.Location = new System.Drawing.Point(65, 59);
            tENVTLabel1.Name = "tENVTLabel1";
            tENVTLabel1.Size = new System.Drawing.Size(74, 21);
            tENVTLabel1.TabIndex = 9;
            tENVTLabel1.Text = "TENVT:";
            tENVTLabel1.Click += new System.EventHandler(this.tENVTLabel1_Click);
            // 
            // dVTLabel1
            // 
            dVTLabel1.AutoSize = true;
            dVTLabel1.Location = new System.Drawing.Point(65, 93);
            dVTLabel1.Name = "dVTLabel1";
            dVTLabel1.Size = new System.Drawing.Size(51, 21);
            dVTLabel1.TabIndex = 10;
            dVTLabel1.Text = "DVT:";
            dVTLabel1.Click += new System.EventHandler(this.dVTLabel1_Click);
            // 
            // sOLUONGTONLabel1
            // 
            sOLUONGTONLabel1.AutoSize = true;
            sOLUONGTONLabel1.Location = new System.Drawing.Point(65, 126);
            sOLUONGTONLabel1.Name = "sOLUONGTONLabel1";
            sOLUONGTONLabel1.Size = new System.Drawing.Size(143, 21);
            sOLUONGTONLabel1.TabIndex = 11;
            sOLUONGTONLabel1.Text = "SOLUONGTON:";
            sOLUONGTONLabel1.Click += new System.EventHandler(this.sOLUONGTONLabel1_Click);
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
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnExit,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnXoa.Id = 1;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGhi.Glyph")));
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 4;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 5;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHuy.Glyph")));
            this.btnHuy.Id = 6;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1362, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 718);
            this.barDockControlBottom.Size = new System.Drawing.Size(1362, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 678);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1362, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 678);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.Glyph")));
            this.btnUndo.Id = 3;
            this.btnUndo.Name = "btnUndo";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbVattu
            // 
            this.gbVattu.Controls.Add(sOLUONGTONLabel1);
            this.gbVattu.Controls.Add(this.txtSlt);
            this.gbVattu.Controls.Add(dVTLabel1);
            this.gbVattu.Controls.Add(this.txtDvt);
            this.gbVattu.Controls.Add(tENVTLabel1);
            this.gbVattu.Controls.Add(this.txtTenvt);
            this.gbVattu.Controls.Add(mAVTLabel1);
            this.gbVattu.Controls.Add(this.txtMavt);
            this.gbVattu.Controls.Add(this.button1);
            this.gbVattu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbVattu.Location = new System.Drawing.Point(0, 501);
            this.gbVattu.Name = "gbVattu";
            this.gbVattu.Size = new System.Drawing.Size(1362, 217);
            this.gbVattu.TabIndex = 10;
            this.gbVattu.Paint += new System.Windows.Forms.PaintEventHandler(this.textDvt_Paint);
            // 
            // txtSlt
            // 
            this.txtSlt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "SOLUONGTON", true));
            this.txtSlt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSlt.Location = new System.Drawing.Point(227, 128);
            this.txtSlt.MenuManager = this.barManager1;
            this.txtSlt.Name = "txtSlt";
            this.txtSlt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSlt.Size = new System.Drawing.Size(144, 20);
            this.txtSlt.TabIndex = 12;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.dS;
            // 
            // txtDvt
            // 
            this.txtDvt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "DVT", true));
            this.txtDvt.Location = new System.Drawing.Point(145, 90);
            this.txtDvt.MenuManager = this.barManager1;
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(226, 20);
            this.txtDvt.TabIndex = 11;
            this.txtDvt.EditValueChanged += new System.EventHandler(this.dVTTextEdit_EditValueChanged);
            // 
            // txtTenvt
            // 
            this.txtTenvt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "TENVT", true));
            this.txtTenvt.Location = new System.Drawing.Point(145, 56);
            this.txtTenvt.MenuManager = this.barManager1;
            this.txtTenvt.Name = "txtTenvt";
            this.txtTenvt.Size = new System.Drawing.Size(226, 20);
            this.txtTenvt.TabIndex = 10;
            this.txtTenvt.EditValueChanged += new System.EventHandler(this.tENVTTextEdit_EditValueChanged);
            // 
            // txtMavt
            // 
            this.txtMavt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "MAVT", true));
            this.txtMavt.Location = new System.Drawing.Point(145, 19);
            this.txtMavt.MenuManager = this.barManager1;
            this.txtMavt.Name = "txtMavt";
            this.txtMavt.Size = new System.Drawing.Size(226, 20);
            this.txtMavt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(425, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DXApplication2.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // bdsVattu
            // 
            this.bdsVattu.DataSource = this.vattuBindingSource;
            this.bdsVattu.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdsVattu.Location = new System.Drawing.Point(0, 40);
            this.bdsVattu.MainView = this.gridView1;
            this.bdsVattu.MenuManager = this.barManager1;
            this.bdsVattu.Name = "bdsVattu";
            this.bdsVattu.Size = new System.Drawing.Size(1362, 220);
            this.bdsVattu.TabIndex = 15;
            this.bdsVattu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.bdsVattu;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // Vattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.bdsVattu);
            this.Controls.Add(this.gbVattu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Vattu";
            this.Text = "Vattu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vattu_FormClosing);
            this.Load += new System.EventHandler(this.Vattu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.gbVattu.ResumeLayout(false);
            this.gbVattu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDvt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenvt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMavt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DS dS;
        private System.Windows.Forms.Panel gbVattu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl bdsVattu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SpinEdit txtSlt;
        private DevExpress.XtraEditors.TextEdit txtDvt;
        private DevExpress.XtraEditors.TextEdit txtTenvt;
        private DevExpress.XtraEditors.TextEdit txtMavt;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
    }
}