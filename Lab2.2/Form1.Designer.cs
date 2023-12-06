namespace Lab2._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Save = new Button();
            TBinputPoint = new TextBox();
            TBinputName = new TextBox();
            TBinputID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label17 = new Label();
            label16 = new Label();
            รหัสนักศึกษา = new Label();
            average = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            Lowpoint = new TextBox();
            Highpoint = new TextBox();
            HighName = new TextBox();
            LowName = new TextBox();
            LowID = new TextBox();
            HighID = new TextBox();
            gpa = new TextBox();
            F = new TextBox();
            D = new TextBox();
            Dplus = new TextBox();
            C = new TextBox();
            Cplus = new TextBox();
            B = new TextBox();
            Bplus = new TextBox();
            A = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Save);
            groupBox1.Controls.Add(TBinputPoint);
            groupBox1.Controls.Add(TBinputName);
            groupBox1.Controls.Add(TBinputID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "กรอกข้อมูล";
            // 
            // Save
            // 
            Save.Location = new Point(77, 162);
            Save.Name = "Save";
            Save.Size = new Size(101, 23);
            Save.TabIndex = 2;
            Save.Text = "บันทึก";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // TBinputPoint
            // 
            TBinputPoint.Location = new Point(77, 121);
            TBinputPoint.Name = "TBinputPoint";
            TBinputPoint.Size = new Size(147, 23);
            TBinputPoint.TabIndex = 3;
            // 
            // TBinputName
            // 
            TBinputName.Location = new Point(77, 85);
            TBinputName.Name = "TBinputName";
            TBinputName.Size = new Size(147, 23);
            TBinputName.TabIndex = 3;
            // 
            // TBinputID
            // 
            TBinputID.Location = new Point(77, 46);
            TBinputID.Name = "TBinputID";
            TBinputID.Size = new Size(147, 23);
            TBinputID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "คะแนน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "รหัสนักศึกษา";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 85);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(รหัสนักศึกษา);
            groupBox2.Controls.Add(average);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(Lowpoint);
            groupBox2.Controls.Add(Highpoint);
            groupBox2.Controls.Add(HighName);
            groupBox2.Controls.Add(LowName);
            groupBox2.Controls.Add(LowID);
            groupBox2.Controls.Add(HighID);
            groupBox2.Controls.Add(gpa);
            groupBox2.Controls.Add(F);
            groupBox2.Controls.Add(D);
            groupBox2.Controls.Add(Dplus);
            groupBox2.Controls.Add(C);
            groupBox2.Controls.Add(Cplus);
            groupBox2.Controls.Add(B);
            groupBox2.Controls.Add(Bplus);
            groupBox2.Controls.Add(A);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(245, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(679, 435);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลลัพท์";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(497, 19);
            label17.Name = "label17";
            label17.Size = new Size(38, 15);
            label17.TabIndex = 18;
            label17.Text = "คะแนน";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(373, 19);
            label16.Name = "label16";
            label16.Size = new Size(63, 15);
            label16.TabIndex = 17;
            label16.Text = "ชื่อ-นามสกุล";
            // 
            // รหัสนักศึกษา
            // 
            รหัสนักศึกษา.AutoSize = true;
            รหัสนักศึกษา.Location = new Point(253, 19);
            รหัสนักศึกษา.Name = "รหัสนักศึกษา";
            รหัสนักศึกษา.Size = new Size(65, 15);
            รหัสนักศึกษา.TabIndex = 16;
            รหัสนักศึกษา.Text = "รหัสนักศึกษา";
            // 
            // average
            // 
            average.Location = new Point(466, 131);
            average.Name = "average";
            average.Size = new Size(106, 23);
            average.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(398, 134);
            label15.Name = "label15";
            label15.Size = new Size(60, 15);
            label15.TabIndex = 14;
            label15.Text = "คะแนนเฉลี่ย";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(168, 88);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 13;
            label14.Text = "คะแนนต่ำสุด";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(168, 52);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 12;
            label13.Text = "คะแนนสูงสุด";
            // 
            // Lowpoint
            // 
            Lowpoint.Location = new Point(464, 85);
            Lowpoint.Name = "Lowpoint";
            Lowpoint.Size = new Size(108, 23);
            Lowpoint.TabIndex = 11;
            // 
            // Highpoint
            // 
            Highpoint.Location = new Point(464, 49);
            Highpoint.Name = "Highpoint";
            Highpoint.Size = new Size(108, 23);
            Highpoint.TabIndex = 10;
            // 
            // HighName
            // 
            HighName.Location = new Point(350, 49);
            HighName.Name = "HighName";
            HighName.Size = new Size(108, 23);
            HighName.TabIndex = 9;
            // 
            // LowName
            // 
            LowName.Location = new Point(350, 85);
            LowName.Name = "LowName";
            LowName.Size = new Size(108, 23);
            LowName.TabIndex = 8;
            // 
            // LowID
            // 
            LowID.Location = new Point(236, 85);
            LowID.Name = "LowID";
            LowID.Size = new Size(108, 23);
            LowID.TabIndex = 7;
            // 
            // HighID
            // 
            HighID.Location = new Point(236, 49);
            HighID.Name = "HighID";
            HighID.Size = new Size(108, 23);
            HighID.TabIndex = 6;
            // 
            // gpa
            // 
            gpa.Location = new Point(59, 281);
            gpa.Name = "gpa";
            gpa.Size = new Size(103, 23);
            gpa.TabIndex = 5;
            gpa.TextChanged += gpa_TextChanged;
            // 
            // F
            // 
            F.Location = new Point(59, 243);
            F.Name = "F";
            F.Size = new Size(103, 23);
            F.TabIndex = 5;
            // 
            // D
            // 
            D.Location = new Point(59, 214);
            D.Name = "D";
            D.Size = new Size(103, 23);
            D.TabIndex = 5;
            // 
            // Dplus
            // 
            Dplus.Location = new Point(59, 184);
            Dplus.Name = "Dplus";
            Dplus.Size = new Size(103, 23);
            Dplus.TabIndex = 5;
            // 
            // C
            // 
            C.Location = new Point(59, 155);
            C.Name = "C";
            C.Size = new Size(103, 23);
            C.TabIndex = 5;
            // 
            // Cplus
            // 
            Cplus.Location = new Point(59, 126);
            Cplus.Name = "Cplus";
            Cplus.Size = new Size(103, 23);
            Cplus.TabIndex = 5;
            // 
            // B
            // 
            B.Location = new Point(59, 97);
            B.Name = "B";
            B.Size = new Size(103, 23);
            B.TabIndex = 5;
            // 
            // Bplus
            // 
            Bplus.Location = new Point(59, 68);
            Bplus.Name = "Bplus";
            Bplus.Size = new Size(103, 23);
            Bplus.TabIndex = 5;
            // 
            // A
            // 
            A.Location = new Point(59, 41);
            A.Name = "A";
            A.Size = new Size(103, 23);
            A.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 281);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 3;
            label12.Text = "เกรดเฉลี่ย";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 243);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 3;
            label11.Text = "F";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 217);
            label10.Name = "label10";
            label10.Size = new Size(15, 15);
            label10.TabIndex = 3;
            label10.Text = "D";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 188);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 3;
            label9.Text = "D+";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 158);
            label8.Name = "label8";
            label8.Size = new Size(15, 15);
            label8.TabIndex = 2;
            label8.Text = "C";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 129);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 3;
            label7.Text = "C+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 76);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 2;
            label5.Text = "B+";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 100);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 2;
            label6.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 44);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 0;
            label4.Text = "A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Button Save;
        private TextBox TBinputPoint;
        private TextBox TBinputName;
        private TextBox TBinputID;
        private Label label3;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label8;
        private Label label9;
        private TextBox C;
        private TextBox Cplus;
        private TextBox B;
        private TextBox Bplus;
        private TextBox A;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox Dplus;
        private TextBox Lowpoint;
        private TextBox Highpoint;
        private TextBox HighName;
        private TextBox LowName;
        private TextBox LowID;
        private TextBox HighID;
        private TextBox gpa;
        private TextBox F;
        private TextBox D;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox average;
        private Label label16;
        private Label รหัสนักศึกษา;
        private Label label17;
    }
}
