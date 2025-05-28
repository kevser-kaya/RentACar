namespace Rent_a_car
{
    partial class KullaniciFormu
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
            btnListele = new Button();
            btnKirala = new Button();
            btnCikis = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnListele
            // 
            btnListele.Location = new Point(52, 40);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(158, 100);
            btnListele.TabIndex = 0;
            btnListele.Text = "Araçları Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnKirala
            // 
            btnKirala.Location = new Point(238, 40);
            btnKirala.Name = "btnKirala";
            btnKirala.Size = new Size(157, 100);
            btnKirala.TabIndex = 1;
            btnKirala.Text = "Araç Kirala";
            btnKirala.UseVisualStyleBackColor = true;
            btnKirala.Click += button2_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(419, 40);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(151, 100);
            btnCikis.TabIndex = 2;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(708, 259);
            dataGridView1.TabIndex = 3;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(590, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(181, 87);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // KullaniciFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnCikis);
            Controls.Add(btnKirala);
            Controls.Add(btnListele);
            Name = "KullaniciFormu";
            Text = "KullaniciFormu";
            Load += KullaniciFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnListele;
        private Button btnKirala;
        private Button btnCikis;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}