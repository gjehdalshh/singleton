using System;
using System.Collections.Generic;

public class Student
{

    public void DBconn(int i_user, int check,  string name, int sid, string gender, string majorValue) // DB 연결
    {
        DBManger.GetInstance().DBconnection(i_user, check, name, sid, gender, majorValue);
    }

    public List<string> DBSelectPrint(string majorValue) // 전공에 해당하는 학생 리스트를 반환
    {
        return DBManger.GetInstance().DBSelectPrint(majorValue);
    }

    public List<int> DBSelectI_user(string majorValue) // 전공에 해당하는 학생 i_user 리스트
    {
        return DBManger.GetInstance().DBSelectI_user(majorValue);
    }

    
}
