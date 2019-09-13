using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ViveGrabShoot : MonoBehaviour
{
    public SteamVR_Action_Boolean shoot;


    private void Start()
    {
        shoot = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("_default", "GrabPinch");

        if (shoot == null)
        {
            Debug.Log("error");
        }
    }

    private void Update()
    {
        if (shoot.GetStateDown(SteamVR_Input_Sources.Any))
        {
            Debug.Log("shoot");
        }
    }
}
