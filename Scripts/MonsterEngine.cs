using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEngine : IEngine
{
    public void StartEngine()
    {
        RoarsLoudly();
        Debug.Log("Engine started");
    }

    private void RoarsLoudly()
    {
        Debug.Log("The monster engine roars at you");
    }
}
