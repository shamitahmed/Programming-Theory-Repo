using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Ball : Spawner
{  
    //POLYMORPHISM
    public override void SpawnObject()
    {
        //spawn 4 balls
        objectToSpawn = spawnables[0];
        Instantiate(objectToSpawn, new Vector3(3, 2, 3), Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        base.IncreaseCount();
        //INHERITANCE
        if (spawnCount < 5)
        {
            SpawnObject();
            
        }
            
    }
  
}
