using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Soldier SoliderA = new Soldier();

    private void Start()
    {
        SoliderA.lv = 30;
        Debug.Log("士兵經驗值 - 取得：" + SoliderA.GetExp());

        SoliderA.SetExp(100);
        Debug.Log("士兵經驗值 - 設定：" + SoliderA.exp);
    }
}