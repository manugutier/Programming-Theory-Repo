using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class VehiclePickUp : Vehicle
{
    void Start()
    {
        currentCapacity = 2;
    }

    void Update()
    {
        // ABSTRACTION
        Move();
        DestroyVehicle();
    }

    public override void Move()
    {
        // POLYMORPHISM
        speed = 20;
        base.Move();
    }
}
