namespace HomeWork
{
    partial class Form2
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
            this.labAD = new System.Windows.Forms.Label();
            this.tbAD = new System.Windows.Forms.TextBox();
            this.labPV = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btConfirm2 = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAD
            // 
            this.labAD.AutoSize = true;
            this.labAD.Location = new System.Drawing.Point(52, 39);
            this.labAD.Name = "labAD";
            this.labAD.Size = new System.Drawing.Size(27, 13);
            this.labAD.TabIndex = 0;
            this.labAD.Text = "ที่อยู่";
            // 
            // tbAD
            // 
            this.tbAD.Location = new System.Drawing.Point(86, 39);
            this.tbAD.Multiline = true;
            this.tbAD.Name = "tbAD";
            this.tbAD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAD.Size = new System.Drawing.Size(206, 52);
            this.tbAD.TabIndex = 1;
            // 
            // labPV
            // 
            this.labPV.AutoSize = true;
            this.labPV.Location = new System.Drawing.Point(41, 109);
            this.labPV.Name = "labPV";
            this.labPV.Size = new System.Drawing.Size(38, 13);
            this.labPV.TabIndex = 2;
            this.labPV.Text = "จังหวัด";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "กระบี่",
            "กรุงเทพมหานคร",
            "กาญจนบุรี",
            "กาฬสินธุ์",
            "กำแพงเพชร",
            "ขอนแก่น",
            "จันทบุรี",
            "ฉะเชิงเทรา",
            "ชลบุรี",
            "ชัยนาท",
            "ชัยภูมิ",
            "ชุมพร",
            "เชียงราย",
            "เชียงใหม่",
            "ตรัง",
            "ตราด",
            "ตาก",
            "นครนายก",
            "นครปฐม",
            "นครพนม",
            "นครราชสีมา",
            "นครศรีธรรมราช",
            "นครสวรรค์",
            "นนทบุรี",
            "นราธิวาส",
            "น่าน",
            "บึงกาฬ",
            "บุรีรัมย์",
            "ปทุมธานี",
            "ประจวบคีรีขันธ์",
            "ปราจีนบุรี",
            "ปัตตานี",
            "พระนครศรีอยุธยา",
            "พะเยา",
            "พังงา",
            "พัทลุง",
            "พิจิตร",
            "พิษณุโลก",
            "เพชรบุรี",
            "เพชรบูรณ์",
            "แพร่",
            "ภูเก็ต",
            "มหาสารคาม",
            "มุกดาหาร",
            "แม่ฮ่องสอน",
            "ยโสธร",
            "ยะลา",
            "ร้อยเอ็ด",
            "ระนอง",
            "ระยอง",
            "ราชบุรี",
            "ลพบุรี",
            "ลำปาง",
            "ลำพูน",
            "เลย",
            "ศรีสะเกษ",
            "สกลนคร",
            "สงขลา",
            "สตูล",
            "สมุทรปราการ",
            "สมุทรสงคราม",
            "สมุทรสาคร",
            "สระแก้ว",
            "สระบุรี",
            "สิงห์บุรี",
            "สุโขทัย",
            "สุพรรณบุรี",
            "สุราษฎร์ธานี",
            "สุรินทร์",
            "หนองคาย",
            "หนองบัวลำภู",
            "อ่างทอง",
            "อำนาจเจริญ",
            "อุดรธานี",
            "อุตรดิตถ์",
            "อุทัยธานี",
            "อุบลราชธานี"});
            this.comboBox1.Location = new System.Drawing.Point(86, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btConfirm2
            // 
            this.btConfirm2.Location = new System.Drawing.Point(86, 173);
            this.btConfirm2.Name = "btConfirm2";
            this.btConfirm2.Size = new System.Drawing.Size(75, 23);
            this.btConfirm2.TabIndex = 4;
            this.btConfirm2.Text = "ยืนยัย";
            this.btConfirm2.UseVisualStyleBackColor = true;
            this.btConfirm2.Click += new System.EventHandler(this.btConfirm2_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(205, 173);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "ปิด";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 264);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btConfirm2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labPV);
            this.Controls.Add(this.tbAD);
            this.Controls.Add(this.labAD);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAD;
        private System.Windows.Forms.TextBox tbAD;
        private System.Windows.Forms.Label labPV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btConfirm2;
        private System.Windows.Forms.Button btClose;
    }
}