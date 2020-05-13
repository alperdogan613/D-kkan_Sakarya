namespace Ndp_proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBoxforma = new System.Windows.Forms.ComboBox();
            this.comboBoxmama = new System.Windows.Forms.ComboBox();
            this.comboboxbilet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltutar = new System.Windows.Forms.Label();
            this.lblBilet = new System.Windows.Forms.Label();
            this.lblMama = new System.Windows.Forms.Label();
            this.lblForma = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.LblBaslik = new System.Windows.Forms.Label();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timerzamanlayici = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürünler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(328, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(619, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 225);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // comboBoxforma
            // 
            this.comboBoxforma.FormattingEnabled = true;
            this.comboBoxforma.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxforma.Location = new System.Drawing.Point(90, 516);
            this.comboBoxforma.Name = "comboBoxforma";
            this.comboBoxforma.Size = new System.Drawing.Size(121, 28);
            this.comboBoxforma.TabIndex = 7;
            this.comboBoxforma.Text = "0";
            this.comboBoxforma.SelectedIndexChanged += new System.EventHandler(this.comboBoxforma_SelectedIndexChanged);
            this.comboBoxforma.FormatStringChanged += new System.EventHandler(this.comboBoxforma_FormatStringChanged);
            // 
            // comboBoxmama
            // 
            this.comboBoxmama.FormattingEnabled = true;
            this.comboBoxmama.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxmama.Location = new System.Drawing.Point(378, 516);
            this.comboBoxmama.Name = "comboBoxmama";
            this.comboBoxmama.Size = new System.Drawing.Size(121, 28);
            this.comboBoxmama.TabIndex = 8;
            this.comboBoxmama.Text = "0";
            this.comboBoxmama.SelectedIndexChanged += new System.EventHandler(this.comboBoxmama_SelectedIndexChanged);
            // 
            // comboboxbilet
            // 
            this.comboboxbilet.FormattingEnabled = true;
            this.comboboxbilet.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboboxbilet.Location = new System.Drawing.Point(688, 516);
            this.comboboxbilet.Name = "comboboxbilet";
            this.comboboxbilet.Size = new System.Drawing.Size(121, 28);
            this.comboboxbilet.TabIndex = 9;
            this.comboboxbilet.Text = "0";
            this.comboboxbilet.SelectedIndexChanged += new System.EventHandler(this.comboboxbilet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(125, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Forma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Köpek Maması (Bağış-kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(695, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maç Bileti";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbltutar);
            this.groupBox1.Controls.Add(this.lblBilet);
            this.groupBox1.Controls.Add(this.lblMama);
            this.groupBox1.Controls.Add(this.lblForma);
            this.groupBox1.Location = new System.Drawing.Point(993, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 217);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sepetim";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tutar";
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Location = new System.Drawing.Point(58, 176);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(40, 20);
            this.lbltutar.TabIndex = 16;
            this.lbltutar.Text = "0 TL";
            // 
            // lblBilet
            // 
            this.lblBilet.AutoSize = true;
            this.lblBilet.Location = new System.Drawing.Point(6, 130);
            this.lblBilet.Name = "lblBilet";
            this.lblBilet.Size = new System.Drawing.Size(90, 20);
            this.lblBilet.TabIndex = 16;
            this.lblBilet.Text = "0 Maç Bileti";
            // 
            // lblMama
            // 
            this.lblMama.AutoSize = true;
            this.lblMama.Location = new System.Drawing.Point(6, 82);
            this.lblMama.Name = "lblMama";
            this.lblMama.Size = new System.Drawing.Size(147, 20);
            this.lblMama.TabIndex = 15;
            this.lblMama.Text = "0 kg Köpek Maması";
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(6, 41);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(68, 20);
            this.lblForma.TabIndex = 14;
            this.lblForma.Text = "0 Forma";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1003, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 68);
            this.button2.TabIndex = 14;
            this.button2.Text = "Siparişi Tamamla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblBaslik
            // 
            this.LblBaslik.AutoSize = true;
            this.LblBaslik.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBaslik.Location = new System.Drawing.Point(432, 42);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(198, 33);
            this.LblBaslik.TabIndex = 15;
            this.LblBaslik.Text = "Dükkan Sakarya";
            // 
            // btnForm3
            // 
            this.btnForm3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnForm3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForm3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForm3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnForm3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnForm3.Location = new System.Drawing.Point(993, 126);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(177, 68);
            this.btnForm3.TabIndex = 16;
            this.btnForm3.Text = "Siparişler";
            this.btnForm3.UseVisualStyleBackColor = false;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "Xl"});
            this.comboBox1.Location = new System.Drawing.Point(90, 550);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "54";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(716, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "₺";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "₺";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(750, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "₺";
            // 
            // timerzamanlayici
            // 
            this.timerzamanlayici.Tick += new System.EventHandler(this.timerzamanlayici_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 710);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.LblBaslik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxbilet);
            this.Controls.Add(this.comboBoxmama);
            this.Controls.Add(this.comboBoxforma);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBoxforma;
        private System.Windows.Forms.ComboBox comboBoxmama;
        private System.Windows.Forms.ComboBox comboboxbilet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBilet;
        private System.Windows.Forms.Label lblMama;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblBaslik;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnForm3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timerzamanlayici;
    }
}

