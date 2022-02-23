using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : Vehicle
{
    private static int fuelLevel;
    private const int maxFuelLevel = 500;
    private bool engineIsRunning = false;
    public float maxAltitude;
    public float currentAltitude;

    public bool AltitudeWarning
    {
        get
        {
            return currentAltitude >= maxAltitude;
        }
    }

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

    public void StartEngine()
    {
        engineIsRunning = true;
    }

    public void StopEngine()
    {
        engineIsRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (engineIsRunning)
        {
            //Code movement here...
        }
    }
}
