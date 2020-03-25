using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by a monster. He growls at you");
    }
}
