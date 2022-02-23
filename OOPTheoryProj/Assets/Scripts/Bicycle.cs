using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bicycle : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        MaxSpeed = 10;
        HasDoors = false;
        WheelCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
