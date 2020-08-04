using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject[] spawnees;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 0f;
    float nextSpawn = 0.0f;
    int i = 0;
    int randomInt;
    
    //int rand;
        
    // Update is called once per frame
    void Update()
    {
        if (i<5)
        {
            if (Time.time > nextSpawn) 
            {
                nextSpawn = Time.time + spawnRate;
                randX = Random.Range(0f, 23f);
                //rand = Random.(target,target2);
                whereToSpawn = new Vector2 (randX, transform.position.y);
                randomInt = Random.Range(0,spawnees.Length);
                Instantiate (spawnees[randomInt], whereToSpawn, Quaternion.identity);
                i++;
            }
        }
    }
}
