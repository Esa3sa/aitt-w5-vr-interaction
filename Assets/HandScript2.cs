using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        SteamVR_Input.GetStateDown("GrabPinch", SteamVR_Input_Sources.Any);

    }
}
