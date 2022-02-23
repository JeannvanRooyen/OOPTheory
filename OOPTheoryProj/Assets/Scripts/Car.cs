using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    // Start is called before the first frame update
    private static int fuelLevel;
    private const int maxFuelLevel = 50;

    private bool engine1IsRunning = false;
    private bool engine2IsRunning = false;

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

    public void StartEngines(bool engine1, bool engine2)
    {
        engine1IsRunning = engine1;
        engine2IsRunning = engine2;
    }

    public void StopEngines(bool engine1, bool engine2)
    {
        engine1IsRunning = !engine1;
        engine2IsRunning = !engine1;
    }

    // Update is called once per frame
    void Update()
    {
        if (engine1IsRunning || engine2IsRunning)
        {
            //Code movement here...
        }
    }
}
