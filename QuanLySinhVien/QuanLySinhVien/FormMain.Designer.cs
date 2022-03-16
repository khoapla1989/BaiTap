namespace QuanLySinhVien
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(130, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap so a";
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(194, 90);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(100, 23);
            this.txtNhapA.TabIndex = 0;
            this.txtNhapA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(194, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giai Phuong Trinh Bac 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(194, 129);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(100, 23);
            this.txtNhapB.TabIndex = 1;
            this.txtNhapB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(130, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhap so b";
            // 
            // txtNhapC
            // 
            this.txtNhapC.Location = new System.Drawing.Point(194, 169);
            this.txtNhapC.Name = "txtNhapC";
            this.txtNhapC.Size = new System.Drawing.Size(100, 23);
            this.txtNhapC.TabIndex = 2;
            this.txtNhapC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(130, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhap so c";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(194, 237);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(236, 108);
            this.txtKetQua.TabIndex = 5;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.Transparent;
            this.btnTinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTinh.BackgroundImage")));
            this.btnTinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTinh.ForeColor = System.Drawing.Color.White;
            this.btnTinh.Location = new System.Drawing.Point(219, 208);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgain.BackgroundImage")));
            this.btnAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgain.ForeColor = System.Drawing.Color.White;
            this.btnAgain.Location = new System.Drawing.Point(333, 208);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 23);
            this.btnAgain.TabIndex = 4;
            this.btnAgain.Text = "Lam Lai";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(130, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ket Qua";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhapC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapA);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Label label5;
    }
}