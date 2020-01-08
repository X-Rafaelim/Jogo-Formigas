using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class AiFormiga : MonoBehaviour
{
    
    public float speed;

    private Transform target;
    

    void Start()
    {
        target = GameObject.Find("Recolhedora").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
