using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected float speed;

    private int minimumCapacity = 1;
    public int currentCapacity
    {
        get { return minimumCapacity; }
        set { minimumCapacity = value; }
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
        Debug.Log("Vehicle's properties:\nSpeed: " + speed + "\nCapacity: " + currentCapacity);
    }

    public virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
