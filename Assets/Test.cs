using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss
{
    private int hp = 100;           // 体力
    private int power = 25;         // 攻撃力
    private int mp = 53;            // 魔法力


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

    // 魔法用の関数
    public void Magic(int mp)
    {
        if (this.mp >= 5)
        {                                                      //mpが5以上の場合
            this.mp -= mp;                                     //mp5減らす
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);   //コンソールに表示

        }

        else                                                   //mpが足りない場合      
        {
            Debug.Log("MPが足りないため、魔法が使えない。");   //コンソールに表示
        }
    }

}

public class Test : MonoBehaviour
{




    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };       //配列arrayを宣言と値の初期化

        Debug.Log("~~~~順番~~~~");

        for (int i = 0; i < array.Length; i++)      //配列の各要素分繰り返す
        {
            Debug.Log(array[i]);                    //値を表示
        }

        Array.Reverse(array);                       //逆順にする

        Debug.Log("~~~~逆順~~~~");

        for (int i = 0; i < array.Length; i++)      //配列の各要素分繰り返す
        {
            Debug.Log(array[i]);                    //値を表示
        }


        Debug.Log("~~~~魔法攻撃~~~~");

        Boss lastboss = new Boss();                 //Magic関数を呼び出し

        for (int m = 0; m < 10; m++)                //10回魔法を使う
        {
            lastboss.Magic(5);
        }

        lastboss.Magic(5);                          //さらにMagic関数を呼び出す

    }
    // Update is called once per frame
    void Update()
    {

    }

}

