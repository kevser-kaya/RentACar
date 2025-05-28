namespace Rent_a_car
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.ImageIndex = 0;
            button1.ImageList = ımageList1;
            button1.Location = new Point(27, 12);
            button1.Name = "button1";
            button1.Size = new Size(111, 80);
            button1.TabIndex = 0;
            button1.Text = "Müşteri Ekle";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Kullanıcı ekle.png");
            ımageList1.Images.SetKeyName(1, "Araç ekle.png");
            ımageList1.Images.SetKeyName(2, "araç.png");
            ımageList1.Images.SetKeyName(3, "çıkış.png");
            ımageList1.Images.SetKeyName(4, "kiralamalar.png");
            ımageList1.Images.SetKeyName(5, "kullanıcı.png");
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.ImageIndex = 5;
            button2.ImageList = ımageList1;
            button2.Location = new Point(186, 12);
            button2.Name = "button2";
            button2.Size = new Size(111, 80);
            button2.TabIndex = 1;
            button2.Text = "Müşteriler";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.ImageIndex = 1;
            button3.ImageList = ımageList1;
            button3.Location = new Point(345, 12);
            button3.Name = "button3";
            button3.Size = new Size(111, 80);
            button3.TabIndex = 2;
            button3.Text = "Araç Ekle";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.ImageIndex = 2;
            button4.ImageList = ımageList1;
            button4.Location = new Point(504, 12);
            button4.Name = "button4";
            button4.Size = new Size(111, 80);
            button4.TabIndex = 3;
            button4.Text = "Araçlar";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.ImageIndex = 3;
            button6.ImageList = ımageList1;
            button6.Location = new Point(663, 12);
            button6.Name = "button6";
            button6.Size = new Size(111, 80);
            button6.TabIndex = 5;
            button6.Text = "Çıkış";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private ImageList ımageList1;
    }
}
