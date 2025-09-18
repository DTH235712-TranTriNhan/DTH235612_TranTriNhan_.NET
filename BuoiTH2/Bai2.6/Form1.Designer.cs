namespace Bai2._6
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
            this.btTong = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThuong = new System.Windows.Forms.Button();
            this.btTich = new System.Windows.Forms.Button();
            this.btHieu = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phép Toán";
            // 
            // btTong
            // 
            this.btTong.Location = new System.Drawing.Point(57, 323);
            this.btTong.Name = "btTong";
            this.btTong.Size = new System.Drawing.Size(154, 93);
            this.btTong.TabIndex = 13;
            this.btTong.Text = "Tổng";
            this.btTong.UseVisualStyleBackColor = true;
            this.btTong.Click += new System.EventHandler(this.btTong_Click);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(305, 240);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(155, 22);
            this.tbB.TabIndex = 12;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(305, 192);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(155, 22);
            this.tbA.TabIndex = 11;
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(272, 240);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(22, 16);
            this.lbB.TabIndex = 10;
            this.lbB.Text = "B: ";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(272, 198);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(22, 16);
            this.lbA.TabIndex = 9;
            this.lbA.Text = "A: ";
            this.lbA.Click += new System.EventHandler(this.lbA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin";
            // 
            // btThuong
            // 
            this.btThuong.Location = new System.Drawing.Point(606, 323);
            this.btThuong.Name = "btThuong";
            this.btThuong.Size = new System.Drawing.Size(154, 93);
            this.btThuong.TabIndex = 14;
            this.btThuong.Text = "Thương";
            this.btThuong.UseVisualStyleBackColor = true;
            this.btThuong.Click += new System.EventHandler(this.btThuong_Click);
            // 
            // btTich
            // 
            this.btTich.Location = new System.Drawing.Point(416, 323);
            this.btTich.Name = "btTich";
            this.btTich.Size = new System.Drawing.Size(154, 93);
            this.btTich.TabIndex = 15;
            this.btTich.Text = "Tích";
            this.btTich.UseVisualStyleBackColor = true;
            this.btTich.Click += new System.EventHandler(this.btTich_Click);
            // 
            // btHieu
            // 
            this.btHieu.Location = new System.Drawing.Point(235, 323);
            this.btHieu.Name = "btHieu";
            this.btHieu.Size = new System.Drawing.Size(154, 93);
            this.btHieu.TabIndex = 16;
            this.btHieu.Text = "Hiệu";
            this.btHieu.UseVisualStyleBackColor = true;
            this.btHieu.Click += new System.EventHandler(this.btHieu_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(241, 280);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(58, 16);
            this.lbKetQua.TabIndex = 17;
            this.lbKetQua.Text = "Kết quả: ";
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(305, 274);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(155, 22);
            this.tbKetQua.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btHieu);
            this.Controls.Add(this.btTich);
            this.Controls.Add(this.btThuong);
            this.Controls.Add(this.btTong);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "bai2.6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTong;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThuong;
        private System.Windows.Forms.Button btTich;
        private System.Windows.Forms.Button btHieu;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox tbKetQua;
    }
}

