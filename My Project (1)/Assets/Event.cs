using UnityEngine;
using Valve.VR.InteractionSystem;

public class Events : MonoBehaviour
{
    GameObject active_obj;
    public void OnPress(Hand hand)
    {
        Debug.Log("SteamVR Button pressed!");
    }

    public void OnCustomButtonPress()
    {
        Debug.Log("We pushed our custom button!");

    }
}