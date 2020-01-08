using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision name =" + col.gameObject.name);
        if (col.gameObject.name == "Recolhedora")
        {
            Destroy(col.gameObject);
        }

    }

}
