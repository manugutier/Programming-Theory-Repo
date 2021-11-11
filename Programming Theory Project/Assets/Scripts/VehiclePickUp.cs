using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiclePickUp : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        currentCapacity = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyVehicle();
    }

    public override void Move()
    {
        speed = 20;
        base.Move();
    }
}
