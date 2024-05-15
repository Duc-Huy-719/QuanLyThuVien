namespace WindowsFormsApplication1
{
    partial class Formnhaxb
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
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.txttennhaxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmanhaxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // luu
            // 
            this.luu.BackColor = System.Drawing.Color.White;
            this.luu.Enabled = false;
            this.luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu.Image = global::WindowsFormsApplication1.Properties.Resources.logo_save;
            this.luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.luu.Location = new System.Drawing.Point(405, 380);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(85, 38);
            this.luu.TabIndex = 31;
            this.luu.Text = "Lưu";
            this.luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.White;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Image = global::WindowsFormsApplication1.Properties.Resources.logo_edit;
            this.thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat.Location = new System.Drawing.Point(528, 380);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(85, 38);
            this.thoat.TabIndex = 30;
            this.thoat.Text = "Thoát";
            this.thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.White;
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Image = global::WindowsFormsApplication1.Properties.Resources.logo_Delete;
            this.xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa.Location = new System.Drawing.Point(277, 380);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(85, 38);
            this.xoa.TabIndex = 29;
            this.xoa.Text = "Xóa";
            this.xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.White;
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Image = global::WindowsFormsApplication1.Properties.Resources.logo_edit;
            this.sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua.Location = new System.Drawing.Point(162, 380);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(84, 38);
            this.sua.TabIndex = 28;
            this.sua.Text = "Sửa";
            this.sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.White;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Image = global::WindowsFormsApplication1.Properties.Resources.logo_Them;
            this.them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them.Location = new System.Drawing.Point(32, 380);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(84, 38);
            this.them.TabIndex = 27;
            this.them.Text = "Thêm";
            this.them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // txttennhaxb
            // 
            this.txttennhaxb.Location = new System.Drawing.Point(421, 84);
            this.txttennhaxb.Name = "txttennhaxb";
            this.txttennhaxb.Size = new System.Drawing.Size(145, 20);
            this.txttennhaxb.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(297, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên nhà XB";
            // 
            // txtmanhaxb
            // 
            this.txtmanhaxb.Location = new System.Drawing.Point(144, 84);
            this.txtmanhaxb.Name = "txtmanhaxb";
            this.txtmanhaxb.Size = new System.Drawing.Size(93, 20);
            this.txtmanhaxb.TabIndex = 24;
            this.txtmanhaxb.TextChanged += new System.EventHandler(this.txtmanhaxb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã nhà XB";
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(32, 179);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(534, 174);
            this.luoi.TabIndex = 22;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(224, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "CẬP NHẬT NHÀ XUẤT BẢN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(33, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(144, 140);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(206, 20);
            this.txtdiachi.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(388, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(456, 140);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(110, 20);
            this.txtphone.TabIndex = 36;
            // 
            // Formnhaxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txttennhaxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmanhaxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.luoi);
            this.Name = "Formnhaxb";
            this.Text = "Nhà xuất bản";
            this.Load += new System.EventHandler(this.Formnhaxb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox txttennhaxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmanhaxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
    }
}