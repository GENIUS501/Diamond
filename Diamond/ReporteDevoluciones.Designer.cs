﻿namespace Diamond
{
    partial class ReporteDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteDevoluciones));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.txt_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.txt_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnumerofactura = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 142);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 274);
            this.reportViewer1.TabIndex = 112;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::Diamond.Properties.Resources.WhatsApp_Image_2023_11_03_at_6_42_26_PM;
            this.pictureBox1.Location = new System.Drawing.Point(542, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_fecha);
            this.groupBox1.Controls.Add(this.txt_fecha_fin);
            this.groupBox1.Controls.Add(this.txt_fecha_ini);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtnumerofactura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 97);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(291, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 20);
            this.button2.TabIndex = 62;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_fecha
            // 
            this.btn_fecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fecha.BackgroundImage")));
            this.btn_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fecha.Location = new System.Drawing.Point(465, 54);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(25, 20);
            this.btn_fecha.TabIndex = 61;
            this.btn_fecha.UseVisualStyleBackColor = true;
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_fin.Location = new System.Drawing.Point(338, 51);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Size = new System.Drawing.Size(121, 22);
            this.txt_fecha_fin.TabIndex = 58;
            // 
            // txt_fecha_ini
            // 
            this.txt_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_ini.Location = new System.Drawing.Point(185, 52);
            this.txt_fecha_ini.Name = "txt_fecha_ini";
            this.txt_fecha_ini.Size = new System.Drawing.Size(100, 22);
            this.txt_fecha_ini.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(349, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(182, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Fecha inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Numero de factura";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(128, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtnumerofactura
            // 
            this.txtnumerofactura.Location = new System.Drawing.Point(9, 49);
            this.txtnumerofactura.Mask = "0000000000";
            this.txtnumerofactura.Name = "txtnumerofactura";
            this.txtnumerofactura.Size = new System.Drawing.Size(113, 22);
            this.txtnumerofactura.TabIndex = 49;
            // 
            // ReporteDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteDevoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_fecha;
        private System.Windows.Forms.DateTimePicker txt_fecha_fin;
        private System.Windows.Forms.DateTimePicker txt_fecha_ini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtnumerofactura;
        private System.Windows.Forms.Button button2;
    }
}