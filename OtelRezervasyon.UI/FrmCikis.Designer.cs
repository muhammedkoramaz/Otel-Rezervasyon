namespace OtelRezervasyon.UI
{
    partial class FrmCikis
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
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAdSoyad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMiniDolap = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.lblBorc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flpAlinan = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(361, 401);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(75, 37);
            this.btnCikisYap.TabIndex = 15;
            this.btnCikisYap.Text = "Çıkışını Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbAdSoyad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBoxMiniDolap);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.dtpCikis);
            this.groupBox2.Controls.Add(this.lblBorc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(213, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 369);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Toplam Borç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alınanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mini Buzdolabı";
            // 
            // cmbAdSoyad
            // 
            this.cmbAdSoyad.FormattingEnabled = true;
            this.cmbAdSoyad.Location = new System.Drawing.Point(120, 80);
            this.cmbAdSoyad.Name = "cmbAdSoyad";
            this.cmbAdSoyad.Size = new System.Drawing.Size(121, 21);
            this.cmbAdSoyad.TabIndex = 15;
            this.cmbAdSoyad.SelectedIndexChanged += new System.EventHandler(this.cmbAdSoyad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad Soyad";
            // 
            // listBoxMiniDolap
            // 
            this.listBoxMiniDolap.FormattingEnabled = true;
            this.listBoxMiniDolap.Location = new System.Drawing.Point(6, 166);
            this.listBoxMiniDolap.Name = "listBoxMiniDolap";
            this.listBoxMiniDolap.Size = new System.Drawing.Size(144, 134);
            this.listBoxMiniDolap.TabIndex = 13;
            this.listBoxMiniDolap.SelectedIndexChanged += new System.EventHandler(this.listBoxMiniDolap_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(192, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 134);
            this.listBox1.TabIndex = 12;
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(120, 123);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(200, 20);
            this.dtpCikis.TabIndex = 10;
            // 
            // lblBorc
            // 
            this.lblBorc.AutoSize = true;
            this.lblBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorc.ForeColor = System.Drawing.Color.Red;
            this.lblBorc.Location = new System.Drawing.Point(145, 336);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(41, 13);
            this.lblBorc.TabIndex = 4;
            this.lblBorc.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Çıkış Tarihi";
            // 
            // flpAlinan
            // 
            this.flpAlinan.Location = new System.Drawing.Point(589, 176);
            this.flpAlinan.Name = "flpAlinan";
            this.flpAlinan.Size = new System.Drawing.Size(186, 219);
            this.flpAlinan.TabIndex = 16;
            // 
            // FrmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.flpAlinan);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmCikis";
            this.Text = "FrmCikis";
            this.Load += new System.EventHandler(this.FrmCikis_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxMiniDolap;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpAlinan;
    }
}