using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithCPU : ComputerDecorator
{
    private float m_CPUCost = 250f;

    public WithCPU(IComputer comp) : base(comp) { }

    public override float GetCost()
    {
        return base.GetCost() + m_CPUCost;
    }
}
