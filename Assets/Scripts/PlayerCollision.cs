using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public Cronometro cronometro;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Caja"))
        {
            cronometro.pararT();
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
