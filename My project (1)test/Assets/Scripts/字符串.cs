using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 字符串 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //字符串
        string str = "Hello World";
        Debug.Log(str);

        //字符串拼接
        string str1 = "Hello";
        string str2 = "World";
        string str3 = str1 + str2;
        Debug.Log(str3);

        //字符串大小写转换
        string str4 = "Hello World";
        string str5 = str4.ToUpper();
        Debug.Log(str5);
        string str6 = str4.ToLower();
        Debug.Log(str6);

        //比较字符串
        string str7 = "Hello World";
        string str8 = "hello world";
        int result = string.Compare(str7, str8, true);//true 忽略大小写，相等返回0，不相等返回1
        Debug.Log(result);

        //删除空格
        string str9 = "  Hello World  ";
        string str10 = str9.Trim();//移除首尾空格
        Debug.Log(str10);
        string str11 = str9.TrimStart();//移除首部空格
        Debug.Log(str11);
        string str12 = str9.TrimEnd();//移除尾部空格
        Debug.Log(str12);
        string str13 = str9.Replace(" ", "");//替换空格，删除空格
        Debug.Log(str13);
        string str14 = str9.Replace(" ", "-");//替换空格为-
        Debug.Log(str14);

        //字符串分割
        string str15 = "Hello World";
        string[] str16 = str15.Split(' ');//以空格分割字符串
        Debug.Log(str16[0]);
        Debug.Log(str16[1]);
        string str17 = "Hello,World";
        string[] str18 = str17.Split(',');//以逗号分割字符串
        string[] str19 = str17.Split(new char[] { ',' });//以逗号分割字符串
        Debug.Log(str19[0]);
        Debug.Log(str19[1]);
        Debug.Log(str18[0]);
        Debug.Log(str18[1]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
