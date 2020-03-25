using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetEngine : IEngine
{
    public void StartEngine()
    {
        ActivateJetStream();
        Debug.Log("Engine Started");
    }

    private void ActivateJetStream()
    {
        Debug.Log("Jet Stream Activated");
    }
}
