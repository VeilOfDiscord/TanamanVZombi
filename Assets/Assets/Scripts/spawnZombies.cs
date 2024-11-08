using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnZombies : MonoBehaviour
{
    [SerializeField] private int numEnemies = 2;
    [SerializeField] private GameObject plane;
    [SerializeField] private GameObject enemies;

    private float plane_x;
    private float plane_z;
    
    void Awake()
    {
        plane_x = plane.GetComponent<MeshRenderer>().bounds.size.x;
        plane_z = plane.GetComponent<MeshRenderer>().bounds.size.z;
    }
    
    void Start()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            spawnZomb();
        }
    }

    private void spawnZomb()
    {
        Vector3 randomSpawn = new Vector3(Random.Range(-plane_x, plane_x), 3, Random.Range(-plane_z, plane_z));
        GameObject zomb = Instantiate(enemies, randomSpawn, Quaternion.identity);
    }

}
