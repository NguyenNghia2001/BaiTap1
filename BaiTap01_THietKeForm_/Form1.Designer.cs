namespace BaiTap01_THietKeForm_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapMonAn = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSangPhai_n = new System.Windows.Forms.Button();
            this.btnSangPhai_All = new System.Windows.Forms.Button();
            this.btnSangTrai_n = new System.Windows.Forms.Button();
            this.btnSangTrai_All = new System.Windows.Forms.Button();
            this.lstThucDon = new System.Windows.Forms.ListBox();
            this.lstMonAn = new System.Windows.Forms.ListBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ẩm Thực Nghệ An ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Món Ăn";
            // 
            // txtNhapMonAn
            // 
            this.txtNhapMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNhapMonAn.Location = new System.Drawing.Point(106, 62);
            this.txtNhapMonAn.Name = "txtNhapMonAn";
            this.txtNhapMonAn.Size = new System.Drawing.Size(216, 22);
            this.txtNhapMonAn.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(328, 62);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(88, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstThucDon);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(6, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 219);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thực Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMonAn);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(251, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 215);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chọn Món Ăn";
            // 
            // btnSangPhai_n
            // 
            this.btnSangPhai_n.Location = new System.Drawing.Point(188, 121);
            this.btnSangPhai_n.Name = "btnSangPhai_n";
            this.btnSangPhai_n.Size = new System.Drawing.Size(57, 23);
            this.btnSangPhai_n.TabIndex = 6;
            this.btnSangPhai_n.Text = ">";
            this.btnSangPhai_n.UseVisualStyleBackColor = true;
            this.btnSangPhai_n.Click += new System.EventHandler(this.btnSangPhai_n_Click);
            // 
            // btnSangPhai_All
            // 
            this.btnSangPhai_All.Location = new System.Drawing.Point(188, 150);
            this.btnSangPhai_All.Name = "btnSangPhai_All";
            this.btnSangPhai_All.Size = new System.Drawing.Size(57, 23);
            this.btnSangPhai_All.TabIndex = 7;
            this.btnSangPhai_All.Text = ">>";
            this.btnSangPhai_All.UseVisualStyleBackColor = true;
            this.btnSangPhai_All.Click += new System.EventHandler(this.btnSangPhai_All_Click);
            // 
            // btnSangTrai_n
            // 
            this.btnSangTrai_n.Location = new System.Drawing.Point(188, 225);
            this.btnSangTrai_n.Name = "btnSangTrai_n";
            this.btnSangTrai_n.Size = new System.Drawing.Size(57, 23);
            this.btnSangTrai_n.TabIndex = 8;
            this.btnSangTrai_n.Text = "<";
            this.btnSangTrai_n.UseVisualStyleBackColor = true;
            this.btnSangTrai_n.Click += new System.EventHandler(this.btnSangTrai_n_Click);
            // 
            // btnSangTrai_All
            // 
            this.btnSangTrai_All.Location = new System.Drawing.Point(188, 254);
            this.btnSangTrai_All.Name = "btnSangTrai_All";
            this.btnSangTrai_All.Size = new System.Drawing.Size(57, 23);
            this.btnSangTrai_All.TabIndex = 9;
            this.btnSangTrai_All.Text = "<<";
            this.btnSangTrai_All.UseVisualStyleBackColor = true;
            this.btnSangTrai_All.Click += new System.EventHandler(this.btnSangTrai_All_Click);
            // 
            // lstThucDon
            // 
            this.lstThucDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstThucDon.FormattingEnabled = true;
            this.lstThucDon.ItemHeight = 16;
            this.lstThucDon.Location = new System.Drawing.Point(7, 22);
            this.lstThucDon.Name = "lstThucDon";
            this.lstThucDon.Size = new System.Drawing.Size(163, 196);
            this.lstThucDon.TabIndex = 0;
            // 
            // lstMonAn
            // 
            this.lstMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstMonAn.FormattingEnabled = true;
            this.lstMonAn.ItemHeight = 16;
            this.lstMonAn.Location = new System.Drawing.Point(6, 19);
            this.lstMonAn.Name = "lstMonAn";
            this.lstMonAn.Size = new System.Drawing.Size(169, 196);
            this.lstMonAn.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnthoat.Location = new System.Drawing.Point(188, 287);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(57, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "EXIT";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(443, 322);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnSangTrai_All);
            this.Controls.Add(this.btnSangTrai_n);
            this.Controls.Add(this.btnSangPhai_All);
            this.Controls.Add(this.btnSangPhai_n);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhapMonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực Đơn Món Ăn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapMonAn;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstThucDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstMonAn;
        private System.Windows.Forms.Button btnSangPhai_n;
        private System.Windows.Forms.Button btnSangPhai_All;
        private System.Windows.Forms.Button btnSangTrai_n;
        private System.Windows.Forms.Button btnSangTrai_All;
        private System.Windows.Forms.Button btnthoat;
    }
}

