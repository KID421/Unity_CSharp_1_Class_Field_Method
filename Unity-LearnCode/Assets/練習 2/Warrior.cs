[System.Serializable]
public class Warrior
{
    public int exp;
    public int lv;

    /// <summary>
    /// 取得與設定戰士的經驗值
    /// </summary>
    public int Exp
    {
        get
        {
            exp = lv * 10;
            return exp;
        }
        set
        {
            exp = value;
        }
    }
}