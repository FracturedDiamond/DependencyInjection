using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearEngine : IEngine
{
    public void StartEngine()
    {
        GetReadyToPedal();
        Debug.Log("Engine started");
    }

    private void GetReadyToPedal()
    {
        Debug.Log("One foot on the pedal");
    }
}
