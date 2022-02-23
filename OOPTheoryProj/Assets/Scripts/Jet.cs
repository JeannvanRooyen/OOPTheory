using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : Vehicle
{
    private static int fuelLevel;
    private const int maxFuelLevel = 500;
    // Start is called before the first frame update
    void Start()
    {
        MaxSpeed = 1000;
        HasDoors = true;
        WheelCount = 3;
    }

    public void Refuel(int value)
    {
        fuelLevel += value;
        if (fuelLevel > maxFuelLevel)
        {
            fuelLevel = maxFuelLevel;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
