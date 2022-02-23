using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    // Start is called before the first frame update
    private static int fuelLevel;
    private const int maxFuelLevel = 50;
    void Start()
    {
        MaxSpeed = 100;
        HasDoors = true;
        WheelCount = 4;
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
