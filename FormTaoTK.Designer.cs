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
            this.danhSachNVChuaTaoTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhSachNVChuaTaoTKTableAdapter = new DXApplication2.QLVTDataSet2TableAdapters.DanhSachNVChuaTaoTKTableAdapter();
            this.tableAdapterManager = new DXApplication2.QLVTDataSet2TableAdapters.TableAdapterManager();
            this.danhSachNVChuaTaoTKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPassCF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtUserName = new DevExpress.XtraEditors.SpinEdit();
            this.btnTaoTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNVChuaTaoTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNVChuaTaoTKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVTDataSet2
            // 
            this.qLVTDataSet2.DataSetName = "QLVTDataSet2";
            this.qLVTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhSachNVChuaTaoTKBindingSource
            // 
            this.danhSachNVChuaTaoTKBindingSource.DataMember = "DanhSachNVChuaTaoTK";
            this.danhSachNVChuaTaoTKBindingSource.DataSource = this.qLVTDataSet2;
            // 
            // danhSachNVChuaTaoTKTableAdapter
            // 
            this.danhSachNVChuaTaoTKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DXApplication2.QLVTDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // danhSachNVChuaTaoTKGridControl
            // 
            this.danhSachNVChuaTaoTKGridControl.DataSource = this.danhSachNVChuaTaoTKBindingSource;
            this.danhSachNVChuaTaoTKGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.danhSachNVChuaTaoTKGridControl.Location = new System.Drawing.Point(0, 0);
            this.danhSachNVChuaTaoTKGridControl.MainView = this.gridView1;
            this.danhSachNVChuaTaoTKGridControl.Name = "danhSachNVChuaTaoTKGridControl";
            this.danhSachNVChuaTaoTKGridControl.Size = new System.Drawing.Size(764, 220);
            this.danhSachNVChuaTaoTKGridControl.TabIndex = 1;
            this.danhSachNVChuaTaoTKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.danhSachNVChuaTaoTKGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // txtNamLogin
            // 
            this.txtNamLogin.Location = new System.Drawing.Point(350, 277);
            this.txtNamLogin.Name = "txtNamLogin";
            this.txtNamLogin.Size = new System.Drawing.Size(253, 20);
            this.txtNamLogin.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(350, 326);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(253, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtPassCF
            // 
            this.txtPassCF.Location = new System.Drawing.Point(350, 375);
            this.txtPassCF.Name = "txtPassCF";
            this.txtPassCF.PasswordChar = '*';
            this.txtPassCF.Size = new System.Drawing.Size(253, 20);
            this.txtPassCF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Xác Nhận Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhóm Quyền";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(350, 418);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(253, 21);
            this.cbRole.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.danhSachNVChuaTaoTKBindingSource, "MANV", true));
            this.txtUserName.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUserName.Location = new System.Drawing.Point(350, 231);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUserName.Size = new System.Drawing.Size(253, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(350, 463);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(130, 32);
            this.btnTaoTK.TabIndex = 12;
            this.btnTaoTK.Text = "Tạo Tài Khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // FormTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 498);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txtPassCF);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNamLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.danhSachNVChuaTaoTKGridControl);
            this.Name = "FormTaoTK";
            this.Text = "FormTaoTK";
            this.Load += new System.EventHandler(this.FormTaoTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNVChuaTaoTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNVChuaTaoTKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVTDataSet2 qLVTDataSet2;
        private System.Windows.Forms.BindingSource danhSachNVChuaTaoTKBindingSource;
        private QLVTDataSet2TableAdapters.DanhSachNVChuaTaoTKTableAdapter danhSachNVChuaTaoTKTableAdapter;
        private QLVTDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl danhSachNVChuaTaoTKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPassCF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRole;
        private DevExpress.XtraEditors.SpinEdit txtUserName;
        private System.Windows.Forms.Button btnTaoTK;
    }
}