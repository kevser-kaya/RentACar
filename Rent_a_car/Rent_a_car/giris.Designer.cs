namespace Rent_a_car
{
    partial class giris
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageIndex = 1;
            button1.ImageList = ımageList1;
            button1.Location = new Point(3, 49);
            button1.Name = "button1";
            button1.Size = new Size(136, 116);
            button1.TabIndex = 0;
            button1.Text = "Müşteri Paneli";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "setting_7542190.png");
            ımageList1.Images.SetKeyName(1, "group_6796240.png");
            // 
            // button2
            // 
            button2.ImageIndex = 0;
            button2.ImageList = ımageList1;
            button2.Location = new Point(3, 185);
            button2.Name = "button2";
            button2.Size = new Size(136, 123);
            button2.TabIndex = 1;
            button2.Text = "Yönetim Paneli";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(172, -7);
            label1.Name = "label1";
            label1.Size = new Size(320, 67);
            label1.TabIndex = 2;
            label1.Text = "RENT A CAR";
            label1.Click += label1_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(655, 355);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Sayfası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ImageList ımageList1;
        private Label label1;
    }
}