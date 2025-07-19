using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 变量 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // int a = 1;
        int a = 10, b = 20; //同时声明多个变量
        Debug.Log("a = " + a.ToString() + ",b = " + b.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
