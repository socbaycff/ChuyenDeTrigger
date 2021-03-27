namespace DetaiTriggerLeDuyKhang
{
    partial class PhieuXuatForm
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
            System.Windows.Forms.Label pHIEULabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label pHIEULabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            this.qLVTDataSet = new DetaiTriggerLeDuyKhang.QLVTDataSet();
            this.pHATSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHATSINHTableAdapter = new DetaiTriggerLeDuyKhang.QLVTDataSetTableAdapters.PHATSINHTableAdapter();
            this.tableAdapterManager = new DetaiTriggerLeDuyKhang.QLVTDataSetTableAdapters.TableAdapterManager();
            this.pHATSINHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cT_PHATSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PHATSINHTableAdapter = new DetaiTriggerLeDuyKhang.QLVTDataSetTableAdapters.CT_PHATSINHTableAdapter();
            this.cT_PHATSINHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUTextBox = new System.Windows.Forms.TextBox();
            this.nGAYDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hOTENKHTextBox = new System.Windows.Forms.TextBox();
            this.mANVTextBox = new System.Windows.Forms.TextBox();
            this.pHIEUTextBox1 = new System.Windows.Forms.TextBox();
            this.mAVTTextBox = new System.Windows.Forms.TextBox();
            this.sOLUONGTextBox = new System.Windows.Forms.TextBox();
            this.dONGIATextBox = new System.Windows.Forms.TextBox();
            this.ThemVTBtn = new System.Windows.Forms.Button();
            pHIEULabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            pHIEULabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHATSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHATSINHDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHATSINHBindingSource
            // 
            this.pHATSINHBindingSource.DataMember = "PHATSINH";
            this.pHATSINHBindingSource.DataSource = this.qLVTDataSet;
            // 
            // pHATSINHTableAdapter
            // 
            this.pHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHATSINHTableAdapter = this.cT_PHATSINHTableAdapter;
            this.tableAdapterManager.PHATSINHTableAdapter = this.pHATSINHTableAdapter;
            this.tableAdapterManager.UpdateOrder = DetaiTriggerLeDuyKhang.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = null;
            // 
            // pHATSINHDataGridView
            // 
            this.pHATSINHDataGridView.AutoGenerateColumns = false;
            this.pHATSINHDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pHATSINHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pHATSINHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pHATSINHDataGridView.DataSource = this.pHATSINHBindingSource;
            this.pHATSINHDataGridView.Location = new System.Drawing.Point(40, 169);
            this.pHATSINHDataGridView.Name = "pHATSINHDataGridView";
            this.pHATSINHDataGridView.RowTemplate.Height = 24;
            this.pHATSINHDataGridView.Size = new System.Drawing.Size(556, 220);
            this.pHATSINHDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PHIEU";
            this.dataGridViewTextBoxColumn1.HeaderText = "PHIEU";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NGAY";
            this.dataGridViewTextBoxColumn2.HeaderText = "NGAY";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LOAI";
            this.dataGridViewTextBoxColumn3.HeaderText = "LOAI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HOTENKH";
            this.dataGridViewTextBoxColumn4.HeaderText = "HOTENKH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn5.HeaderText = "MANV";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cT_PHATSINHBindingSource
            // 
            this.cT_PHATSINHBindingSource.DataMember = "FK_CT_PHATSINH_PHATSINH";
            this.cT_PHATSINHBindingSource.DataSource = this.pHATSINHBindingSource;
            // 
            // cT_PHATSINHTableAdapter
            // 
            this.cT_PHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // cT_PHATSINHDataGridView
            // 
            this.cT_PHATSINHDataGridView.AutoGenerateColumns = false;
            this.cT_PHATSINHDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cT_PHATSINHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cT_PHATSINHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.cT_PHATSINHDataGridView.DataSource = this.cT_PHATSINHBindingSource;
            this.cT_PHATSINHDataGridView.Location = new System.Drawing.Point(650, 169);
            this.cT_PHATSINHDataGridView.Name = "cT_PHATSINHDataGridView";
            this.cT_PHATSINHDataGridView.RowTemplate.Height = 24;
            this.cT_PHATSINHDataGridView.Size = new System.Drawing.Size(381, 220);
            this.cT_PHATSINHDataGridView.TabIndex = 2;
            this.cT_PHATSINHDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cT_PHATSINHDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PHIEU";
            this.dataGridViewTextBoxColumn6.HeaderText = "PHIEU";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn7.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn8.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn9.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // pHIEULabel
            // 
            pHIEULabel.AutoSize = true;
            pHIEULabel.Location = new System.Drawing.Point(46, 448);
            pHIEULabel.Name = "pHIEULabel";
            pHIEULabel.Size = new System.Drawing.Size(53, 17);
            pHIEULabel.TabIndex = 3;
            pHIEULabel.Text = "PHIEU:";
            // 
            // pHIEUTextBox
            // 
            this.pHIEUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHATSINHBindingSource, "PHIEU", true));
            this.pHIEUTextBox.Location = new System.Drawing.Point(105, 445);
            this.pHIEUTextBox.Name = "pHIEUTextBox";
            this.pHIEUTextBox.Size = new System.Drawing.Size(100, 22);
            this.pHIEUTextBox.TabIndex = 4;
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(240, 447);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(51, 17);
            nGAYLabel.TabIndex = 5;
            nGAYLabel.Text = "NGAY:";
            // 
            // nGAYDateTimePicker
            // 
            this.nGAYDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pHATSINHBindingSource, "NGAY", true));
            this.nGAYDateTimePicker.Location = new System.Drawing.Point(297, 443);
            this.nGAYDateTimePicker.Name = "nGAYDateTimePicker";
            this.nGAYDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.nGAYDateTimePicker.TabIndex = 6;
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(19, 513);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(80, 17);
            hOTENKHLabel.TabIndex = 7;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // hOTENKHTextBox
            // 
            this.hOTENKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHATSINHBindingSource, "HOTENKH", true));
            this.hOTENKHTextBox.Location = new System.Drawing.Point(105, 510);
            this.hOTENKHTextBox.Name = "hOTENKHTextBox";
            this.hOTENKHTextBox.Size = new System.Drawing.Size(100, 22);
            this.hOTENKHTextBox.TabIndex = 8;
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(240, 513);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(51, 17);
            mANVLabel.TabIndex = 9;
            mANVLabel.Text = "MANV:";
            // 
            // mANVTextBox
            // 
            this.mANVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHATSINHBindingSource, "MANV", true));
            this.mANVTextBox.Location = new System.Drawing.Point(297, 510);
            this.mANVTextBox.Name = "mANVTextBox";
            this.mANVTextBox.Size = new System.Drawing.Size(100, 22);
            this.mANVTextBox.TabIndex = 10;
            // 
            // pHIEULabel1
            // 
            pHIEULabel1.AutoSize = true;
            pHIEULabel1.Location = new System.Drawing.Point(660, 448);
            pHIEULabel1.Name = "pHIEULabel1";
            pHIEULabel1.Size = new System.Drawing.Size(53, 17);
            pHIEULabel1.TabIndex = 11;
            pHIEULabel1.Text = "PHIEU:";
            // 
            // pHIEUTextBox1
            // 
            this.pHIEUTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_PHATSINHBindingSource, "PHIEU", true));
            this.pHIEUTextBox1.Location = new System.Drawing.Point(719, 445);
            this.pHIEUTextBox1.Name = "pHIEUTextBox1";
            this.pHIEUTextBox1.Size = new System.Drawing.Size(100, 22);
            this.pHIEUTextBox1.TabIndex = 12;
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(875, 447);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(50, 17);
            mAVTLabel.TabIndex = 13;
            mAVTLabel.Text = "MAVT:";
            // 
            // mAVTTextBox
            // 
            this.mAVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_PHATSINHBindingSource, "MAVT", true));
            this.mAVTTextBox.Location = new System.Drawing.Point(931, 444);
            this.mAVTTextBox.Name = "mAVTTextBox";
            this.mAVTTextBox.Size = new System.Drawing.Size(100, 22);
            this.mAVTTextBox.TabIndex = 14;
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(631, 511);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 17);
            sOLUONGLabel.TabIndex = 15;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // sOLUONGTextBox
            // 
            this.sOLUONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_PHATSINHBindingSource, "SOLUONG", true));
            this.sOLUONGTextBox.Location = new System.Drawing.Point(719, 508);
            this.sOLUONGTextBox.Name = "sOLUONGTextBox";
            this.sOLUONGTextBox.Size = new System.Drawing.Size(100, 22);
            this.sOLUONGTextBox.TabIndex = 16;
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(859, 513);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(66, 17);
            dONGIALabel.TabIndex = 17;
            dONGIALabel.Text = "DONGIA:";
            // 
            // dONGIATextBox
            // 
            this.dONGIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_PHATSINHBindingSource, "DONGIA", true));
            this.dONGIATextBox.Location = new System.Drawing.Point(931, 510);
            this.dONGIATextBox.Name = "dONGIATextBox";
            this.dONGIATextBox.Size = new System.Drawing.Size(100, 22);
            this.dONGIATextBox.TabIndex = 18;
            // 
            // ThemVTBtn
            // 
            this.ThemVTBtn.Location = new System.Drawing.Point(49, 78);
            this.ThemVTBtn.Name = "ThemVTBtn";
            this.ThemVTBtn.Size = new System.Drawing.Size(136, 23);
            this.ThemVTBtn.TabIndex = 21;
            this.ThemVTBtn.Text = "Thêm phiếu Xuất";
            this.ThemVTBtn.UseVisualStyleBackColor = true;
            // 
            // PhieuXuatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 601);
            this.Controls.Add(this.ThemVTBtn);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(this.dONGIATextBox);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.sOLUONGTextBox);
            this.Controls.Add(mAVTLabel);
            this.Controls.Add(this.mAVTTextBox);
            this.Controls.Add(pHIEULabel1);
            this.Controls.Add(this.pHIEUTextBox1);
            this.Controls.Add(mANVLabel);
            this.Controls.Add(this.mANVTextBox);
            this.Controls.Add(hOTENKHLabel);
            this.Controls.Add(this.hOTENKHTextBox);
            this.Controls.Add(nGAYLabel);
            this.Controls.Add(this.nGAYDateTimePicker);
            this.Controls.Add(pHIEULabel);
            this.Controls.Add(this.pHIEUTextBox);
            this.Controls.Add(this.cT_PHATSINHDataGridView);
            this.Controls.Add(this.pHATSINHDataGridView);
            this.Name = "PhieuXuatForm";
            this.Text = "PhieuXuatForm";
            this.Load += new System.EventHandler(this.PhieuXuatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHATSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHATSINHDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource pHATSINHBindingSource;
        private QLVTDataSetTableAdapters.PHATSINHTableAdapter pHATSINHTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVTDataSetTableAdapters.CT_PHATSINHTableAdapter cT_PHATSINHTableAdapter;
        private System.Windows.Forms.DataGridView pHATSINHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource cT_PHATSINHBindingSource;
        private System.Windows.Forms.DataGridView cT_PHATSINHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox pHIEUTextBox;
        private System.Windows.Forms.DateTimePicker nGAYDateTimePicker;
        private System.Windows.Forms.TextBox hOTENKHTextBox;
        private System.Windows.Forms.TextBox mANVTextBox;
        private System.Windows.Forms.TextBox pHIEUTextBox1;
        private System.Windows.Forms.TextBox mAVTTextBox;
        private System.Windows.Forms.TextBox sOLUONGTextBox;
        private System.Windows.Forms.TextBox dONGIATextBox;
        private System.Windows.Forms.Button ThemVTBtn;
    }
}