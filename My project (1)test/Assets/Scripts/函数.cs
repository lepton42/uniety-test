using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 函数 : MonoBehaviour
{
    //函数
    public void Test()
    {
        Debug.Log("Test");
    }
    //带参数的函数
    public void Test2(int a)
    {
        Debug.Log(a);
    }
    //带返回值的函数
    public int Test3(int a)
    {
        return a;
    }
    //带参数和返回值的函数
    public int Test4(int a)
    {
        return a;
    }
    //函数的重载，与参数类型和参数个数，顺序有关，与返回值无关
    public void Test(int a)
    {
        Debug.Log(a);
    }
    public void Test(float a)
    {
        Debug.Log(a);
    }
    //参数的传递
    public void Test5(int a, int b)
    {
        Debug.Log(a + b);
    }
    //值传递
    public void Test6(int a)
    {
        a = 10;
        Debug.Log(a);
    }
    //函数中值传递的参数，不会影响函数外部的值
    //结构体是浅拷贝，类是深拷贝

    //引用传递
    public void Test7(ref int a)//ref关键字，表示引用传递，函数中修改的值会影响到函数外部的值，此时形参和实参指向同一个内存地址。out关键字，表示输出参数，函数中修改的值会影响到函数外部的值，此时形参和实参指向同一个内存地址，但是实参必须先赋值，不能为空，必须初始化。
    {
        a = 100;
        Debug.Log(a);
    }

    // Start is called before the first frame update
    void Start()
    {
        Test();
        Test2(10);
        Test3(10);
        Test4(10);
        Test(10);
        Test(10.0f);
        Test5(10, 20);
        int a = 10;
        Test6(a);
        Debug.Log(a);
        Test7(ref a);
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
