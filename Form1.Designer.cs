
namespace singleton
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentInfoLoad = new System.Windows.Forms.Button();
            this.MajorInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MajorResentlyPrint = new System.Windows.Forms.CheckBox();
            this.StudentInfoAutoLoad = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MajorText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Student1Gender = new System.Windows.Forms.ComboBox();
            this.Student1Sid = new System.Windows.Forms.TextBox();
            this.Student1Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Student1Insert = new System.Windows.Forms.Button();
            this.Student1Delete = new System.Windows.Forms.Button();
            this.Student2Delete = new System.Windows.Forms.Button();
            this.Student2Insert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Student2Gender = new System.Windows.Forms.ComboBox();
            this.Student2Sid = new System.Windows.Forms.TextBox();
            this.Student2Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Student3Delete = new System.Windows.Forms.Button();
            this.Student3Insert = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Student3Gender = new System.Windows.Forms.ComboBox();
            this.Student3Sid = new System.Windows.Forms.TextBox();
            this.Student3Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.majorList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentInfoLoad
            // 
            this.StudentInfoLoad.Location = new System.Drawing.Point(45, 65);
            this.StudentInfoLoad.Name = "StudentInfoLoad";
            this.StudentInfoLoad.Size = new System.Drawing.Size(187, 48);
            this.StudentInfoLoad.TabIndex = 0;
            this.StudentInfoLoad.Text = "학생정보 불러오기";
            this.StudentInfoLoad.UseVisualStyleBackColor = true;
            this.StudentInfoLoad.Click += new System.EventHandler(this.StudentInfoLoad_Click);
            // 
            // MajorInsert
            // 
            this.MajorInsert.Location = new System.Drawing.Point(45, 416);
            this.MajorInsert.Name = "MajorInsert";
            this.MajorInsert.Size = new System.Drawing.Size(143, 34);
            this.MajorInsert.TabIndex = 1;
            this.MajorInsert.Text = "전공추가";
            this.MajorInsert.UseVisualStyleBackColor = true;
            this.MajorInsert.Click += new System.EventHandler(this.MajorInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MajorResentlyPrint);
            this.groupBox1.Controls.Add(this.StudentInfoAutoLoad);
            this.groupBox1.Location = new System.Drawing.Point(260, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설정";
            // 
            // MajorResentlyPrint
            // 
            this.MajorResentlyPrint.AutoSize = true;
            this.MajorResentlyPrint.Location = new System.Drawing.Point(345, 43);
            this.MajorResentlyPrint.Name = "MajorResentlyPrint";
            this.MajorResentlyPrint.Size = new System.Drawing.Size(344, 19);
            this.MajorResentlyPrint.TabIndex = 1;
            this.MajorResentlyPrint.Text = "프로그램 시작시 최근 사용 전공 정보부터 출력";
            this.MajorResentlyPrint.UseVisualStyleBackColor = true;
            this.MajorResentlyPrint.CheckedChanged += new System.EventHandler(this.MajorResentlyPrint_CheckedChanged);
            // 
            // StudentInfoAutoLoad
            // 
            this.StudentInfoAutoLoad.AutoSize = true;
            this.StudentInfoAutoLoad.Location = new System.Drawing.Point(23, 43);
            this.StudentInfoAutoLoad.Name = "StudentInfoAutoLoad";
            this.StudentInfoAutoLoad.Size = new System.Drawing.Size(304, 19);
            this.StudentInfoAutoLoad.TabIndex = 0;
            this.StudentInfoAutoLoad.Text = "프로그램 시작시 자동으로 학생정보 로드";
            this.StudentInfoAutoLoad.UseVisualStyleBackColor = true;
            this.StudentInfoAutoLoad.CheckedChanged += new System.EventHandler(this.StudentInfoAutoLoad_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "전공리스트";
            // 
            // MajorText
            // 
            this.MajorText.Location = new System.Drawing.Point(45, 385);
            this.MajorText.Name = "MajorText";
            this.MajorText.Size = new System.Drawing.Size(143, 25);
            this.MajorText.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Student1Gender);
            this.groupBox2.Controls.Add(this.Student1Sid);
            this.groupBox2.Controls.Add(this.Student1Name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(224, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "학생1";
            // 
            // Student1Gender
            // 
            this.Student1Gender.FormattingEnabled = true;
            this.Student1Gender.Location = new System.Drawing.Point(78, 127);
            this.Student1Gender.Name = "Student1Gender";
            this.Student1Gender.Size = new System.Drawing.Size(121, 23);
            this.Student1Gender.TabIndex = 10;
            // 
            // Student1Sid
            // 
            this.Student1Sid.Location = new System.Drawing.Point(78, 80);
            this.Student1Sid.Name = "Student1Sid";
            this.Student1Sid.Size = new System.Drawing.Size(121, 25);
            this.Student1Sid.TabIndex = 9;
            // 
            // Student1Name
            // 
            this.Student1Name.Location = new System.Drawing.Point(77, 32);
            this.Student1Name.Name = "Student1Name";
            this.Student1Name.Size = new System.Drawing.Size(122, 25);
            this.Student1Name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "성별";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "학번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "이름";
            // 
            // Student1Insert
            // 
            this.Student1Insert.Location = new System.Drawing.Point(244, 395);
            this.Student1Insert.Name = "Student1Insert";
            this.Student1Insert.Size = new System.Drawing.Size(91, 28);
            this.Student1Insert.TabIndex = 7;
            this.Student1Insert.Text = "저장";
            this.Student1Insert.UseVisualStyleBackColor = true;
            this.Student1Insert.Click += new System.EventHandler(this.Student1Insert_Click);
            // 
            // Student1Delete
            // 
            this.Student1Delete.Location = new System.Drawing.Point(341, 395);
            this.Student1Delete.Name = "Student1Delete";
            this.Student1Delete.Size = new System.Drawing.Size(92, 28);
            this.Student1Delete.TabIndex = 8;
            this.Student1Delete.Text = "삭제";
            this.Student1Delete.UseVisualStyleBackColor = true;
            this.Student1Delete.Click += new System.EventHandler(this.Student1Delete_Click);
            // 
            // Student2Delete
            // 
            this.Student2Delete.Location = new System.Drawing.Point(605, 395);
            this.Student2Delete.Name = "Student2Delete";
            this.Student2Delete.Size = new System.Drawing.Size(91, 28);
            this.Student2Delete.TabIndex = 13;
            this.Student2Delete.Text = "삭제";
            this.Student2Delete.UseVisualStyleBackColor = true;
            this.Student2Delete.Click += new System.EventHandler(this.Student2Delete_Click);
            // 
            // Student2Insert
            // 
            this.Student2Insert.Location = new System.Drawing.Point(507, 395);
            this.Student2Insert.Name = "Student2Insert";
            this.Student2Insert.Size = new System.Drawing.Size(90, 28);
            this.Student2Insert.TabIndex = 12;
            this.Student2Insert.Text = "저장";
            this.Student2Insert.UseVisualStyleBackColor = true;
            this.Student2Insert.Click += new System.EventHandler(this.Student2Insert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Student2Gender);
            this.groupBox3.Controls.Add(this.Student2Sid);
            this.groupBox3.Controls.Add(this.Student2Name);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(487, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 180);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "학생2";
            // 
            // Student2Gender
            // 
            this.Student2Gender.FormattingEnabled = true;
            this.Student2Gender.Location = new System.Drawing.Point(78, 127);
            this.Student2Gender.Name = "Student2Gender";
            this.Student2Gender.Size = new System.Drawing.Size(121, 23);
            this.Student2Gender.TabIndex = 10;
            // 
            // Student2Sid
            // 
            this.Student2Sid.Location = new System.Drawing.Point(78, 80);
            this.Student2Sid.Name = "Student2Sid";
            this.Student2Sid.Size = new System.Drawing.Size(121, 25);
            this.Student2Sid.TabIndex = 9;
            // 
            // Student2Name
            // 
            this.Student2Name.Location = new System.Drawing.Point(77, 32);
            this.Student2Name.Name = "Student2Name";
            this.Student2Name.Size = new System.Drawing.Size(122, 25);
            this.Student2Name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "성별";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "학번";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "이름";
            // 
            // Student3Delete
            // 
            this.Student3Delete.Location = new System.Drawing.Point(872, 395);
            this.Student3Delete.Name = "Student3Delete";
            this.Student3Delete.Size = new System.Drawing.Size(87, 28);
            this.Student3Delete.TabIndex = 16;
            this.Student3Delete.Text = "삭제";
            this.Student3Delete.UseVisualStyleBackColor = true;
            this.Student3Delete.Click += new System.EventHandler(this.Student3Delete_Click);
            // 
            // Student3Insert
            // 
            this.Student3Insert.Location = new System.Drawing.Point(770, 395);
            this.Student3Insert.Name = "Student3Insert";
            this.Student3Insert.Size = new System.Drawing.Size(96, 28);
            this.Student3Insert.TabIndex = 15;
            this.Student3Insert.Text = "저장";
            this.Student3Insert.UseVisualStyleBackColor = true;
            this.Student3Insert.Click += new System.EventHandler(this.Student3Insert_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Student3Gender);
            this.groupBox4.Controls.Add(this.Student3Sid);
            this.groupBox4.Controls.Add(this.Student3Name);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(750, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 180);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "학생3";
            // 
            // Student3Gender
            // 
            this.Student3Gender.FormattingEnabled = true;
            this.Student3Gender.Location = new System.Drawing.Point(78, 127);
            this.Student3Gender.Name = "Student3Gender";
            this.Student3Gender.Size = new System.Drawing.Size(121, 23);
            this.Student3Gender.TabIndex = 10;
            // 
            // Student3Sid
            // 
            this.Student3Sid.Location = new System.Drawing.Point(78, 80);
            this.Student3Sid.Name = "Student3Sid";
            this.Student3Sid.Size = new System.Drawing.Size(121, 25);
            this.Student3Sid.TabIndex = 9;
            // 
            // Student3Name
            // 
            this.Student3Name.Location = new System.Drawing.Point(77, 32);
            this.Student3Name.Name = "Student3Name";
            this.Student3Name.Size = new System.Drawing.Size(122, 25);
            this.Student3Name.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "성별";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "학번";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "이름";
            // 
            // majorList
            // 
            this.majorList.FormattingEnabled = true;
            this.majorList.ItemHeight = 15;
            this.majorList.Location = new System.Drawing.Point(45, 230);
            this.majorList.Name = "majorList";
            this.majorList.Size = new System.Drawing.Size(143, 139);
            this.majorList.TabIndex = 17;
            this.majorList.SelectedIndexChanged += new System.EventHandler(this.majorList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 532);
            this.Controls.Add(this.majorList);
            this.Controls.Add(this.Student3Delete);
            this.Controls.Add(this.Student3Insert);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Student2Delete);
            this.Controls.Add(this.Student1Delete);
            this.Controls.Add(this.Student2Insert);
            this.Controls.Add(this.Student1Insert);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MajorText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MajorInsert);
            this.Controls.Add(this.StudentInfoLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentInfoLoad;
        private System.Windows.Forms.Button MajorInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox MajorResentlyPrint;
        private System.Windows.Forms.CheckBox StudentInfoAutoLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MajorText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Student1Sid;
        private System.Windows.Forms.TextBox Student1Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Student1Insert;
        private System.Windows.Forms.ComboBox Student1Gender;
        private System.Windows.Forms.Button Student1Delete;
        private System.Windows.Forms.Button Student2Delete;
        private System.Windows.Forms.Button Student2Insert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Student2Gender;
        private System.Windows.Forms.TextBox Student2Sid;
        private System.Windows.Forms.TextBox Student2Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Student3Delete;
        private System.Windows.Forms.Button Student3Insert;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox Student3Gender;
        private System.Windows.Forms.TextBox Student3Sid;
        private System.Windows.Forms.TextBox Student3Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox majorList;
    }
}

