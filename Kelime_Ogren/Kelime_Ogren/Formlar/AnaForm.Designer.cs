namespace Kelime_Ogren.Formlar
{
    partial class AnaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.txt_cevap = new System.Windows.Forms.TextBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.btn_digersoru = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blb_dogrusayisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_yanlissayisi = new System.Windows.Forms.Label();
            this.btn_basla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Cambria", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "          Kelime Öğrenmek Artık Çok Kolay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kapat.BackColor = System.Drawing.Color.DarkRed;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_kapat.Location = new System.Drawing.Point(634, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(44, 37);
            this.btn_kapat.TabIndex = 1;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.Btn_kapat_Click);
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.BackColor = System.Drawing.Color.Tan;
            this.lbl_kelime.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelime.Location = new System.Drawing.Point(25, 110);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(629, 61);
            this.lbl_kelime.TabIndex = 2;
            this.lbl_kelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cevap
            // 
            this.txt_cevap.BackColor = System.Drawing.Color.Tan;
            this.txt_cevap.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cevap.Location = new System.Drawing.Point(25, 185);
            this.txt_cevap.Multiline = true;
            this.txt_cevap.Name = "txt_cevap";
            this.txt_cevap.Size = new System.Drawing.Size(499, 43);
            this.txt_cevap.TabIndex = 3;
            this.txt_cevap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.Color.Silver;
            this.btn_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onayla.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onayla.Location = new System.Drawing.Point(548, 186);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(106, 42);
            this.btn_onayla.TabIndex = 4;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // btn_digersoru
            // 
            this.btn_digersoru.BackColor = System.Drawing.Color.Silver;
            this.btn_digersoru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_digersoru.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_digersoru.Location = new System.Drawing.Point(239, 251);
            this.btn_digersoru.Name = "btn_digersoru";
            this.btn_digersoru.Size = new System.Drawing.Size(233, 42);
            this.btn_digersoru.TabIndex = 5;
            this.btn_digersoru.Text = "Diğer Soruya Geç";
            this.btn_digersoru.UseVisualStyleBackColor = false;
            this.btn_digersoru.Click += new System.EventHandler(this.btn_digersoru_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Cambria", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(690, 61);
            this.label3.TabIndex = 6;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOĞRU :";
            // 
            // blb_dogrusayisi
            // 
            this.blb_dogrusayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blb_dogrusayisi.AutoSize = true;
            this.blb_dogrusayisi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blb_dogrusayisi.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blb_dogrusayisi.ForeColor = System.Drawing.Color.White;
            this.blb_dogrusayisi.Location = new System.Drawing.Point(135, 357);
            this.blb_dogrusayisi.Name = "blb_dogrusayisi";
            this.blb_dogrusayisi.Size = new System.Drawing.Size(29, 32);
            this.blb_dogrusayisi.TabIndex = 8;
            this.blb_dogrusayisi.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(201, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "YANLIŞ :";
            // 
            // lbl_yanlissayisi
            // 
            this.lbl_yanlissayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_yanlissayisi.AutoSize = true;
            this.lbl_yanlissayisi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_yanlissayisi.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yanlissayisi.ForeColor = System.Drawing.Color.White;
            this.lbl_yanlissayisi.Location = new System.Drawing.Point(307, 357);
            this.lbl_yanlissayisi.Name = "lbl_yanlissayisi";
            this.lbl_yanlissayisi.Size = new System.Drawing.Size(29, 32);
            this.lbl_yanlissayisi.TabIndex = 10;
            this.lbl_yanlissayisi.Text = "0";
            // 
            // btn_basla
            // 
            this.btn_basla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_basla.BackColor = System.Drawing.Color.Aqua;
            this.btn_basla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basla.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.Location = new System.Drawing.Point(548, 352);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(106, 42);
            this.btn_basla.TabIndex = 11;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.Btn_basla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "HAZIRLAYAN : BURAK BÜYÜKDAĞDAŞ";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(690, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.lbl_yanlissayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.blb_dogrusayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_digersoru);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.txt_cevap);
            this.Controls.Add(this.lbl_kelime);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.TextBox txt_cevap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label blb_dogrusayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_yanlissayisi;
        private System.Windows.Forms.Button btn_basla;
        public System.Windows.Forms.Label lbl_kelime;
        public System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.Button btn_digersoru;
        private System.Windows.Forms.Label label2;
    }
}