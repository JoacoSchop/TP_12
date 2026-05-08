using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliceRota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float velocidadRotacion = 100f;

    void Update()
    {
        transform.Rotate(velocidadRotacion * Time.deltaTime, 0, 0);
    }
}
