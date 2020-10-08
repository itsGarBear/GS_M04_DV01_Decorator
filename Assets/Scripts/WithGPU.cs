using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithGPU : ComputerDecorator
{
    private float m_GPUCost = 450f;

    public WithGPU(IComputer comp) : base(comp) { }

    public override float GetCost()
    {
        return base.GetCost() + m_GPUCost;
    }
}
