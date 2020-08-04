using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject target, target2;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    int i = 0;
    //int rand;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (i<5)
        {
            if (Time.time > nextSpawn) 
            {
                nextSpawn = Time.time + spawnRate;
                randX = Random.Range(5f, 30f);
                //rand = Random.(target,target2);
                whereToSpawn = new Vector2 (randX, transform.position.y);
                Instantiate (target, whereToSpawn, Quaternion.identity);
                Instantiate (target2, whereToSpawn, Quaternion.identity);
                i++;
            }
        }
    }
}
