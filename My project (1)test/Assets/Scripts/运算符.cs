using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 运算符 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 算数运算符
        int a = 10;
        int b = 3;
        int c = a + b;
        Debug.Log("c =" + c);
        c = a - b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a / b;
        Debug.Log(c);
        c = a % b;// 余数, % 当应用取余运算符时，如果被除数 > 除数，则返回被除数本身
        Debug.Log(c);
        c = a++;
        Debug.Log(c);// 10先赋值再加 1，所以后面 a 多 1
        Debug.Log(a);// 11
        c = ++a;// 先加1，再赋值
        Debug.Log(c);// 12

        // 关系运算符
        Debug.Log(a > b);
        Debug.Log(a < b);
        Debug.Log(a >= b);
        Debug.Log(a <= b);
        Debug.Log(a == b);
        Debug.Log(a != b);

        // 逻辑运算符
        bool d = true;
        bool e = false;
        Debug.Log(d && e);// 逻辑与，两个都为真才为真
        Debug.Log(d || e);// 逻辑或，一个为真就为真
        Debug.Log(!d);// 逻辑非，取反
        Debug.Log(d ^ e);// 逻辑异或，不同为真，相同为假

        // 三目运算符
        int f = 10;
        int g = 20;
        int h = f > g ? f : g;
        Debug.Log(h);// 20
        h = f < g ? f : g;
        Debug.Log(h);// 10
        h = f == g ? f : g;
        Debug.Log(h);// 20

        // 位运算符
        int i = 10;
        int j = 3;
        Debug.Log(i & j);// 按位与== 2
        Debug.Log(i | j);// 按位或= 11
        Debug.Log(i ^ j);// 按位异或= 9
        Debug.Log(~i);// 按位取反= -11，这里是补码，取反加 1，～i = -i - 1
        uint k = 1;
        Debug.Log(~k);// 按位取反= 4294967294,这里取的是无符号整数，所以不用补码计算，而是直接取反
        Debug.Log(i << 2);// 左移 2 位= 40
        Debug.Log(i >> 2);// 右移 2 位= 2
        Debug.Log(i << 1);// 左移 1 位，相当于乘 2= 20
    }

    // Update is called once per frame
    void Update()
    {

    }
}
