using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Text text;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            IComputer comp = new BasicComputer();
            text.text = "Basic Cost: " + comp.GetCost();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            IComputer comp = new BasicComputer();
            comp = new WithCPU(comp);
            text.text = "CPU Cost: " + comp.GetCost();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            IComputer comp = new BasicComputer();
            comp = new WithGPU(comp);
            text.text = "GPU Cost: " + comp.GetCost();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            IComputer comp = new BasicComputer();
            comp = new WithMonitor(comp);
            text.text = "Monitor Cost: " + comp.GetCost();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            IComputer comp = new BasicComputer();
            comp = new WithRAM(comp);
            text.text = "RAM Cost: " + comp.GetCost();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            IComputer comp = new BasicComputer();
            comp = new WithRAM(new WithGPU(new WithCPU(new WithMonitor(comp))));
            text.text = "All Parts Cost: " + comp.GetCost();
        }
    }
}
