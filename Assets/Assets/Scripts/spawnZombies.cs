using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnZombies : MonoBehaviour
{
    [SerializeField] private int numEnemies = 2;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] public GameObject Menu;
    [SerializeField] private int numTrees; 
    public int score = 0;
    private bool gameStarted = false;
    void Start()
    {
        Debug.Log("Load in game");
        // startGame();
    }

    void Update()
    {
        if(gameStarted == true)
        {
            Debug.Log("Game has started");
            Debug.Log("Score: " + score);

            if(score == numTrees)
            {
                gameStarted = false;
                Menu.SetActive(true);
                Debug.Log("Game Over!");
            }
        }
    }

    private void spawnZomb()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            // Vector3 randomSpawn = new Vector3(Random.Range(-plane_x, plane_x), 3, Random.Range(-plane_z, plane_z));
            Vector3 randomSpawn = new Vector3(Random.Range(-25,25), 3, Random.Range(-25,25));
            int randomZombie = Random.Range(0, enemies.Length);
            GameObject zomb = Instantiate(enemies[randomZombie], randomSpawn, Quaternion.identity);
        }
    }

    public void startGame()
    {
        gameStarted = true;
        Menu.SetActive(false);
        spawnZomb();
    }

}
