using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnRandomLocation : MonoBehaviour
{
     public GameObject formiga;
     private Vector2 Min;
     private  Vector2 Max;
     private  float _xAxis;
     private  float _yAxis;
     private Vector2 _randomPosition ;
     public bool _canInstantiate;
     private float timer = 0;
     public float spawnTime = 2f;
     public float destroyTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
         SetRanges();
         
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            Instantiate(formiga, _randomPosition , Quaternion.identity);
            timer = 0;
        }

        

         _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
         _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
         

        _randomPosition = new Vector2(_xAxis, _yAxis);

    }

     private void SetRanges()
     {
         Min = new Vector2(19.7f, -22f); //Random value.
         Max = new Vector2(-20.7f, 22.8f); //Another ramdon value, just for the example.
     }
}

