using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Move();
        DestroyVehicle();
    }

    public override void Move()
    {
        speed = 25;
        base.Move();
    }
}
