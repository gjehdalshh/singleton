using MySqlConnector;
using System;
using System.Collections.Generic;

public class DBManger
{
    private static DBManger instance = new DBManger();

    string strconn = "Server=27.96.130.41;Database=s5727844;Uid=s5727844;Pwd=s5727844;Charset=utf8";
    string query = "";

    public static DBManger GetInstance()
    {
        return instance;
    }

    public void insertMajor(string major) // 전공 추가
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            query = "insert into major (major_name) values ('"+major+"')";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("이미 같은 전공이 존재");
            }
        }
    }

    public List<string> DBSelectQuery() // 전공 리스트 검색
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select * from major order by i_major asc";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<string> majorListPrint = new List<string>();
            while(rdr.Read())
            {
                majorListPrint.Add((string)rdr["major_name"]);
                
            }

            rdr.Close();

            return majorListPrint;
        }
    }

    public List<int> DBSelectI_user(string majorValue) // 전공에 포함된 i_user 리스트 검색
    {
        List<int> i_user = new List<int>();

        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select i_user from student where major = '" + majorValue + "'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                i_user.Add((int)rdr["i_user"]);
            }
            rdr.Close();
        }

        return i_user;
    }
    
    public List<string> DBSelectPrint(string majorValue) // 전공에 해당하는 학생 목록 리스트 생성
    {
        List<string> student = new List<string>();

        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select * from student where major = '"+ majorValue+"'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                student.Add((string)rdr["user_name"]);
                int temp = (int)rdr["user_sid"];

                student.Add(temp.ToString());
                student.Add((string)rdr["user_gender"]);
                student.Add((string)rdr["major"]);
            }

            rdr.Close();
        }

            return student;
    }

    int i_user;
    public int DBSelect(int check, int nowI_user) // insert update 확인
    {
        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "select * from student";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if(check == 1) { // insert, update 라면
                while(rdr.Read()) {
                    i_user = (int)rdr["i_user"];
                    if(nowI_user.Equals(i_user)) { // 값이 존재한다면 update
                        rdr.Close();
                        return 1;
                    }
                }
            }
            if(check == 2) { // delete 라면
                return 2;
            }
            rdr.Close();
            return 0;
        }
    }

    public void DBconnection(int nowI_user, int check, string name, int sid, string gender, string majorValue)
    { // insert update delete 처리
        int value;
        if(nowI_user == -1) { // -1이면 insert
            value = 0;
        } else {
            value = DBSelect(check, nowI_user); // 1이면 update 2이면 delete
        }

        using (MySqlConnection conn = new MySqlConnection(strconn))
        {
            conn.Open();
            query = "";
            
            if (value == 0) // insert
            {
                query = "insert into student(user_name, user_sid, user_gender, major) values ('"+name+"','"+sid+"','"+gender+"','"+majorValue+"')"; 
            }
            else if (value == 1) // update
            {
                query = "update student set user_name = '" + name + "',user_sid = '"+sid+"', user_gender = '"+gender+"' where i_user = "+i_user+"";
            }
            else if (value == 2) // delete
            {
                query = "delete from student where i_user = "+ nowI_user + "";
            }

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
