namespace Rent_a_car
{
    partial class frmAraçListele
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
            dataGridView1 = new DataGridView();
            comboAraçlar = new ComboBox();
            btnResim = new Button();
            btnİptal = new Button();
            btnGüncelle = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Ücrettxt = new TextBox();
            Kmtxt = new TextBox();
            Yakitcombo = new ComboBox();
            Sericombo = new ComboBox();
            Markacombo = new ComboBox();
            Renktxt = new TextBox();
            Yiltxt = new TextBox();
            Plakatxt = new TextBox();
            btnSil = new Button();
            openFileDialog1 = new OpenFileDialog();
            label9 = new Label();
            Durumcombo = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(664, 279);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // comboAraçlar
            // 
            comboAraçlar.FormattingEnabled = true;
            comboAraçlar.Items.AddRange(new object[] { "Tüm Araçlar", "Boş Araçlar", "Dolu Araçlar" });
            comboAraçlar.Location = new Point(715, 75);
            comboAraçlar.Name = "comboAraçlar";
            comboAraçlar.Size = new Size(151, 28);
            comboAraçlar.TabIndex = 1;
            comboAraçlar.SelectedIndexChanged += comboAraçlar_SelectedIndexChanged;
            // 
            // btnResim
            // 
            btnResim.Location = new Point(408, 41);
            btnResim.Name = "btnResim";
            btnResim.Size = new Size(32, 28);
            btnResim.TabIndex = 39;
            btnResim.Text = "...";
            btnResim.UseVisualStyleBackColor = true;
            btnResim.Click += btnResim_Click;
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(146, 449);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(101, 37);
            btnİptal.TabIndex = 38;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(39, 449);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(101, 37);
            btnGüncelle.TabIndex = 37;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(239, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 353);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 35;
            label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 306);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 34;
            label7.Text = "Yakıt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 258);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 33;
            label6.Text = "Km";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 32;
            label5.Text = "Renk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 31;
            label4.Text = "Model (Yıl)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 30;
            label3.Text = "Seri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 29;
            label2.Text = "Marka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 28;
            label1.Text = "Plaka";
            // 
            // Ücrettxt
            // 
            Ücrettxt.Location = new Point(92, 350);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new Size(125, 27);
            Ücrettxt.TabIndex = 27;
            // 
            // Kmtxt
            // 
            Kmtxt.Location = new Point(92, 255);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new Size(125, 27);
            Kmtxt.TabIndex = 26;
            // 
            // Yakitcombo
            // 
            Yakitcombo.FormattingEnabled = true;
            Yakitcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakitcombo.Location = new Point(92, 302);
            Yakitcombo.Name = "Yakitcombo";
            Yakitcombo.Size = new Size(125, 28);
            Yakitcombo.TabIndex = 25;
            // 
            // Sericombo
            // 
            Sericombo.FormattingEnabled = true;
            Sericombo.Location = new Point(92, 113);
            Sericombo.Name = "Sericombo";
            Sericombo.Size = new Size(125, 28);
            Sericombo.TabIndex = 24;
            // 
            // Markacombo
            // 
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "Opel", "Renault", "Fiat", "Ford" });
            Markacombo.Location = new Point(92, 65);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new Size(125, 28);
            Markacombo.TabIndex = 23;
            Markacombo.SelectedIndexChanged += Markacombo_SelectedIndexChanged;
            // 
            // Renktxt
            // 
            Renktxt.Location = new Point(92, 208);
            Renktxt.Name = "Renktxt";
            Renktxt.Size = new Size(125, 27);
            Renktxt.TabIndex = 22;
            // 
            // Yiltxt
            // 
            Yiltxt.Location = new Point(92, 161);
            Yiltxt.Name = "Yiltxt";
            Yiltxt.Size = new Size(125, 27);
            Yiltxt.TabIndex = 21;
            // 
            // Plakatxt
            // 
            Plakatxt.Location = new Point(92, 18);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new Size(125, 27);
            Plakatxt.TabIndex = 20;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(906, 117);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(54, 37);
            btnSil.TabIndex = 40;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 394);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 43;
            label9.Text = "Durumu";
            // 
            // Durumcombo
            // 
            Durumcombo.FormattingEnabled = true;
            Durumcombo.Items.AddRange(new object[] { "DOLU", "BOŞ" });
            Durumcombo.Location = new Point(92, 391);
            Durumcombo.Name = "Durumcombo";
            Durumcombo.Size = new Size(125, 28);
            Durumcombo.TabIndex = 44;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(583, 391);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 45;
            flowLayoutPanel1.WrapContents = false;
            // 
            // frmAraçListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(972, 517);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Durumcombo);
            Controls.Add(label9);
            Controls.Add(btnSil);
            Controls.Add(btnResim);
            Controls.Add(btnİptal);
            Controls.Add(btnGüncelle);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ücrettxt);
            Controls.Add(Kmtxt);
            Controls.Add(Yakitcombo);
            Controls.Add(Sericombo);
            Controls.Add(Markacombo);
            Controls.Add(Renktxt);
            Controls.Add(Yiltxt);
            Controls.Add(Plakatxt);
            Controls.Add(comboAraçlar);
            Controls.Add(dataGridView1);
            Name = "frmAraçListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAraçListele";
            Load += frmAraçListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboAraçlar;
        private Button btnResim;
        private Button btnİptal;
        private Button btnGüncelle;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Ücrettxt;
        private TextBox Kmtxt;
        private ComboBox Yakitcombo;
        private ComboBox Sericombo;
        private ComboBox Markacombo;
        private TextBox Renktxt;
        private TextBox Yiltxt;
        private TextBox Plakatxt;
        private Button btnSil;
        private OpenFileDialog openFileDialog1;
        private Label label9;
        private ComboBox Durumcombo;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}