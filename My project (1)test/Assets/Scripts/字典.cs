using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 字典 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //定义字典
        Dictionary<string, int> dic = new Dictionary<string, int>();
        //添加元素
        dic.Add("a", 1);
        dic.Add("b", 2);
        dic.Add("c", 3);
        //遍历
        foreach (var item in dic)//var item 是 KeyValuePair<string, int> 类型
        {
            Debug.Log(item.Key + " " + item.Value);
            Debug.LogFormat("Key:{0},Value:{1}", item.Key, item.Value);
        }
        //只遍历 key
        foreach (var item in dic.Keys)
        {
            Debug.Log(item);
        }
        //只遍历 value
        foreach (var item in dic.Values)
        {
            Debug.Log(item);
        }
        //删除
        //dic.Remove("a");
        //判断是否存在
        if (dic.ContainsKey("a"))
        {
            Debug.Log("存在");
        }
        else
        {
            Debug.Log("不存在");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
