namespace OtelRezervasyon.UI
{
    partial class FrmMusteriKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriKayit));
            this.flRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMusteriBilgiler = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKral = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbMusteriBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // flRooms
            // 
            this.flRooms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flRooms.Location = new System.Drawing.Point(40, 35);
            this.flRooms.Name = "flRooms";
            this.flRooms.Size = new System.Drawing.Size(498, 405);
            this.flRooms.TabIndex = 0;
            // 
            // gbMusteriBilgiler
            // 
            this.gbMusteriBilgiler.Controls.Add(this.btnKaydet);
            this.gbMusteriBilgiler.Controls.Add(this.dateTimePicker1);
            this.gbMusteriBilgiler.Controls.Add(this.label6);
            this.gbMusteriBilgiler.Controls.Add(this.txtTel);
            this.gbMusteriBilgiler.Controls.Add(this.txtTC);
            this.gbMusteriBilgiler.Controls.Add(this.txtMusteriAd);
            this.gbMusteriBilgiler.Controls.Add(this.label3);
            this.gbMusteriBilgiler.Controls.Add(this.label2);
            this.gbMusteriBilgiler.Controls.Add(this.label1);
            this.gbMusteriBilgiler.Enabled = false;
            this.gbMusteriBilgiler.Location = new System.Drawing.Point(639, 35);
            this.gbMusteriBilgiler.Name = "gbMusteriBilgiler";
            this.gbMusteriBilgiler.Size = new System.Drawing.Size(354, 405);
            this.gbMusteriBilgiler.TabIndex = 1;
            this.gbMusteriBilgiler.TabStop = false;
            this.gbMusteriBilgiler.Text = "Müşteri Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(157, 330);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 37);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giriş Tarihi";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(122, 198);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 20);
            this.txtTel.TabIndex = 6;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(122, 164);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 20);
            this.txtTC.TabIndex = 5;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(122, 133);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(200, 20);
            this.txtMusteriAd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(777, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // btnKral
            // 
            this.btnKral.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKral.BackgroundImage")));
            this.btnKral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKral.Location = new System.Drawing.Point(232, 307);
            this.btnKral.Name = "btnKral";
            this.btnKral.Size = new System.Drawing.Size(83, 95);
            this.btnKral.TabIndex = 5;
            this.btnKral.UseVisualStyleBackColor = false;
            this.btnKral.Click += new System.EventHandler(this.btnKral_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Müşteri Çıkışını Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbMusteriBilgiler);
            this.Controls.Add(this.btnKral);
            this.Controls.Add(this.flRooms);
            this.Name = "FrmMusteriKayit";
            this.Text = "FrmMusteriKayit";
            this.Load += new System.EventHandler(this.FrmMusteriKayit_Load);
            this.gbMusteriBilgiler.ResumeLayout(false);
            this.gbMusteriBilgiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flRooms;
        private System.Windows.Forms.GroupBox gbMusteriBilgiler;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}