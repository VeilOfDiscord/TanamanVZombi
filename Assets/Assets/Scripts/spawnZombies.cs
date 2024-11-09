using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnZombies : MonoBehaviour
{
    [SerializeField] private int numEnemies = 2;
    [SerializeField] private GameObject[] enemies;
    void Start()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            spawnZomb();
        }
    }

    private void spawnZomb()
    {
        // Vector3 randomSpawn = new Vector3(Random.Range(-plane_x, plane_x), 3, Random.Range(-plane_z, plane_z));
        Vector3 randomSpawn = new Vector3(Random.Range(-25,25), 3, Random.Range(-25,25));
        int randomZombie = Random.Range(0, enemies.Length);
        GameObject zomb = Instantiate(enemies[randomZombie], randomSpawn, Quaternion.identity);
    }

}
