using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;  // 体力

    private int power = 25; // 攻撃力

    private int mp = 53; //魔法力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //攻撃魔法用の関数
    public void Magic()
    {
        if(this.mp - 5 < 0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
            return;
        }    
        this.mp -= 5;

        Debug.Log(string.Format("魔法攻撃をした。残りMPは{0}。",this.mp));
    }

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = { 10, 20, 30, 40, 50 };

        //配列の各要素の値を順番に表示
        Debug.Log("配列の各要素の値を順番に表示:");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示
        Debug.Log("for文を使い、配列の各要素の値を逆順に表示:");
        for (int i= array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //Magic関数を10回使った後に、更にMagic関数を呼び出すと
        //mpが足りないメッセージが表示されることを確認
        Debug.Log("Magic関数を10回使った後に、更にMagic関数を呼び出すとmpが足りないメッセージが表示されることを確認:");
        Boss boss = new Boss();
        for (int i = 0; i < 11; i++)
        {
            Debug.Log(string.Format("{0}ターン目",i+1));
            boss.Magic();
        }
    }

    // Update is called once per frame
    void Update () {

        
	}
}
