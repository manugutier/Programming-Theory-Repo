using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class VehicleCar : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        currentCapacity = 4;
    }

    // Update is called once per frame
    void Update()
    {
        // ABSTRACTION
        Move();
        DestroyVehicle();
    }

    public override void Move()
    {
        // POLYMORPHISM
        speed = 25;
        base.Move();
    }
}
