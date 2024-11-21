namespace trasua
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            panel3 = new Panel();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDisCount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1063, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";

            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(210, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(210, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(596, 131);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 485);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Location = new Point(4, 5);
            lsvBill.Margin = new Padding(4, 5, 4, 5);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(441, 473);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDisCount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(596, 625);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 80);
            panel3.TabIndex = 3;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(4, 43);
            cbSwitchTable.Margin = new Padding(4, 5, 4, 5);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(99, 28);
            cbSwitchTable.TabIndex = 6;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(4, 5);
            btnSwitchTable.Margin = new Padding(4, 5, 4, 5);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(100, 40);
            btnSwitchTable.TabIndex = 5;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmDisCount
            // 
            nmDisCount.Location = new Point(177, 45);
            nmDisCount.Margin = new Padding(4, 5, 4, 5);
            nmDisCount.Name = "nmDisCount";
            nmDisCount.Size = new Size(99, 27);
            nmDisCount.TabIndex = 4;
            nmDisCount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(177, 5);
            btnDiscount.Margin = new Padding(4, 5, 4, 5);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(100, 40);
            btnDiscount.TabIndex = 4;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(347, 5);
            btnCheckOut.Margin = new Padding(4, 5, 4, 5);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(100, 71);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(596, 42);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 80);
            panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(395, 29);
            nmFoodCount.Margin = new Padding(4, 5, 4, 5);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(52, 27);
            nmFoodCount.TabIndex = 3;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(285, 5);
            btnAddFood.Margin = new Padding(4, 5, 4, 5);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(100, 71);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(4, 43);
            cbFood.Margin = new Padding(4, 5, 4, 5);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(272, 28);
            cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(4, 5);
            cbCategory.Margin = new Padding(4, 5, 4, 5);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(272, 28);
            cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(16, 46);
            flpTable.Margin = new Padding(4, 5, 4, 5);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(572, 658);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 723);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDisCount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDisCount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}