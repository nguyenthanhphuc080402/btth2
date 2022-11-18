namespace btth2
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinButton1 = new DotNetSkin.SkinControls.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.skinRadioButton1 = new DotNetSkin.SkinControls.SkinRadioButton();
            this.skinRadioButton2 = new DotNetSkin.SkinControls.SkinRadioButton();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skinButton2 = new DotNetSkin.SkinControls.SkinButton();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new btth2.ds();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.form3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv.CausesValidation = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1234, 217);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên món";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(980, 432);
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.Size = new System.Drawing.Size(235, 69);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "Thanh Toán";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn hình thức thanh toán";
            // 
            // skinRadioButton1
            // 
            this.skinRadioButton1.AutoSize = true;
            this.skinRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinRadioButton1.Location = new System.Drawing.Point(333, 244);
            this.skinRadioButton1.Name = "skinRadioButton1";
            this.skinRadioButton1.Size = new System.Drawing.Size(259, 29);
            this.skinRadioButton1.TabIndex = 3;
            this.skinRadioButton1.TabStop = true;
            this.skinRadioButton1.Text = "Thanh toán bằng tiền mặt";
            this.skinRadioButton1.UseVisualStyleBackColor = false;
            // 
            // skinRadioButton2
            // 
            this.skinRadioButton2.AutoSize = true;
            this.skinRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinRadioButton2.Location = new System.Drawing.Point(613, 244);
            this.skinRadioButton2.Name = "skinRadioButton2";
            this.skinRadioButton2.Size = new System.Drawing.Size(227, 29);
            this.skinRadioButton2.TabIndex = 4;
            this.skinRadioButton2.TabStop = true;
            this.skinRadioButton2.Text = "Thanh toán trực tuyến";
            this.skinRadioButton2.UseVisualStyleBackColor = false;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(333, 310);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(507, 30);
            this.txt_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.Location = new System.Drawing.Point(1031, 265);
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.Size = new System.Drawing.Size(146, 51);
            this.skinButton2.TabIndex = 3;
            this.skinButton2.Text = "xóa";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dsBindingSource;
            // 
            // dsBindingSource
            // 
            this.dsBindingSource.DataSource = this.ds;
            this.dsBindingSource.Position = 0;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(333, 379);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(507, 30);
            this.txt_address.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ giao hàng:";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(333, 460);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(507, 30);
            this.txt_phone.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(867, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng tiền:";
            // 
            // lbl_tong
            // 
            this.lbl_tong.AutoSize = true;
            this.lbl_tong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tong.ForeColor = System.Drawing.Color.Red;
            this.lbl_tong.Location = new System.Drawing.Point(1036, 352);
            this.lbl_tong.Name = "lbl_tong";
            this.lbl_tong.Size = new System.Drawing.Size(31, 32);
            this.lbl_tong.TabIndex = 12;
            this.lbl_tong.Text = "0";
            // 
            // form3BindingSource
            // 
            this.form3BindingSource.DataSource = typeof(btth2.Form3);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.lbl_tong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.skinRadioButton2);
            this.Controls.Add(this.skinRadioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DotNetSkin.SkinControls.SkinButton skinButton1;
        private System.Windows.Forms.Label label1;
        private DotNetSkin.SkinControls.SkinRadioButton skinRadioButton1;
        private DotNetSkin.SkinControls.SkinRadioButton skinRadioButton2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private DotNetSkin.SkinControls.SkinButton skinButton2;
        private ds ds;
        private System.Windows.Forms.BindingSource dsBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource form3BindingSource;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tong;
    }
}