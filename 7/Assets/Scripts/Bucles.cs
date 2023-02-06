using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public int value = 10;
    public string names;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i<=10; i++)
        {
            Debug.Log($"{value} x {1} = {value * i}");
        }
        for(int i = 0; i < names.Length; i++)
        {
            Debug.Log(name i);
        }
    }
}



