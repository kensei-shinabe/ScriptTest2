using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()

    {
        // 要素数5の配列を初期化する
        int[] array = { 1, 3, 5, 7, 9 };
        //　配列を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        // 配列を逆順に表示する
        for (int i = 4; i >= 0; i--)

        {
            Debug.Log(array[i]);
        }

     }

}

    
