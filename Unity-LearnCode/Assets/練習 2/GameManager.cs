using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Soldier SoliderA = new Soldier();

    public Warrior WarriorA = new Warrior();

    private void Start()
    {
        SoliderA.lv = 30;
        Debug.Log("士兵經驗值 - 取得：" + SoliderA.GetExp());

        SoliderA.SetExp(100);
        Debug.Log("士兵經驗值 - 設定：" + SoliderA.exp);

        WarriorA.lv = 50;
        Debug.Log("戰士經驗值 - 取得：" + WarriorA.Exp);

        WarriorA.Exp = 777;
        Debug.Log("戰士經驗值 - 設定：" + WarriorA.exp);
    }
}