using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss
{
    private int hp = 100;           // �̗�
    private int power = 25;         // �U����
    private int mp = 53;            // ���@��


    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    // ���@�p�̊֐�
    public void Magic(int mp)
    {
        if (this.mp >= 5)
        {                                                      //mp��5�ȏ�̏ꍇ
            this.mp -= mp;                                     //mp5���炷
            Debug.Log("���@�U���������B�c��MP��" + this.mp);   //�R���\�[���ɕ\��

        }

        else                                                   //mp������Ȃ��ꍇ      
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");   //�R���\�[���ɕ\��
        }
    }

}

public class Test : MonoBehaviour
{




    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };       //�z��array��錾�ƒl�̏�����

        Debug.Log("~~~~����~~~~");

        for (int i = 0; i < array.Length; i++)      //�z��̊e�v�f���J��Ԃ�
        {
            Debug.Log(array[i]);                    //�l��\��
        }

        Array.Reverse(array);                       //�t���ɂ���

        Debug.Log("~~~~�t��~~~~");

        for (int i = 0; i < array.Length; i++)      //�z��̊e�v�f���J��Ԃ�
        {
            Debug.Log(array[i]);                    //�l��\��
        }


        Debug.Log("~~~~���@�U��~~~~");

        Boss lastboss = new Boss();                 //Magic�֐����Ăяo��

        for (int m = 0; m < 10; m++)                //10�񖂖@���g��
        {
            lastboss.Magic(5);
        }

        lastboss.Magic(5);                          //�����Magic�֐����Ăяo��

    }
    // Update is called once per frame
    void Update()
    {

    }

}

