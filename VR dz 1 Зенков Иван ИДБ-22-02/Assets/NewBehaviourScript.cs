using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.Newtonsoft.Json.Bson;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Testobj;

    bool i = false;
    public void Switch()
    {
        if (i == true)
        {
            Testobj.SetActive(false);
            i = false;
        }
        else
        {
            Testobj.SetActive(true);
            i= true;
        }

    }
}
