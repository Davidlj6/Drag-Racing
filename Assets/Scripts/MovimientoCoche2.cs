using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche2 : MonoBehaviour {

    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {

        rb2D.velocity = new Vector2(50f, rb2D.velocity.y);
           
    }
}
