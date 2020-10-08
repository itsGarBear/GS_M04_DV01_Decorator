using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicComputer : IComputer
{
    private float m_BasicCost = 200f;

    public float GetCost()
    {
        return m_BasicCost;
    }
}
