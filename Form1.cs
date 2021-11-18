using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitGender();
            MajorResentlyLoad();
            StudentAutoLoad();
        }

        private void StudentAutoLoad() { // 자동 학생 정보 로드
            StudentInfoAutoLoad.Checked = ConfigManager.GetInstance().StudentAutoLoad();
            
            if(StudentInfoAutoLoad.Checked == true) {
                loadCheck = true;
                majorListPrint();
                StudentLoad();
            }
        }
        private void MajorResentlyLoad() // 최근 사용 정보 로드
        {
            MajorResentlyPrint.Checked = ConfigManager.GetInstance().MajorSelectCheck();
        }
        private void StudentInfoAutoLoad_CheckedChanged(object sender, EventArgs e) // 자동 학생 정보 state 변경
        {
            ConfigManager.GetInstance().StudentAutoLoadChangeChecked(StudentInfoAutoLoad.Checked);
        }

        private void MajorResentlyPrint_CheckedChanged(object sender, EventArgs e) // 최근 사용 정보 state 변경
        {
            ConfigManager.GetInstance().AutoSelectChecked(MajorResentlyPrint.Checked);
        }

        private void InitGender()
        {
            Student1Gender.Items.Clear();
            Student1Gender.Items.Add("남자");
            Student1Gender.Items.Add("여자");
            

            string[] genderData = { "남자", "여자" };
            Student2Gender.Items.Clear();
            Student2Gender.Items.AddRange(genderData);

            Student3Gender.Items.Clear();
            Student3Gender.Items.AddRange(genderData);

        }

        Student student;

        private void StudentInfoLoad_Click(object sender, EventArgs e) // 학생 정보 불러오기 버튼
        {
            loadCheck = true;
            majorListPrint();
            StudentLoad();
        }
        List<int> i_user;
        private void StudentLoad() // 학생 정보 불러오기
        {
            student = new Student();

            List<string>  list = student.DBSelectPrint(majorValue);
            i_user = student.DBSelectI_user(majorValue); // 전공 리스트에 해당 되는 학생 리스트

            // i_user 가 1이거나 2라면 2, 3에 -1을 넣어 -1일 경우 insert로 판단
            if(i_user.Count == 0) {
                i_user.Add(-1);
            } else if(i_user.Count == 1) { 
                i_user.Add(-1);
                i_user.Add(-1);
            } else if(i_user.Count == 2) {
                i_user.Add(-1);
            }
            
            // 값 비우기
            Student1Name.Text = "";
            Student1Sid.Text = "";
            Student1Gender.Text = "";
            Student2Name.Text = "";
            Student2Sid.Text = "";
            Student2Gender.Text = "";
            Student3Name.Text = "";
            Student3Sid.Text = "";
            Student3Gender.Text = "";

            // 값 출력
            for (int i = 0; i < list.Count; i++) {
                if (i < 3)
                {
                    Student1Name.Text = list[i++];
                    Student1Sid.Text = list[i++];
                    Student1Gender.Text = list[i++];
                }
                else if (i < 6)
                {
                    Student2Name.Text = list[i++];
                    Student2Sid.Text = list[i++];
                    Student2Gender.Text = list[i++];
                }
                else if (i < 9)
                {
                    Student3Name.Text = list[i++];
                    Student3Sid.Text = list[i++];
                    Student3Gender.Text = list[i++];
                }
            }
        }

        string majorValue;
        bool doOncePass = false;
        private void majorList_SelectedIndexChanged(object sender, EventArgs e) // 전공 변경 시 선택
        {
            majorValue = (string)majorList.SelectedItem;
            int majorInt = majorList.SelectedIndex;
            ConfigManager.GetInstance().RecentlyMajorSave(majorInt);
            if(doOncePass == true) {
                StudentLoad();
            }
            doOncePass = true;
        }

        Major major;

        private void majorListPrint() // 전공 리스트 출력
        {
            major = new Major();
            majorList.Items.Clear();
            for (int i = 0; i < major.majorListPrint().Count; i++)
            {
                majorList.Items.Add(major.majorListPrint()[i]);             
            }

            if(MajorResentlyPrint.Checked == true) { // 최근 사용 전공이 체크 되어 있을 경우 저장 해놓은 전공 값을 대입
                majorList.SelectedIndex = ConfigManager.GetInstance().RecentlyMajor();
            } else { // 체크가 되어 있지 않을 경우 0번 인덱스를 기본으로 함
                majorList.SelectedIndex = 0;
            }
        }

        private void MajorInsert_Click(object sender, EventArgs e) // 전공 추가
        {
            major.insertMajor(MajorText.Text);
            majorListPrint();
        }

        Boolean loadCheck = false;
        int check;
        string name;
        int sid;
        string gender;

        private void Student1Insert_Click(object sender, EventArgs e) // 저장, 변경 버튼
        {
            if(Student1Name.Text.Equals("") || Student1Sid.Text.Equals("") || Student1Gender.Text.Equals("")) {
                return;
            }
            if(loadCheck == false) {
                return;
            }

            string temp = Student1Sid.Text;
            check = 1;
            name = Student1Name.Text;
            sid = Int32.Parse(temp);
            gender = Student1Gender.Text;
            student.DBconn(i_user[0], check, name, sid, gender, majorValue);
            StudentLoad();
        }

        private void Student1Delete_Click(object sender, EventArgs e) // 삭제 버튼
        {
            if (loadCheck == false) {
                return;
            }
            string temp = Student1Sid.Text;

            check = 2;
            name = Student1Name.Text;
            sid = Int32.Parse(temp);
            gender = Student1Gender.Text;
            student.DBconn(i_user[0], check, name, sid, gender, majorValue);
            StudentLoad();
        }

        private void Student2Insert_Click(object sender, EventArgs e)
        {
            if(Student2Name.Text.Equals("") || Student2Sid.Text.Equals("") || Student2Gender.Text.Equals("")) {
                return;
            }
            if(loadCheck == false) {
                return;
            }

            string temp = Student2Sid.Text;
            check = 1;
            name = Student2Name.Text;
            sid = Int32.Parse(temp);
            gender = Student2Gender.Text;
            student.DBconn(i_user[1], check, name, sid, gender, majorValue);
            StudentLoad();
        }

        private void Student2Delete_Click(object sender, EventArgs e)
        {
            if (loadCheck == false) {
                return;
            }
            string temp = Student2Sid.Text;

            check = 2;
            name = Student2Name.Text;
            sid = Int32.Parse(temp);
            gender = Student2Gender.Text;
            student.DBconn(i_user[1], check, name, sid, gender, majorValue);
            StudentLoad();
        }

        private void Student3Insert_Click(object sender, EventArgs e)
        {
            if(Student3Name.Text.Equals("") || Student3Sid.Text.Equals("") || Student3Gender.Text.Equals("")) {
                return;
            }
            if(loadCheck == false) {
                return;
            }

            string temp = Student3Sid.Text;
            check = 1;
            name = Student3Name.Text;
            sid = Int32.Parse(temp);
            gender = Student3Gender.Text;
            student.DBconn(i_user[2], check, name, sid, gender, majorValue);
            StudentLoad();
        }

        private void Student3Delete_Click(object sender, EventArgs e)
        {
            if (loadCheck == false)
            {
                return;
            }
            string temp = Student3Sid.Text;

            check = 2;
            name = Student3Name.Text;
            sid = Int32.Parse(temp);
            gender = Student3Gender.Text;
            student.DBconn(i_user[2], check, name, sid, gender, majorValue);
            StudentLoad();
        }
    }
}
