using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected float speed;

    // ENCAPSULATION
    private int capacity = 1;
    public int currentCapacity
    {
        get { return capacity; }
        set { 
                if (value <= 0)
                {
                    Debug.LogError("You can't set this value to zero or a negative number");
                } else
                {
                    capacity = value;
                }
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnMouseDown()
    {
        Debug.Log("Vehicle's properties:\nSpeed: " + speed + " | Capacity: " + capacity);
    }

    public virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    protected void DestroyVehicle()
    {
        if (transform.position.z > 50)
        {
            Destroy(gameObject);
        }
    }
}
