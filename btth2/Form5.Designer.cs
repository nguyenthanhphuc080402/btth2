namespace btth2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btn_fb = new DotNetSkin.SkinControls.SkinButton();
            this.btn_his = new DotNetSkin.SkinControls.SkinButton();
            this.SuspendLayout();
            // 
            // btn_fb
            // 
            this.btn_fb.BackColor = System.Drawing.Color.Transparent;
            this.btn_fb.Location = new System.Drawing.Point(695, 54);
            this.btn_fb.Name = "btn_fb";
            this.btn_fb.Size = new System.Drawing.Size(261, 53);
            this.btn_fb.TabIndex = 0;
            this.btn_fb.Text = "Đánh giá sản phẩm";
            this.btn_fb.UseVisualStyleBackColor = false;
            this.btn_fb.Click += new System.EventHandler(this.btn_fb_Click);
            // 
            // btn_his
            // 
            this.btn_his.BackColor = System.Drawing.Color.Transparent;
            this.btn_his.Location = new System.Drawing.Point(695, 175);
            this.btn_his.Name = "btn_his";
            this.btn_his.Size = new System.Drawing.Size(261, 53);
            this.btn_his.TabIndex = 1;
            this.btn_his.Text = "Xem lịch sử mua hàng";
            this.btn_his.UseVisualStyleBackColor = false;
            this.btn_his.Click += new System.EventHandler(this.btn_his_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.btn_his);
            this.Controls.Add(this.btn_fb);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.ResumeLayout(false);

        }

        #endregion

        private DotNetSkin.SkinControls.SkinButton btn_fb;
        private DotNetSkin.SkinControls.SkinButton btn_his;
    }
}