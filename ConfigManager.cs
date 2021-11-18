using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConfigManager
{
    private static ConfigManager instance = new ConfigManager();

    public static ConfigManager GetInstance()
    {
        return instance;
    }

    public bool StudentAutoLoad() // setting에 있는 true false 값 리턴
    {
        return singleton.Properties.Settings.Default.autoLoadCheck;
    }
    public bool MajorSelectCheck() // setting에 있는 true false 값 리턴
    {
        return singleton.Properties.Settings.Default.autoSelectedCheck;
    }

    public void StudentAutoLoadChangeChecked(bool check) { // 자동 로드 선택 여부에 따라 setting에 true false 저장
        singleton.Properties.Settings.Default.autoLoadCheck = check;
        singleton.Properties.Settings.Default.Save();
    }

    public void AutoSelectChecked(bool check) { // 최근 전공 출력 선택 여부에 따라 setting에 true false 저장
        singleton.Properties.Settings.Default.autoSelectedCheck = check;
        singleton.Properties.Settings.Default.Save();
    }

    public int RecentlyMajor() // setting에 있는 최근 전공 값 리턴
    {
        return singleton.Properties.Settings.Default.recentlyMajor;
    }

    public void RecentlyMajorSave(int major) // 최근 전공이 무엇인지를 저장
    {
        singleton.Properties.Settings.Default.recentlyMajor = major;
        singleton.Properties.Settings.Default.Save();
    }
}