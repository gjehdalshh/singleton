using System;
using System.Collections.Generic;

public class Major
{
    public List<string> majorListPrint() // 전공 리스트 출력 리턴
    {
        List<string> majorListPrint = new List<string>();
        majorListPrint = DBManger.GetInstance().DBSelectQuery();

        return majorListPrint;
    }

    public void insertMajor(string major) // 전공 추가
    {
        DBManger.GetInstance().insertMajor(major);
    }

}
