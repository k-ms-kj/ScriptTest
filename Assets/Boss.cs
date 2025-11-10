using UnityEngine;

public class Boss
{
    //private int hp = 100;   // 体力
    private int mp = 53;   // 魔力
    //private int power = 25; // 攻撃力

    // // 攻撃用の関数
    // public void Attack()
    // {
    //     Debug.Log(this.power + "のダメージを与えた");
    // }

    // 魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log($"魔法攻撃をした。残りMPは{mp.ToString()}。");
        }
        else
        {
            Debug.Log($"MPが足りないため、魔法が使えない。");
        }
    }

    // 防御用の関数
    // public void Defence(int damage)
    // {
    //     Debug.Log(damage + "のダメージを受けた");
    //     // 残りhpを減らす
    //     this.hp -= damage;
    // }

}
