using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 结构体 : MonoBehaviour
{
    // 结构体
    // 结构体的默认无参构造函数不可以显式声明，但可以写有参构造函数。如果结构体存在有参构造函数，则默认无参构造函数失效，且必须在构造方法返回前对结构体内的属性（变量）显式赋值才可以

    struct Person//结构体不能显式声明构造函数，不能声明析构函数，不能声明抽象方法，不能声明虚拟方法，不能声明索引器，不能声明默认成员函数，不能声明保护成员或只读成员，无参构造函数是隐式声明的，所有成员默认都是公共的
    {
        public string name;
        public int age;
        public float height;
        public float weight;
        public Person(string name, int age, float height, float weight)//有参构造函数
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        public void Say()
        {
            Debug.Log("我叫" + name + "，今年" + age + "岁，身高" + height + "，体重" + weight);
        }
        static void Test()
        {
            Debug.Log("结构体不能声明静态成员");//静态构造函数不允许出现访问修饰符。静态构造函数必须时无参的
            Debug.Log("静态构造函数执行");//在调用结构体方法时，静态构造函数会自动执行
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Person p1;
        p1.name = "张三";
        p1.age = 18;
        p1.height = 1.75f;
        p1.weight = 70.0f;
        p1.Say();
        Debug.Log(p1.name);

        Person p2 = new Person();
        p2.name = "李四";
        p2.age = 20;
        p2.height = 1.80f;
        p2.weight = 75.0f;
        p2.Say();
        Debug.Log(p2.name);

        Person p3 = new Person("王五", 22, 1.85f, 80.0f);
        Debug.Log(p3.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
