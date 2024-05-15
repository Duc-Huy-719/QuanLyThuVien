namespace WindowsFormsApplication1
{
    partial class Formtacgia
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
            this.txttentacgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatacgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.luu.Location = new System.Drawing.Point(302, 213);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(88, 41);
            this.luu.TabIndex = 21;
            this.luu.Text = "Lưu";
            this.luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.White;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Image = global::WindowsFormsApplication1.Properties.Resources.logo_close;
            this.thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat.Location = new System.Drawing.Point(302, 272);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(88, 41);
            this.thoat.TabIndex = 20;
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
            this.xoa.Location = new System.Drawing.Point(303, 158);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(87, 39);
            this.xoa.TabIndex = 19;
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
            this.sua.Location = new System.Drawing.Point(303, 102);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(87, 41);
            this.sua.TabIndex = 18;
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
            this.them.Location = new System.Drawing.Point(303, 56);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(87, 40);
            this.them.TabIndex = 17;
            this.them.Text = "Thêm";
            this.them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // txttentacgia
            // 
            this.txttentacgia.Location = new System.Drawing.Point(130, 110);
            this.txttentacgia.Name = "txttentacgia";
            this.txttentacgia.Size = new System.Drawing.Size(130, 20);
            this.txttentacgia.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ và tên";
            // 
            // txtmatacgia
            // 
            this.txtmatacgia.Location = new System.Drawing.Point(130, 66);
            this.txtmatacgia.Name = "txtmatacgia";
            this.txtmatacgia.Size = new System.Drawing.Size(130, 20);
            this.txtmatacgia.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã tác giả";
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(5, 158);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(291, 189);
            this.luoi.TabIndex = 11;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(111, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "CẬP NHẬT TÁC GIẢ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::WindowsFormsApplication1.Properties.Resources._1428theme_anh_sang_danh_cho_dien_thoai;
            this.label1.Location = new System.Drawing.Point(17, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "CẬP NHẬT THỂ LOẠI SÁCH";
            // 
            // Formtacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txttentacgia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmatacgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luoi);
            this.Name = "Formtacgia";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
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
        private System.Windows.Forms.TextBox txttentacgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatacgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Label label4;
    }
}