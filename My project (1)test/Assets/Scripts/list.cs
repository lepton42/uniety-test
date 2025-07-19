using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //声明一个 list
        List<int> list = new List<int>();
        //添加元素
        list.Add(1);
        list.Add(2);
        list.Add(3);
        //添加数组
        list.AddRange(new int[] { 4, 5, 6 });
        //删除元素
        //list.RemoveAt(0);
        //删除数组
        //list.RemoveRange(0, 2);
        //在某位置添加
        list.Insert(0, 10);
        //遍历
        foreach (int i in list)
        {
            Debug.Log(i);
        }
        //数组的反转
        list.Reverse();
        //数组的排序
        list.Sort();
        //数组的清空
        //list.Clear();
        //list 元素数量
        Debug.Log(list.Count);
        //list string 类型
        List<string> list2 = new List<string>();
        list2.Add("a");
        list2.Add("b");
        list2.Add("c");
        foreach (string i in list2)
        {
            Debug.Log(i);
        }
        //查询
        Debug.Log(list2.Contains("a"));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
