namespace DXApplication2
{
    partial class FormTaoTK
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
            this.qLVTDataSet2 = new DXApplication2.QLVTDataSet2();
            this.tableAdapterManager = new DXApplication2.QLVTDataSet2TableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new DevExpress.XtraEditors.SpinEdit();
            this.v_DSNV_CHUA_TAO_LOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet3 = new DXApplication2.QLVTDataSet3();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtPassCF = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNamLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qLVTDataSetDSPM = new DXApplication2.QLVTDataSetDSPM();
            this.tableAdapterManager1 = new DXApplication2.QLVTDataSetDSPMTableAdapters.TableAdapterManager();
            this.tableAdapterManager2 = new DXApplication2.QLVTDataSet3TableAdapters.TableAdapterManager();
            this.v_DSNV_CHUA_TAO_LOGINTableAdapter = new DXApplication2.QLVTDataSet3TableAdapters.V_DSNV_CHUA_TAO_LOGINTableAdapter();
            this.v_DSNV_CHUA_TAO_LOGINGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNV_CHUA_TAO_LOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSetDSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNV_CHUA_TAO_LOGINGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVTDataSet2
            // 
            this.qLVTDataSet2.DataSetName = "QLVTDataSet2";
            this.qLVTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DXApplication2.QLVTDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnTaoTK);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.txtPassCF);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtNamLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 298);
            this.panel1.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.v_DSNV_CHUA_TAO_LOGINBindingSource, "MANV", true));
            this.txtUserName.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUserName.Location = new System.Drawing.Point(425, 14);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUserName.Size = new System.Drawing.Size(287, 20);
            this.txtUserName.TabIndex = 24;
            // 
            // v_DSNV_CHUA_TAO_LOGINBindingSource
            // 
            this.v_DSNV_CHUA_TAO_LOGINBindingSource.DataMember = "V_DSNV_CHUA_TAO_LOGIN";
            this.v_DSNV_CHUA_TAO_LOGINBindingSource.DataSource = this.qLVTDataSet3;
            // 
            // qLVTDataSet3
            // 
            this.qLVTDataSet3.DataSetName = "QLVTDataSet3";
            this.qLVTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(561, 246);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 32);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(425, 246);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(104, 32);
            this.btnTaoTK.TabIndex = 23;
            this.btnTaoTK.Text = "Tạo Tài Khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click_1);
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(425, 201);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(287, 21);
            this.cbRole.TabIndex = 21;
            // 
            // txtPassCF
            // 
            this.txtPassCF.Location = new System.Drawing.Point(425, 158);
            this.txtPassCF.Name = "txtPassCF";
            this.txtPassCF.PasswordChar = '*';
            this.txtPassCF.Size = new System.Drawing.Size(287, 20);
            this.txtPassCF.TabIndex = 18;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(425, 109);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(287, 20);
            this.txtPass.TabIndex = 19;
            // 
            // txtNamLogin
            // 
            this.txtNamLogin.Location = new System.Drawing.Point(425, 60);
            this.txtNamLogin.Name = "txtNamLogin";
            this.txtNamLogin.Size = new System.Drawing.Size(287, 20);
            this.txtNamLogin.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nhóm Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Xác Nhận Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // qLVTDataSetDSPM
            // 
            this.qLVTDataSetDSPM.DataSetName = "QLVTDataSetDSPM";
            this.qLVTDataSetDSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = DXApplication2.QLVTDataSetDSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = DXApplication2.QLVTDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DSNV_CHUA_TAO_LOGINTableAdapter
            // 
            this.v_DSNV_CHUA_TAO_LOGINTableAdapter.ClearBeforeFill = true;
            // 
            // v_DSNV_CHUA_TAO_LOGINGridControl
            // 
            this.v_DSNV_CHUA_TAO_LOGINGridControl.DataSource = this.v_DSNV_CHUA_TAO_LOGINBindingSource;
            this.v_DSNV_CHUA_TAO_LOGINGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_DSNV_CHUA_TAO_LOGINGridControl.Location = new System.Drawing.Point(0, 0);
            this.v_DSNV_CHUA_TAO_LOGINGridControl.MainView = this.gridView1;
            this.v_DSNV_CHUA_TAO_LOGINGridControl.Name = "v_DSNV_CHUA_TAO_LOGINGridControl";
            this.v_DSNV_CHUA_TAO_LOGINGridControl.Size = new System.Drawing.Size(815, 443);
            this.v_DSNV_CHUA_TAO_LOGINGridControl.TabIndex = 3;
            this.v_DSNV_CHUA_TAO_LOGINGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.v_DSNV_CHUA_TAO_LOGINGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.OptionsColumn.AllowEdit = false;
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.Caption = "Trạng thái xóa";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.AllowEdit = false;
            // 
            // FormTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(815, 741);
            this.Controls.Add(this.v_DSNV_CHUA_TAO_LOGINGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "FormTaoTK";
            this.Text = "FormTaoTK";
            this.Load += new System.EventHandler(this.FormTaoTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNV_CHUA_TAO_LOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSetDSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNV_CHUA_TAO_LOGINGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVTDataSet2 qLVTDataSet2;
        private QLVTDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtPassCF;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNamLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLVTDataSetDSPM qLVTDataSetDSPM;
        private QLVTDataSetDSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private QLVTDataSet3 qLVTDataSet3;
        private QLVTDataSet3TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.BindingSource v_DSNV_CHUA_TAO_LOGINBindingSource;
        private QLVTDataSet3TableAdapters.V_DSNV_CHUA_TAO_LOGINTableAdapter v_DSNV_CHUA_TAO_LOGINTableAdapter;
        private DevExpress.XtraGrid.GridControl v_DSNV_CHUA_TAO_LOGINGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SpinEdit txtUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
    }
}