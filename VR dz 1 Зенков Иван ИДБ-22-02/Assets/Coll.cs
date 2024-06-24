using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Coll : MonoBehaviour
{
    public GameObject Terrain;
    public GameObject Cube;

    public Text text;
    string str;
    int a;
    
    public void OnCollisionEnter(Collision coll)
    {
        a = Int32.Parse(text.text);
        print(a);
        a--;
        str= a.ToString();
        print(str);
        text.text = str;
    }
    
}
