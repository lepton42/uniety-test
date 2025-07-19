using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 数组 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //一维数组初始化
        int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
        int[] arr3 = { 1, 2, 3, 4, 5 };

        Debug.LogFormat("arr1[0] = {0}", arr1[0]);
        Debug.LogFormat("arr2[0] = {0}", arr2[0]);
        Debug.LogFormat("arr3[0] = {0}", arr3[0]);
        //数组的长度格式化
        Debug.LogFormat("arr1.Length = {0}", arr1.Length);
        Debug.LogFormat("arr2.Length = {0}", arr2.Length);
        Debug.LogFormat("arr3.Length = {0}", arr3.Length);
        //三个写在一起
        Debug.LogFormat("arr1.Length = {0}, arr2.Length = {1}, arr3.Length = {2}", arr1.Length, arr2.Length, arr3.Length);

        //数组的输出
        for (int i = 0; i < arr1.Length; i++)
        {
            Debug.LogFormat("arr1[{0}] = {1}", i, arr1[i]);
        }
        //二维数组初始化
        int[,] arr4 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        Debug.LogFormat("arr4[0, 0] = {0}", arr4[0, 0]);
        Debug.LogFormat("arr4[0, 1] = {0}", arr4[0, 1]);
        Debug.LogFormat("arr4[0, 2] = {0}", arr4[0, 2]);
        Debug.LogFormat("arr4[1, 0] = {0}", arr4[1, 0]);
        Debug.LogFormat("arr4[1, 1] = {0}", arr4[1, 1]);
        Debug.LogFormat("arr4[1, 2] = {0}", arr4[1, 2]);
        //二维数组的长度
        Debug.LogFormat("arr4.GetLength(0) = {0}", arr4.GetLength(0));
        Debug.LogFormat("arr4.GetLength(1) = {0}", arr4.GetLength(1));
        //二维数组的输出
        for (int i = 0; i < arr4.GetLength(0); i++)
        {
            for (int j = 0; j < arr4.GetLength(1); j++)
            {
                Debug.LogFormat("arr4[{0}, {1}] = {2}", i, j, arr4[i, j]);
            }
        }

        //数组的排序
        int[] arr5 = { 5, 4, 3, 2, 1 };
        //System.Array.Sort(arr5);
        for (int i = 0; i < arr5.Length; i++)
        {
            Debug.LogFormat("arr5[{0}] = {1}", i, arr5[i]);
        }

        //冒泡排序
        for (int i = 0; i < arr5.Length - 1; i++)
        {
            for (int j = 0; j < arr5.Length - 1 - i; j++)
            {
                if (arr5[j] > arr5[j + 1])
                {
                    int temp = arr5[j]; //交换
                    arr5[j] = arr5[j + 1];
                    arr5[j + 1] = temp;
                }
            }
        }
        for (int i = 0; i < arr5.Length; i++)
        {
            Debug.LogFormat("arr5[{0}] = {1}", i, arr5[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
