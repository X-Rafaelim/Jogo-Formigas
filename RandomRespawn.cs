using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRespawn : MonoBehaviour
{


    public GameObject box;
    float randx;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nextSpawn = Time.time + spawnRate;
        randx = Random.Range(-3.24f, 2.89f);
        whereToSpawn = new Vector2(randx, transform.position.y);
        Instantiate(box, whereToSpawn, Quaternion.identity);
        
    }


}
