using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private int wheelCount;
    public int WheelCount
    {
        get { return wheelCount; }
        set { wheelCount = value; }
    }

    private float maxSpeed;
    public float MaxSpeed
    {
        get { return maxSpeed; }
        set { maxSpeed = value; }
    }

    private bool hasDoors;
    public bool HasDoors
    {
        get { return hasDoors; }
        set { hasDoors = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
