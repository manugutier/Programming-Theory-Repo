using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class VehicleBus : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        currentCapacity = 10;
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
        speed = 15;
        base.Move();
    }
}
