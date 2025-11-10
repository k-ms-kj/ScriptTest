using UnityEngine;
// using Boss;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int[] _array = { 1, 2, 4, 5, 6 };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowNormalOrder();
        ShowReverseOrder();
        //ボス生成
        Boss boss = new Boss();
        //攻撃11回
        for (int i = 0; i < 11; i++)
        {
            boss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 配列要素を順番に表示
    /// </summary>
    private void ShowNormalOrder()
    {
        int num = _array.Length;
        string text = "";
        for (int i = 0; i < num; i++)
        {
            text += i.ToString() + " ";
        }
        Debug.Log($"NormalOrder = {text}");
    }

    /// <summary>
    /// 配列要素を逆順に表示
    /// </summary>
    private void ShowReverseOrder()
    {
        int num = _array.Length;
        string text = "";
        for (int i = num; i > 0; i--)
        {
            text += i.ToString() + " ";
        }
        Debug.Log($"ReverseOrder = {text}");
    }
}
