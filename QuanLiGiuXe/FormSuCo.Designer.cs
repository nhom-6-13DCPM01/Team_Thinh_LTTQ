﻿@@ -0,0 + 1,370 @@
﻿
namespace QuanLiGiuXe
{
    partial class FormSuCo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMucBoiThuong = new System.Windows.Forms.Label();
            this.pictureBoxMucBoiThuong = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMucBienBan = new System.Windows.Forms.Label();
            this.pictureBoxMucBienBan = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMucKiemTra = new System.Windows.Forms.Label();
            this.pictureBoxMucKiemTra = new System.Windows.Forms.PictureBox();
            this.dataGridViewSoXeVao = new System.Windows.Forms.DataGridView();
            this.dataGridViewSoXeRa = new System.Windows.Forms.DataGridView();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dateTimePickerNgayRa = new System.Windows.Forms.DateTimePicker();
            this.labelNgayRa = new System.Windows.Forms.Label();
            this.dateTimePickerNgayVao = new System.Windows.Forms.DateTimePicker();
            this.labelNgayVao = new System.Windows.Forms.Label();
            this.textBoxBaiDo = new System.Windows.Forms.TextBox();
            this.labelBaiDo = new System.Windows.Forms.Label();
            this.textBoxBienSoXe = new System.Windows.Forms.TextBox();
            this.labelBienSoXe = new System.Windows.Forms.Label();
            this.labelSoXeVao = new System.Windows.Forms.Label();
            this.labelSoXeRa = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMucBoiThuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMucBienBan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMucKiemTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoXeVao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoXeRa)).BeginInit();
            this.groupBoxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 92);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelMucBoiThuong);
            this.panel3.Controls.Add(this.pictureBoxMucBoiThuong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(585, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 86);
            this.panel3.TabIndex = 2;
            // 
            // labelMucBoiThuong
            // 
            this.labelMucBoiThuong.AutoSize = true;
            this.labelMucBoiThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMucBoiThuong.Location = new System.Drawing.Point(83, 36);
            this.labelMucBoiThuong.Name = "labelMucBoiThuong";
            this.labelMucBoiThuong.Size = new System.Drawing.Size(194, 25);
            this.labelMucBoiThuong.TabIndex = 5;
            this.labelMucBoiThuong.Text = "Lập phiếu bồi thường";
            // 
            // pictureBoxMucBoiThuong
            // 
            this.pictureBoxMucBoiThuong.Location = new System.Drawing.Point(9, 9);
            this.pictureBoxMucBoiThuong.Name = "pictureBoxMucBoiThuong";
            this.pictureBoxMucBoiThuong.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxMucBoiThuong.TabIndex = 4;
            this.pictureBoxMucBoiThuong.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMucBienBan);
            this.panel2.Controls.Add(this.pictureBoxMucBienBan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(294, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 86);
            this.panel2.TabIndex = 1;
            // 
            // labelMucBienBan
            // 
            this.labelMucBienBan.AutoSize = true;
            this.labelMucBienBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMucBienBan.Location = new System.Drawing.Point(130, 36);
            this.labelMucBienBan.Name = "labelMucBienBan";
            this.labelMucBienBan.Size = new System.Drawing.Size(125, 25);
            this.labelMucBienBan.TabIndex = 3;
            this.labelMucBienBan.Text = "Lập biên bản";
            // 
            // pictureBoxMucBienBan
            // 
            this.pictureBoxMucBienBan.Location = new System.Drawing.Point(13, 9);
            this.pictureBoxMucBienBan.Name = "pictureBoxMucBienBan";
            this.pictureBoxMucBienBan.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxMucBienBan.TabIndex = 2;
            this.pictureBoxMucBienBan.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMucKiemTra);
            this.panel1.Controls.Add(this.pictureBoxMucKiemTra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 86);
            this.panel1.TabIndex = 0;
            // 
            // labelMucKiemTra
            // 
            this.labelMucKiemTra.AutoSize = true;
            this.labelMucKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMucKiemTra.Location = new System.Drawing.Point(117, 36);
            this.labelMucKiemTra.Name = "labelMucKiemTra";
            this.labelMucKiemTra.Size = new System.Drawing.Size(84, 25);
            this.labelMucKiemTra.TabIndex = 1;
            this.labelMucKiemTra.Text = "Kiểm tra";
            // 
            // pictureBoxMucKiemTra
            // 
            this.pictureBoxMucKiemTra.Location = new System.Drawing.Point(9, 9);
            this.pictureBoxMucKiemTra.Name = "pictureBoxMucKiemTra";
            this.pictureBoxMucKiemTra.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxMucKiemTra.TabIndex = 0;
            this.pictureBoxMucKiemTra.TabStop = false;
            // 
            // dataGridViewSoXeVao
            // 
            this.dataGridViewSoXeVao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoXeVao.Location = new System.Drawing.Point(31, 327);
            this.dataGridViewSoXeVao.Name = "dataGridViewSoXeVao";
            this.dataGridViewSoXeVao.Size = new System.Drawing.Size(370, 229);
            this.dataGridViewSoXeVao.TabIndex = 1;
            // 
            // dataGridViewSoXeRa
            // 
            this.dataGridViewSoXeRa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoXeRa.Location = new System.Drawing.Point(477, 327);
            this.dataGridViewSoXeRa.Name = "dataGridViewSoXeRa";
            this.dataGridViewSoXeRa.Size = new System.Drawing.Size(365, 229);
            this.dataGridViewSoXeRa.TabIndex = 2;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.buttonTimKiem);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerNgayRa);
            this.groupBoxTimKiem.Controls.Add(this.labelNgayRa);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerNgayVao);
            this.groupBoxTimKiem.Controls.Add(this.labelNgayVao);
            this.groupBoxTimKiem.Controls.Add(this.textBoxBaiDo);
            this.groupBoxTimKiem.Controls.Add(this.labelBaiDo);
            this.groupBoxTimKiem.Controls.Add(this.textBoxBienSoXe);
            this.groupBoxTimKiem.Controls.Add(this.labelBienSoXe);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(31, 128);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(811, 154);
            this.groupBoxTimKiem.TabIndex = 3;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(350, 99);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(108, 33);
            this.buttonTimKiem.TabIndex = 8;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgayRa
            // 
            this.dateTimePickerNgayRa.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerNgayRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayRa.Location = new System.Drawing.Point(496, 33);
            this.dateTimePickerNgayRa.Name = "dateTimePickerNgayRa";
            this.dateTimePickerNgayRa.Size = new System.Drawing.Size(118, 23);
            this.dateTimePickerNgayRa.TabIndex = 7;
            // 
            // labelNgayRa
            // 
            this.labelNgayRa.AutoSize = true;
            this.labelNgayRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayRa.Location = new System.Drawing.Point(428, 37);
            this.labelNgayRa.Name = "labelNgayRa";
            this.labelNgayRa.Size = new System.Drawing.Size(62, 17);
            this.labelNgayRa.TabIndex = 6;
            this.labelNgayRa.Text = "Ngày ra:";
            // 
            // dateTimePickerNgayVao
            // 
            this.dateTimePickerNgayVao.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerNgayVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayVao.Location = new System.Drawing.Point(299, 34);
            this.dateTimePickerNgayVao.Name = "dateTimePickerNgayVao";
            this.dateTimePickerNgayVao.Size = new System.Drawing.Size(118, 23);
            this.dateTimePickerNgayVao.TabIndex = 5;
            // 
            // labelNgayVao
            // 
            this.labelNgayVao.AutoSize = true;
            this.labelNgayVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayVao.Location = new System.Drawing.Point(221, 37);
            this.labelNgayVao.Name = "labelNgayVao";
            this.labelNgayVao.Size = new System.Drawing.Size(72, 17);
            this.labelNgayVao.TabIndex = 4;
            this.labelNgayVao.Text = "Ngày vào:";
            // 
            // textBoxBaiDo
            // 
            this.textBoxBaiDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBaiDo.Location = new System.Drawing.Point(686, 32);
            this.textBoxBaiDo.Name = "textBoxBaiDo";
            this.textBoxBaiDo.Size = new System.Drawing.Size(119, 23);
            this.textBoxBaiDo.TabIndex = 3;
            // 
            // labelBaiDo
            // 
            this.labelBaiDo.AutoSize = true;
            this.labelBaiDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaiDo.Location = new System.Drawing.Point(628, 36);
            this.labelBaiDo.Name = "labelBaiDo";
            this.labelBaiDo.Size = new System.Drawing.Size(52, 17);
            this.labelBaiDo.TabIndex = 2;
            this.labelBaiDo.Text = "Bãi đổ:";
            // 
            // textBoxBienSoXe
            // 
            this.textBoxBienSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBienSoXe.Location = new System.Drawing.Point(94, 35);
            this.textBoxBienSoXe.Name = "textBoxBienSoXe";
            this.textBoxBienSoXe.Size = new System.Drawing.Size(119, 23);
            this.textBoxBienSoXe.TabIndex = 1;
            // 
            // labelBienSoXe
            // 
            this.labelBienSoXe.AutoSize = true;
            this.labelBienSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienSoXe.Location = new System.Drawing.Point(11, 37);
            this.labelBienSoXe.Name = "labelBienSoXe";
            this.labelBienSoXe.Size = new System.Drawing.Size(77, 17);
            this.labelBienSoXe.TabIndex = 0;
            this.labelBienSoXe.Text = "Biển số xe:";
            // 
            // labelSoXeVao
            // 
            this.labelSoXeVao.AutoSize = true;
            this.labelSoXeVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoXeVao.Location = new System.Drawing.Point(28, 301);
            this.labelSoXeVao.Name = "labelSoXeVao";
            this.labelSoXeVao.Size = new System.Drawing.Size(70, 17);
            this.labelSoXeVao.TabIndex = 4;
            this.labelSoXeVao.Text = "Sổ xe vào";
            // 
            // labelSoXeRa
            // 
            this.labelSoXeRa.AutoSize = true;
            this.labelSoXeRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoXeRa.Location = new System.Drawing.Point(474, 301);
            this.labelSoXeRa.Name = "labelSoXeRa";
            this.labelSoXeRa.Size = new System.Drawing.Size(60, 17);
            this.labelSoXeRa.TabIndex = 5;
            this.labelSoXeRa.Text = "Sổ xe ra";
            // 
            // FormSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 568);
            this.Controls.Add(this.labelSoXeRa);
            this.Controls.Add(this.labelSoXeVao);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.dataGridViewSoXeRa);
            this.Controls.Add(this.dataGridViewSoXeVao);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(889, 607);
            this.MinimumSize = new System.Drawing.Size(889, 607);
            this.Name = "FormSuCo";
            this.Text = "FormSuCo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMucBoiThuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMucBienBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMucKiemTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoXeVao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoXeRa)).EndInit();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMucBoiThuong;
        private System.Windows.Forms.PictureBox pictureBoxMucBoiThuong;
        private System.Windows.Forms.Label labelMucBienBan;
        private System.Windows.Forms.PictureBox pictureBoxMucBienBan;
        private System.Windows.Forms.Label labelMucKiemTra;
        private System.Windows.Forms.PictureBox pictureBoxMucKiemTra;
        private System.Windows.Forms.DataGridView dataGridViewSoXeVao;
        private System.Windows.Forms.DataGridView dataGridViewSoXeRa;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayVao;
        private System.Windows.Forms.Label labelNgayVao;
        private System.Windows.Forms.TextBox textBoxBaiDo;
        private System.Windows.Forms.Label labelBaiDo;
        private System.Windows.Forms.TextBox textBoxBienSoXe;
        private System.Windows.Forms.Label labelBienSoXe;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayRa;
        private System.Windows.Forms.Label labelNgayRa;
        private System.Windows.Forms.Label labelSoXeVao;
        private System.Windows.Forms.Label labelSoXeRa;
        private System.Windows.Forms.Button buttonTimKiem;
    }
}