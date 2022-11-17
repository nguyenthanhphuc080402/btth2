namespace btth2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skinButton2 = new DotNetSkin.SkinControls.SkinButton();
            this.skinButton1 = new DotNetSkin.SkinControls.SkinButton();
            this.lab_sl = new System.Windows.Forms.Label();
            this.lab_discription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_price = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pic_1);
            this.panel1.Location = new System.Drawing.Point(26, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 512);
            this.panel1.TabIndex = 0;
            // 
            // pic_1
            // 
            this.pic_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_1.BackgroundImage")));
            this.pic_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_1.Location = new System.Drawing.Point(27, 28);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(488, 425);
            this.pic_1.TabIndex = 0;
            this.pic_1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_count);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.skinButton2);
            this.panel2.Controls.Add(this.skinButton1);
            this.panel2.Controls.Add(this.lab_sl);
            this.panel2.Controls.Add(this.lab_discription);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lab_price);
            this.panel2.Controls.Add(this.lab_name);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(601, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 601);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(377, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(521, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.Location = new System.Drawing.Point(24, 511);
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.Size = new System.Drawing.Size(193, 69);
            this.skinButton2.TabIndex = 14;
            this.skinButton2.Text = "Xem giỏ hàng";
            this.skinButton2.UseVisualStyleBackColor = true;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skinButton1.Location = new System.Drawing.Point(413, 511);
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.Size = new System.Drawing.Size(193, 69);
            this.skinButton1.TabIndex = 3;
            this.skinButton1.Text = "Thêm vào giỏ hàng";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // lab_sl
            // 
            this.lab_sl.AutoSize = true;
            this.lab_sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sl.Location = new System.Drawing.Point(454, 191);
            this.lab_sl.Name = "lab_sl";
            this.lab_sl.Size = new System.Drawing.Size(34, 37);
            this.lab_sl.TabIndex = 13;
            this.lab_sl.Text = "1";
            // 
            // lab_discription
            // 
            this.lab_discription.CausesValidation = false;
            this.lab_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_discription.ForeColor = System.Drawing.Color.Black;
            this.lab_discription.Location = new System.Drawing.Point(41, 314);
            this.lab_discription.Name = "lab_discription";
            this.lab_discription.Size = new System.Drawing.Size(565, 184);
            this.lab_discription.TabIndex = 12;
            this.lab_discription.Text = "Cà phê được pha phin truyền thống kết hợp với sữa đặc tạo nên hương vị đậm đà, hà" +
    "i hòa giữa vị ngọt đầu lưỡi và vị đắng thanh thoát nơi hậu vị.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_price
            // 
            this.lab_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_price.ForeColor = System.Drawing.Color.Black;
            this.lab_price.Location = new System.Drawing.Point(377, 122);
            this.lab_price.Name = "lab_price";
            this.lab_price.Size = new System.Drawing.Size(166, 39);
            this.lab_price.TabIndex = 4;
            this.lab_price.Text = "50.000đ";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_name.Location = new System.Drawing.Point(41, 28);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(317, 52);
            this.lab_name.TabIndex = 3;
            this.lab_name.Text = "Cà phê sữa đá";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_count.Location = new System.Drawing.Point(214, 489);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(40, 46);
            this.lbl_count.TabIndex = 17;
            this.lbl_count.Text = "4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_price;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_discription;
        private System.Windows.Forms.Label lab_sl;
        private DotNetSkin.SkinControls.SkinButton skinButton2;
        private DotNetSkin.SkinControls.SkinButton skinButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_count;
    }
}