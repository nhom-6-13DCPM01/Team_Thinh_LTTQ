﻿
namespace QuanLiGiuXe
{
    partial class FormLayoutNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLayoutNhanVien));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelDangXuat = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSuCo = new System.Windows.Forms.Button();
            this.buttonXeRa = new System.Windows.Forms.Button();
            this.buttonXeVao = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelTenTeam = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTrangCon = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.labelDangXuat);
            this.panelMenu.Controls.Add(this.tableLayoutPanel1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 607);
            this.panelMenu.TabIndex = 1;
            // 
            // labelDangXuat
            // 
            this.labelDangXuat.AutoSize = true;
            this.labelDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangXuat.Location = new System.Drawing.Point(50, 500);
            this.labelDangXuat.Name = "labelDangXuat";
            this.labelDangXuat.Size = new System.Drawing.Size(82, 20);
            this.labelDangXuat.TabIndex = 3;
            this.labelDangXuat.Text = "Đăng xuất";
            this.labelDangXuat.Click += new System.EventHandler(this.labelDangXuat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSuCo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonXeRa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonXeVao, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 305);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonSuCo
            // 
            this.buttonSuCo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonSuCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSuCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuCo.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonSuCo.Location = new System.Drawing.Point(5, 207);
            this.buttonSuCo.Name = "buttonSuCo";
            this.buttonSuCo.Size = new System.Drawing.Size(188, 93);
            this.buttonSuCo.TabIndex = 4;
            this.buttonSuCo.Text = "Sự cố";
            this.buttonSuCo.UseVisualStyleBackColor = false;
            this.buttonSuCo.Click += new System.EventHandler(this.buttonSuCo_Click);
            // 
            // buttonXeRa
            // 
            this.buttonXeRa.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonXeRa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonXeRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXeRa.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonXeRa.Location = new System.Drawing.Point(5, 106);
            this.buttonXeRa.Name = "buttonXeRa";
            this.buttonXeRa.Size = new System.Drawing.Size(188, 93);
            this.buttonXeRa.TabIndex = 3;
            this.buttonXeRa.Text = "Xe ra";
            this.buttonXeRa.UseVisualStyleBackColor = false;
            this.buttonXeRa.Click += new System.EventHandler(this.buttonXeRa_Click);
            // 
            // buttonXeVao
            // 
            this.buttonXeVao.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonXeVao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonXeVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXeVao.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonXeVao.Location = new System.Drawing.Point(5, 5);
            this.buttonXeVao.Name = "buttonXeVao";
            this.buttonXeVao.Size = new System.Drawing.Size(188, 93);
            this.buttonXeVao.TabIndex = 2;
            this.buttonXeVao.Text = "Xe vào";
            this.buttonXeVao.UseVisualStyleBackColor = false;
            this.buttonXeVao.Click += new System.EventHandler(this.buttonXeVao_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelTenTeam);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(198, 150);
            this.panelLogo.TabIndex = 1;
            // 
            // labelTenTeam
            // 
            this.labelTenTeam.AutoSize = true;
            this.labelTenTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTeam.Location = new System.Drawing.Point(38, 99);
            this.labelTenTeam.Name = "labelTenTeam";
            this.labelTenTeam.Size = new System.Drawing.Size(95, 25);
            this.labelTenTeam.TabIndex = 1;
            this.labelTenTeam.Text = "Tên team";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(198, 96);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTrangCon
            // 
            this.panelTrangCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrangCon.Location = new System.Drawing.Point(200, 0);
            this.panelTrangCon.Name = "panelTrangCon";
            this.panelTrangCon.Size = new System.Drawing.Size(889, 607);
            this.panelTrangCon.TabIndex = 2;
            // 
            // FormLayoutNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 607);
            this.Controls.Add(this.panelTrangCon);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormLayoutNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormLayoutNhanVien_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonXeRa;
        private System.Windows.Forms.Button buttonXeVao;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelTenTeam;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonSuCo;
        private System.Windows.Forms.Label labelDangXuat;
        private System.Windows.Forms.Panel panelTrangCon;
    }
}