using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(-2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && transform.position.x > -2)
        {
            transform.Translate(-2, 0, 0);
        }
        if((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && transform.position.x < 2)
        {
            transform.Translate(2, 0, 0);
        }
         
    }

   
}
