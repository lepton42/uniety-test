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
        list.RemoveAt(0);
        //删除数组
        list.RemoveRange(0, 2);
        //在某位置添加
        list.Insert(0, 10);
        //遍历
        foreach (int i in list)
        {
            Debug.Log(i);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
