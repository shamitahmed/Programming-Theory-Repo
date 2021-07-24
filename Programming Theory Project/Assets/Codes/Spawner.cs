using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int spawnCount;
    //ENCAPSULATION
    [SerializeField] private GameObject[] m_spawnables;
    public GameObject[] spawnables
    {
        get { return m_spawnables; }
        set { m_spawnables = value; }
    }
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }
    //POLYMORPHISM
    public virtual void SpawnObject()
    {
        //spawn 1 ball
        objectToSpawn = spawnables[0];
        Instantiate(objectToSpawn, new Vector3(3, 2, 3), Quaternion.identity);
        IncreaseCount();
    }
    public virtual void IncreaseCount()
    {
        spawnCount++;
    }
}
