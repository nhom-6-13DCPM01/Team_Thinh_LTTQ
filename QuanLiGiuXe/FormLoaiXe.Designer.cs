
namespace QuanLiGiuXe
{
    partial class FormLoaiXe
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
            this.dgvViTri = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenLoaiXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiXe = new System.Windows.Forms.TextBox();
            this.labelBienSo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViTri
            // 
            this.dgvViTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViTri.Location = new System.Drawing.Point(12, 207);
            this.dgvViTri.Name = "dgvViTri";
            this.dgvViTri.RowHeadersWidth = 51;
            this.dgvViTri.RowTemplate.Height = 24;
            this.dgvViTri.Size = new System.Drawing.Size(609, 231);
            this.dgvViTri.TabIndex = 5;
            this.dgvViTri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViTri_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenLoaiXe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaLoaiXe);
            this.groupBox1.Controls.Add(this.labelBienSo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Loại Xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Giá";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(249, 127);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 38);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(393, 127);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 38);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(107, 127);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 38);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(421, 38);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(161, 26);
            this.txtDonGia.TabIndex = 26;
            // 
            // txtTenLoaiXe
            // 
            this.txtTenLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiXe.Location = new System.Drawing.Point(145, 75);
            this.txtTenLoaiXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoaiXe.Name = "txtTenLoaiXe";
            this.txtTenLoaiXe.Size = new System.Drawing.Size(161, 26);
            this.txtTenLoaiXe.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Loai Xe";
            // 
            // txtMaLoaiXe
            // 
            this.txtMaLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiXe.Location = new System.Drawing.Point(145, 35);
            this.txtMaLoaiXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLoaiXe.Name = "txtMaLoaiXe";
            this.txtMaLoaiXe.ReadOnly = true;
            this.txtMaLoaiXe.Size = new System.Drawing.Size(161, 26);
            this.txtMaLoaiXe.TabIndex = 22;
            // 
            // labelBienSo
            // 
            this.labelBienSo.AutoSize = true;
            this.labelBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienSo.Location = new System.Drawing.Point(16, 39);
            this.labelBienSo.Name = "labelBienSo";
            this.labelBienSo.Size = new System.Drawing.Size(94, 20);
            this.labelBienSo.TabIndex = 21;
            this.labelBienSo.Text = "Mã Loại Xe";
            // 
            // FormLoaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.dgvViTri);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLoaiXe";
            this.Text = "FormLoaiXe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViTri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenLoaiXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiXe;
        private System.Windows.Forms.Label labelBienSo;
    }
}