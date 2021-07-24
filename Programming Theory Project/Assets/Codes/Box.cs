using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Box : Spawner
{   
    //POLYMORPHISM
    public override void SpawnObject()
    {
        objectToSpawn = spawnables[1];
    }
    // Start is called before the first frame update
    void Start()
    {
        base.IncreaseCount();
        //INHERITANCE
        SpawnObject();
       
    }

}
