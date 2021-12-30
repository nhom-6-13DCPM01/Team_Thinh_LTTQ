
namespace QuanLiGiuXe
{
    partial class FormXeVao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.cbbViTri = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.dateTimePickerThoiGianVao = new System.Windows.Forms.DateTimePicker();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxBienSoXe = new System.Windows.Forms.TextBox();
            this.labelBienSo = new System.Windows.Forms.Label();
            this.labelMauXe = new System.Windows.Forms.Label();
            this.labelThoiGianVao = new System.Windows.Forms.Label();
            this.comboBoxLoaiXe = new System.Windows.Forms.ComboBox();
            this.label6LoaiXe = new System.Windows.Forms.Label();
            this.txtTKxe = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dataGridViewXe = new System.Windows.Forms.DataGridView();
            this.labelChoTrong = new System.Windows.Forms.Label();
            this.labelXe = new System.Windows.Forms.Label();
            this.tabControlBaiDo = new System.Windows.Forms.TabControl();
            this.groupBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.txtTKxe);
            this.groupBoxThongTin.Controls.Add(this.buttonTimKiem);
            this.groupBoxThongTin.Controls.Add(this.cbbViTri);
            this.groupBoxThongTin.Controls.Add(this.button1);
            this.groupBoxThongTin.Controls.Add(this.buttonLamMoi);
            this.groupBoxThongTin.Controls.Add(this.dateTimePickerThoiGianVao);
            this.groupBoxThongTin.Controls.Add(this.buttonThem);
            this.groupBoxThongTin.Controls.Add(this.textBoxBienSoXe);
            this.groupBoxThongTin.Controls.Add(this.labelBienSo);
            this.groupBoxThongTin.Controls.Add(this.labelMauXe);
            this.groupBoxThongTin.Controls.Add(this.labelThoiGianVao);
            this.groupBoxThongTin.Controls.Add(this.comboBoxLoaiXe);
            this.groupBoxThongTin.Controls.Add(this.label6LoaiXe);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTin.Location = new System.Drawing.Point(694, 27);
            this.groupBoxThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxThongTin.Size = new System.Drawing.Size(434, 245);
            this.groupBoxThongTin.TabIndex = 35;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Bảng thông tin";
            // 
            // cbbViTri
            // 
            this.cbbViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbViTri.FormattingEnabled = true;
            this.cbbViTri.Items.AddRange(new object[] {
            "xe tay ga",
            "xe so"});
            this.cbbViTri.Location = new System.Drawing.Point(158, 141);
            this.cbbViTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbViTri.Name = "cbbViTri";
            this.cbbViTri.Size = new System.Drawing.Size(130, 28);
            this.cbbViTri.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(321, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "Xóa Xe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoi.Location = new System.Drawing.Point(320, 128);
            this.buttonLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(97, 34);
            this.buttonLamMoi.TabIndex = 19;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // dateTimePickerThoiGianVao
            // 
            this.dateTimePickerThoiGianVao.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerThoiGianVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerThoiGianVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerThoiGianVao.Location = new System.Drawing.Point(158, 67);
            this.dateTimePickerThoiGianVao.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerThoiGianVao.Name = "dateTimePickerThoiGianVao";
            this.dateTimePickerThoiGianVao.Size = new System.Drawing.Size(130, 26);
            this.dateTimePickerThoiGianVao.TabIndex = 33;
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(321, 30);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(96, 31);
            this.buttonThem.TabIndex = 30;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxBienSoXe
            // 
            this.textBoxBienSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBienSoXe.Location = new System.Drawing.Point(158, 29);
            this.textBoxBienSoXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBienSoXe.Name = "textBoxBienSoXe";
            this.textBoxBienSoXe.Size = new System.Drawing.Size(130, 26);
            this.textBoxBienSoXe.TabIndex = 20;
            // 
            // labelBienSo
            // 
            this.labelBienSo.AutoSize = true;
            this.labelBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienSo.Location = new System.Drawing.Point(15, 33);
            this.labelBienSo.Name = "labelBienSo";
            this.labelBienSo.Size = new System.Drawing.Size(98, 20);
            this.labelBienSo.TabIndex = 19;
            this.labelBienSo.Text = "Biển số xe :";
            // 
            // labelMauXe
            // 
            this.labelMauXe.AutoSize = true;
            this.labelMauXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMauXe.Location = new System.Drawing.Point(15, 146);
            this.labelMauXe.Name = "labelMauXe";
            this.labelMauXe.Size = new System.Drawing.Size(59, 20);
            this.labelMauXe.TabIndex = 28;
            this.labelMauXe.Text = "Vị Trí :";
            // 
            // labelThoiGianVao
            // 
            this.labelThoiGianVao.AutoSize = true;
            this.labelThoiGianVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoiGianVao.Location = new System.Drawing.Point(15, 69);
            this.labelThoiGianVao.Name = "labelThoiGianVao";
            this.labelThoiGianVao.Size = new System.Drawing.Size(118, 20);
            this.labelThoiGianVao.TabIndex = 21;
            this.labelThoiGianVao.Text = "Thời gian vào :";
            // 
            // comboBoxLoaiXe
            // 
            this.comboBoxLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiXe.FormattingEnabled = true;
            this.comboBoxLoaiXe.Items.AddRange(new object[] {
            "xe tay ga",
            "xe so"});
            this.comboBoxLoaiXe.Location = new System.Drawing.Point(158, 106);
            this.comboBoxLoaiXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLoaiXe.Name = "comboBoxLoaiXe";
            this.comboBoxLoaiXe.Size = new System.Drawing.Size(130, 28);
            this.comboBoxLoaiXe.TabIndex = 26;
            // 
            // label6LoaiXe
            // 
            this.label6LoaiXe.AutoSize = true;
            this.label6LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6LoaiXe.Location = new System.Drawing.Point(15, 109);
            this.label6LoaiXe.Name = "label6LoaiXe";
            this.label6LoaiXe.Size = new System.Drawing.Size(73, 20);
            this.label6LoaiXe.TabIndex = 23;
            this.label6LoaiXe.Text = "Loại xe :";
            // 
            // txtTKxe
            // 
            this.txtTKxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKxe.Location = new System.Drawing.Point(47, 186);
            this.txtTKxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTKxe.Name = "txtTKxe";
            this.txtTKxe.Size = new System.Drawing.Size(114, 26);
            this.txtTKxe.TabIndex = 35;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(195, 182);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(93, 34);
            this.buttonTimKiem.TabIndex = 16;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // dataGridViewXe
            // 
            this.dataGridViewXe.AllowUserToAddRows = false;
            this.dataGridViewXe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewXe.Location = new System.Drawing.Point(694, 300);
            this.dataGridViewXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewXe.Name = "dataGridViewXe";
            this.dataGridViewXe.ReadOnly = true;
            this.dataGridViewXe.RowHeadersWidth = 51;
            this.dataGridViewXe.RowTemplate.Height = 28;
            this.dataGridViewXe.Size = new System.Drawing.Size(455, 342);
            this.dataGridViewXe.TabIndex = 33;
            // 
            // labelChoTrong
            // 
            this.labelChoTrong.AutoSize = true;
            this.labelChoTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoTrong.Location = new System.Drawing.Point(27, 9);
            this.labelChoTrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChoTrong.Name = "labelChoTrong";
            this.labelChoTrong.Size = new System.Drawing.Size(82, 20);
            this.labelChoTrong.TabIndex = 37;
            this.labelChoTrong.Text = "Chỗ trống";
            // 
            // labelXe
            // 
            this.labelXe.AutoSize = true;
            this.labelXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXe.Location = new System.Drawing.Point(690, 278);
            this.labelXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXe.Name = "labelXe";
            this.labelXe.Size = new System.Drawing.Size(29, 20);
            this.labelXe.TabIndex = 38;
            this.labelXe.Text = "Xe";
            // 
            // tabControlBaiDo
            // 
            this.tabControlBaiDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBaiDo.Location = new System.Drawing.Point(31, 33);
            this.tabControlBaiDo.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlBaiDo.Name = "tabControlBaiDo";
            this.tabControlBaiDo.SelectedIndex = 0;
            this.tabControlBaiDo.Size = new System.Drawing.Size(651, 607);
            this.tabControlBaiDo.TabIndex = 39;
            // 
            // FormXeVao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 653);
            this.Controls.Add(this.tabControlBaiDo);
            this.Controls.Add(this.labelXe);
            this.Controls.Add(this.labelChoTrong);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.dataGridViewXe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1179, 700);
            this.MinimumSize = new System.Drawing.Size(1179, 700);
            this.Name = "FormXeVao";
            this.Text = "FormXeVao";
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxBienSoXe;
        private System.Windows.Forms.Label labelBienSo;
        private System.Windows.Forms.Label labelMauXe;
        private System.Windows.Forms.Label labelThoiGianVao;
        private System.Windows.Forms.ComboBox comboBoxLoaiXe;
        private System.Windows.Forms.Label label6LoaiXe;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewXe;
        private System.Windows.Forms.DateTimePicker dateTimePickerThoiGianVao;
        private System.Windows.Forms.Label labelChoTrong;
        private System.Windows.Forms.Label labelXe;
        private System.Windows.Forms.TabControl tabControlBaiDo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTKxe;
        private System.Windows.Forms.ComboBox cbbViTri;
    }
}

