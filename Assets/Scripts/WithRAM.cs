using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithRAM : ComputerDecorator
{
    private float m_MonitorCost = 50f;
    public WithRAM(IComputer comp) : base(comp) { }

    public override float GetCost()
    {
        return base.GetCost() + m_MonitorCost;
    }
}
