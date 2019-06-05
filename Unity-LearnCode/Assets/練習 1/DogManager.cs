using UnityEngine;

public class DogManager : MonoBehaviour
{
    #region 欄位
    public Dog DogA = new Dog("公", 7);
    public Dog DogB = new Dog("母", 3);
    public Dog DogC = new Dog();
    #endregion

    #region 事件
    private void Start()
    {
        DogA.name = "鬼娃";
        DogA.weight = 30.5f;
        DogA.type = "貴賓";
        DogA.color = "咖啡";

        // DogA.sex = "公";
        // DogA.age = 7;

        DogB.name = "恰吉";
        DogB.weight = 5.8f;
        DogB.type = "吉娃娃";
        DogB.color = "白";

        // DogB.sex = "母";
        // DogB.age = 3;

        Debug.Log(DogA.name + " 品種：" + DogA.type + " 顏色：" + DogA.color);
        Debug.Log(DogB.name + " 品種：" + DogB.type + " 顏色：" + DogB.color);

        DogA.Bark();
        DogB.Bark();

        Debug.Log(DogA.name + " 的實際年齡為：" + DogA.ConvertAge());
        Debug.Log(DogB.name + " 的實際年齡為：" + DogB.ConvertAge());

        DogA.Eat("熱狗");
        DogB.Eat("蛋糕", 10);
    }
    #endregion
}