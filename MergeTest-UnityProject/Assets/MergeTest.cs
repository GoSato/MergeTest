using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeTest : MonoBehaviour
{
    private bool _isTest = true;
    private int _maxNum = 5;

    private void TestA()
    {
        Debug.Log("TestA : This is master brunch");
    }

    private void TestB()
    {
        for(int i = 0; i < _maxNum; i++)
        {
            Debug.Log(i);
        }
    }
}
