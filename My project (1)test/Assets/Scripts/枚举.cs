using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 枚举 : MonoBehaviour
{
    // Start is called before the first frame update
    // 枚举

    // 枚举类型
    // 枚举类型是一种值类型，它包含一组命名常量
    // 枚举类型使用enum关键字来声明
    // 枚举类型的每个成员都对应一个整数值
    // 枚举类型的默认值是第一个成员的值，默认值是0
    // 枚举类型的值可以通过枚举成员来访问
    enum Day
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
    void Start()
    {
        Debug.Log((int)Day.monday);
        Debug.Log((int)Day.tuesday);
        Debug.Log((int)Day.wednesday);

        Debug.Log(Day.monday);
        Debug.Log(Day.tuesday);
        Debug.Log(Day.wednesday.ToString());
        Debug.Log((Day)5);

        Day test = (Day)Enum.Parse(typeof(Day), "monday");
        Debug.Log(test);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
