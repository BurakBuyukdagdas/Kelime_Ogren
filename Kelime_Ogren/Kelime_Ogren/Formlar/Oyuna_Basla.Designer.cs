namespace Kelime_Ogren.Formlar
{
    partial class Oyuna_Basla
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
            this.btn_kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_dosyasec = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_karisik = new System.Windows.Forms.RadioButton();
            this.rbtn_ingilizce = new System.Windows.Forms.RadioButton();
            this.rbtn_turkce = new System.Windows.Forms.RadioButton();
            this.btn_oyunabasla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kapat.BackColor = System.Drawing.Color.DarkRed;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_kapat.Location = new System.Drawing.Point(631, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(44, 37);
            this.btn_kapat.TabIndex = 3;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.Btn_kapat_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oyuna Başlamak İçin Önce Dosya Seçip Ekleye Basınız.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "DOSYA SEÇ";
            // 
            // btn_dosyasec
            // 
            this.btn_dosyasec.BackColor = System.Drawing.Color.Silver;
            this.btn_dosyasec.ForeColor = System.Drawing.Color.Black;
            this.btn_dosyasec.Location = new System.Drawing.Point(18, 115);
            this.btn_dosyasec.Name = "btn_dosyasec";
            this.btn_dosyasec.Size = new System.Drawing.Size(330, 50);
            this.btn_dosyasec.TabIndex = 9;
            this.btn_dosyasec.UseVisualStyleBackColor = false;
            this.btn_dosyasec.Click += new System.EventHandler(this.Btn_dosyasec_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Silver;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_ekle.Location = new System.Drawing.Point(365, 115);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(106, 50);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtn_karisik);
            this.groupBox1.Controls.Add(this.rbtn_ingilizce);
            this.groupBox1.Controls.Add(this.rbtn_turkce);
            this.groupBox1.Location = new System.Drawing.Point(27, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SORU DİLİ";
            // 
            // rbtn_karisik
            // 
            this.rbtn_karisik.AutoSize = true;
            this.rbtn_karisik.Location = new System.Drawing.Point(6, 93);
            this.rbtn_karisik.Name = "rbtn_karisik";
            this.rbtn_karisik.Size = new System.Drawing.Size(85, 23);
            this.rbtn_karisik.TabIndex = 2;
            this.rbtn_karisik.TabStop = true;
            this.rbtn_karisik.Text = "KARIŞIK";
            this.rbtn_karisik.UseVisualStyleBackColor = true;
            // 
            // rbtn_ingilizce
            // 
            this.rbtn_ingilizce.AutoSize = true;
            this.rbtn_ingilizce.Location = new System.Drawing.Point(6, 64);
            this.rbtn_ingilizce.Name = "rbtn_ingilizce";
            this.rbtn_ingilizce.Size = new System.Drawing.Size(99, 23);
            this.rbtn_ingilizce.TabIndex = 1;
            this.rbtn_ingilizce.TabStop = true;
            this.rbtn_ingilizce.Text = "İNGİLİZCE";
            this.rbtn_ingilizce.UseVisualStyleBackColor = true;
            // 
            // rbtn_turkce
            // 
            this.rbtn_turkce.AutoSize = true;
            this.rbtn_turkce.Location = new System.Drawing.Point(6, 35);
            this.rbtn_turkce.Name = "rbtn_turkce";
            this.rbtn_turkce.Size = new System.Drawing.Size(83, 23);
            this.rbtn_turkce.TabIndex = 0;
            this.rbtn_turkce.TabStop = true;
            this.rbtn_turkce.Text = "TÜRKÇE";
            this.rbtn_turkce.UseVisualStyleBackColor = true;
            // 
            // btn_oyunabasla
            // 
            this.btn_oyunabasla.BackColor = System.Drawing.Color.Aqua;
            this.btn_oyunabasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oyunabasla.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyunabasla.ForeColor = System.Drawing.Color.Black;
            this.btn_oyunabasla.Location = new System.Drawing.Point(27, 333);
            this.btn_oyunabasla.Name = "btn_oyunabasla";
            this.btn_oyunabasla.Size = new System.Drawing.Size(321, 50);
            this.btn_oyunabasla.TabIndex = 12;
            this.btn_oyunabasla.Text = "OYUNA BAŞLA";
            this.btn_oyunabasla.UseVisualStyleBackColor = false;
            this.btn_oyunabasla.Click += new System.EventHandler(this.Btn_oyunabasla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "HAZIRLAYAN : BURAK BÜYÜKDAĞDAŞ";
            // 
            // Oyuna_Basla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(690, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_oyunabasla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_dosyasec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Oyuna_Basla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyuna_Basla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_dosyasec;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_karisik;
        private System.Windows.Forms.RadioButton rbtn_ingilizce;
        private System.Windows.Forms.RadioButton rbtn_turkce;
        private System.Windows.Forms.Button btn_oyunabasla;
        private System.Windows.Forms.Label label2;
    }
}