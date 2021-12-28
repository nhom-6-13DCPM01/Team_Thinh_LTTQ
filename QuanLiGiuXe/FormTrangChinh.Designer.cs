
namespace QuanLiGiuXe
{
    partial class FormTrangChinh
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.labelNam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 105);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(800, 345);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Location = new System.Drawing.Point(61, 29);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNam.TabIndex = 1;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Location = new System.Drawing.Point(23, 32);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(32, 13);
            this.labelNam.TabIndex = 2;
            this.labelNam.Text = "Năm:";
            // 
            // FormTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.chartDoanhThu);
            this.Name = "FormTrangChinh";
            this.Text = "FormTrangChinh";
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label labelNam;
    }
}