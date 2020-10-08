using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithMonitor : ComputerDecorator
{
    private float m_MonitorCost = 200f;
    public WithMonitor(IComputer comp) : base(comp) { }

    public override float GetCost()
    {
        return base.GetCost() + m_MonitorCost;
    }
}
