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
    // Start is called before the first frame update
    void Start()
    {
         SetRanges();
    }

    // Update is called once per frame
    void Update()
    {
         _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
         _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
         

        _randomPosition = new Vector2(_xAxis, _yAxis);

    }

     private void SetRanges()
     {
         Min = new Vector2(19.7f, -22f); //Random value.
         Max = new Vector2(-20.7f, 22.8f); //Another ramdon value, just for the example.
     }
     private void InstantiateRandomObjects()
     {
         if (_canInstantiate)
         {
             Instantiate(formiga, _randomPosition , Quaternion.identity);
         }
}
}
