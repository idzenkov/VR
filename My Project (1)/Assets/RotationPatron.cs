using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPatron : MonoBehaviour
{
    public GameObject patron;
    bool flag = false;
    // Update is called once per frame
    void Update()
    {
        if(flag == true) { patron.transform.Rotate(0, 0, 2); }
        else { patron.transform.Rotate(0, 0, 0); }
    }
    public void StartRotate()
    {
        Debug.Log("start");
        flag = true;
        
    }
    public void EndRotate()
    {
        Debug.Log("stop");
        flag = false;
    }

}
