using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 判断语句 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if语句
        int a = 1;
        if (a == 1)
        {
            Debug.Log("a等于1");
        }
        else if (a == 2)
        {
            Debug.Log("a等于2");
        }
        else
        {
            Debug.Log("a不等于1也不等于2");
        }

        // switch语句
        int b = 1;
        switch (b)
        {
            case 1:
                {
                    Debug.Log("b等于1");
                    break;
                }
            case 2:
                {
                    Debug.Log("b等于2");
                    break;
                }
            default:
                {
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
