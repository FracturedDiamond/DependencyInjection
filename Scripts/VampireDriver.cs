﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VampireDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by a vampire");
    }
}
