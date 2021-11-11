using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] vehicles;

    // Start is called before the first frame update
    void Start()
    {
        // ABSTRACTION
        InvokeRepeating("SpawnVehicles", 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnVehicles()
    {
        int spawnVehicle = Random.Range(0, vehicles.Length);
        int spawnLocation = Random.Range(-20, 21);

        Instantiate(vehicles[spawnVehicle], new Vector3(spawnLocation, 0, -5), vehicles[spawnVehicle].transform.rotation);
    }
}
