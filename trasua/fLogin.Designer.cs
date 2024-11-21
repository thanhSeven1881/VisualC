namespace trasua
{
    partial class fLogin
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
            label1 = new Label();
            label2 = new Label();
            txbUserName = new TextBox();
            label3 = new Label();
            txbPassWord = new TextBox();
            cbHienthimatkhau = new CheckBox();
            btDangnhap = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(67, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(343, 73);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F);
            label2.Location = new Point(36, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txbUserName.Location = new Point(40, 166);
            txbUserName.Margin = new Padding(4, 5, 4, 5);
            txbUserName.Multiline = true;
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(424, 52);
            txbUserName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F);
            label3.Location = new Point(36, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // txbPassWord
            // 
            txbPassWord.Font = new Font("Times New Roman", 12F);
            txbPassWord.Location = new Point(40, 272);
            txbPassWord.Margin = new Padding(4, 5, 4, 5);
            txbPassWord.Multiline = true;
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(424, 52);
            txbPassWord.TabIndex = 4;
            // 
            // cbHienthimatkhau
            // 
            cbHienthimatkhau.AutoSize = true;
            cbHienthimatkhau.Location = new Point(320, 361);
            cbHienthimatkhau.Margin = new Padding(4, 5, 4, 5);
            cbHienthimatkhau.Name = "cbHienthimatkhau";
            cbHienthimatkhau.Size = new Size(148, 24);
            cbHienthimatkhau.TabIndex = 5;
            cbHienthimatkhau.Text = "Hiển thị mật khẩu";
            cbHienthimatkhau.UseVisualStyleBackColor = true;
            // 
            // btDangnhap
            // 
            btDangnhap.BackColor = SystemColors.HotTrack;
            btDangnhap.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btDangnhap.ForeColor = SystemColors.ControlLightLight;
            btDangnhap.Location = new Point(40, 420);
            btDangnhap.Margin = new Padding(4, 5, 4, 5);
            btDangnhap.Name = "btDangnhap";
            btDangnhap.Size = new Size(425, 74);
            btDangnhap.TabIndex = 6;
            btDangnhap.Text = "ĐĂNG NHẬP";
            btDangnhap.UseVisualStyleBackColor = false;
            btDangnhap.Click += btDangnhap_Click;
            // 
            // btThoat
            // 
            btThoat.BackColor = SystemColors.HotTrack;
            btThoat.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btThoat.ForeColor = SystemColors.ControlLightLight;
            btThoat.Location = new Point(40, 502);
            btThoat.Margin = new Padding(4, 5, 4, 5);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(425, 74);
            btThoat.TabIndex = 7;
            btThoat.Text = "THOÁT";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // fLogin
            // 
            AcceptButton = btDangnhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btThoat;
            ClientSize = new Size(512, 633);
            Controls.Add(btThoat);
            Controls.Add(btDangnhap);
            Controls.Add(cbHienthimatkhau);
            Controls.Add(txbPassWord);
            Controls.Add(label3);
            Controls.Add(txbUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "fLogin";
            Text = " Đăng nhập";
            FormClosing += fLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.CheckBox cbHienthimatkhau;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.Button btThoat;
    }
}