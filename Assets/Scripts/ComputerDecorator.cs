using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class ComputerDecorator : IComputer
{
    protected IComputer m_DecoratedComputer;

    public ComputerDecorator(IComputer comp)
    {
        m_DecoratedComputer = comp;
    }
    public virtual float GetCost()
    {
        return m_DecoratedComputer.GetCost();
    }
}
