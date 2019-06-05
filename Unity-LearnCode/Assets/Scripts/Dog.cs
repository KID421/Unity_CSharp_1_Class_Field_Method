using UnityEngine;

public class Dog
{
    #region 欄位
    public string name;
    public float weight;
    public string type;
    public string sex;
    public string color;
    public int age;
    #endregion

    #region 方法
    /// <summary>
    /// 狗狗亂叫的方法。
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + "：汪汪!!!");
    }

    /// <summary>
    /// 轉換狗狗年齡的方法。
    /// </summary>
    /// <returns>狗狗年齡 * 7</returns>
    public int ConvertAge()
    {
        return age * 7;
    }

    /// <summary>
    /// 狗狗吃東西的方法。
    /// </summary>
    /// <param name="food">食物</param>
    /// <param name="speed">吃飯速度</param>
    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + "：" + food + "，速度：" + speed);
    }

    /// <summary>
    /// 狗狗吃東西的方法。
    /// </summary>
    /// <param name="food">食物</param>
    /// <param name="count">份量</param>
    public void Eat(string food, int count)
    {
        Debug.Log(name + "：" + food + "，份量：" + count);
    }
    #endregion
}