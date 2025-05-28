namespace Rent_a_car
{
    partial class frmAraçKayıt
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
            Plakatxt = new TextBox();
            Yiltxt = new TextBox();
            Renktxt = new TextBox();
            Markacombo = new ComboBox();
            Sericombo = new ComboBox();
            Yakitcombo = new ComboBox();
            Kmtxt = new TextBox();
            Ücrettxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            btnResim = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Plakatxt
            // 
            Plakatxt.Location = new Point(126, 22);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new Size(125, 27);
            Plakatxt.TabIndex = 0;
            // 
            // Yiltxt
            // 
            Yiltxt.Location = new Point(126, 165);
            Yiltxt.Name = "Yiltxt";
            Yiltxt.Size = new Size(125, 27);
            Yiltxt.TabIndex = 1;
            // 
            // Renktxt
            // 
            Renktxt.Location = new Point(126, 212);
            Renktxt.Name = "Renktxt";
            Renktxt.Size = new Size(125, 27);
            Renktxt.TabIndex = 2;
            // 
            // Markacombo
            // 
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "Opel", "Renault", "Fiat", "Ford" });
            Markacombo.Location = new Point(126, 69);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new Size(125, 28);
            Markacombo.TabIndex = 3;
            Markacombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Sericombo
            // 
            Sericombo.FormattingEnabled = true;
            Sericombo.Location = new Point(126, 117);
            Sericombo.Name = "Sericombo";
            Sericombo.Size = new Size(125, 28);
            Sericombo.TabIndex = 4;
            // 
            // Yakitcombo
            // 
            Yakitcombo.FormattingEnabled = true;
            Yakitcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakitcombo.Location = new Point(126, 306);
            Yakitcombo.Name = "Yakitcombo";
            Yakitcombo.Size = new Size(125, 28);
            Yakitcombo.TabIndex = 5;
            // 
            // Kmtxt
            // 
            Kmtxt.Location = new Point(126, 259);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new Size(125, 27);
            Kmtxt.TabIndex = 6;
            // 
            // Ücrettxt
            // 
            Ücrettxt.Location = new Point(126, 354);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new Size(125, 27);
            Ücrettxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 25);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 8;
            label1.Text = "Plaka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 121);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 10;
            label3.Text = "Seri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 168);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 11;
            label4.Text = "Model (Yıl)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 215);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "Renk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 262);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 13;
            label6.Text = "Km";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 310);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 14;
            label7.Text = "Yakıt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 357);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 15;
            label8.Text = "Kira Ücreti";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(311, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(90, 401);
            button1.Name = "button1";
            button1.Size = new Size(101, 37);
            button1.TabIndex = 17;
            button1.Text = "Kayıt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(241, 401);
            button2.Name = "button2";
            button2.Size = new Size(101, 37);
            button2.TabIndex = 18;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnResim
            // 
            btnResim.Location = new Point(376, 192);
            btnResim.Name = "btnResim";
            btnResim.Size = new Size(119, 43);
            btnResim.TabIndex = 19;
            btnResim.Text = "Resim Ekle";
            btnResim.UseVisualStyleBackColor = true;
            btnResim.Click += btnResim_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçKayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(575, 450);
            Controls.Add(btnResim);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "frmAraçKayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAraçKayıt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Plakatxt;
        private TextBox Yiltxt;
        private TextBox Renktxt;
        private ComboBox Markacombo;
        private ComboBox Sericombo;
        private ComboBox Yakitcombo;
        private TextBox Kmtxt;
        private TextBox Ücrettxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button btnResim;
        private OpenFileDialog openFileDialog1;
    }
}