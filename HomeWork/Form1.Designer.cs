namespace HomeWork
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
            this.labName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labDay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labRoom = new System.Windows.Forms.Label();
            this.btComfirm = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.labGender = new System.Windows.Forms.Label();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.cbRobot = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(49, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(62, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "ชื่อ-นามสกุล";
            this.labName.Click += new System.EventHandler(this.labName_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(118, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(203, 20);
            this.tbName.TabIndex = 1;
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Location = new System.Drawing.Point(53, 144);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(53, 13);
            this.labDay.TabIndex = 2;
            this.labDay.Text = "วันประชุม";
            this.labDay.Click += new System.EventHandler(this.labDay_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "101",
            "202",
            "303",
            "404",
            "505",
            "606"});
            this.comboBox1.Location = new System.Drawing.Point(118, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // labRoom
            // 
            this.labRoom.AutoSize = true;
            this.labRoom.Location = new System.Drawing.Point(49, 115);
            this.labRoom.Name = "labRoom";
            this.labRoom.Size = new System.Drawing.Size(57, 13);
            this.labRoom.TabIndex = 5;
            this.labRoom.Text = "ห้องประชุม";
            // 
            // btComfirm
            // 
            this.btComfirm.Location = new System.Drawing.Point(56, 220);
            this.btComfirm.Name = "btComfirm";
            this.btComfirm.Size = new System.Drawing.Size(75, 23);
            this.btComfirm.TabIndex = 6;
            this.btComfirm.Text = "ยืนยัน";
            this.btComfirm.UseVisualStyleBackColor = true;
            this.btComfirm.Click += new System.EventHandler(this.btComfirm_Click);
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(202, 220);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 23);
            this.btClean.TabIndex = 7;
            this.btClean.Text = "ล้างข้อมูล";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(78, 85);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(28, 13);
            this.labGender.TabIndex = 8;
            this.labGender.Text = "เพศ";
            // 
            // cbbGender
            // 
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "ชาย",
            "หญิง"});
            this.cbbGender.Location = new System.Drawing.Point(118, 77);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(121, 21);
            this.cbbGender.TabIndex = 9;
            // 
            // cbRobot
            // 
            this.cbRobot.AutoSize = true;
            this.cbRobot.Location = new System.Drawing.Point(71, 184);
            this.cbRobot.Name = "cbRobot";
            this.cbRobot.Size = new System.Drawing.Size(154, 17);
            this.cbRobot.TabIndex = 10;
            this.cbRobot.Text = "คุณไม่ใช่โปรแกรมอัตโนมัติ";
            this.cbRobot.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.form2ToolStripMenuItem.Text = "Form2";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 281);
            this.Controls.Add(this.cbRobot);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.btComfirm);
            this.Controls.Add(this.labRoom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labDay);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labRoom;
        private System.Windows.Forms.Button btComfirm;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.CheckBox cbRobot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

