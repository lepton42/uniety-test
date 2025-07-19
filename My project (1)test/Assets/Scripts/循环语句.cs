using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 循环语句 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for 循环
        int i;
        for (i = 0; i < 10; i++)
        {
            Debug.Log("for循环" + i);
        }
        Debug.Log("for循环结束" + i);


        //while 循环
        i = 0;
        while (i < 10)
        {
            Debug.Log("while循环" + i);
            i++;
        }
        Debug.Log("while循环结束" + i);

        //do while 循环
        i = 0;
        do
        {
            Debug.Log("do while循环" + i);
            i++;
        }
        while (i < 10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
