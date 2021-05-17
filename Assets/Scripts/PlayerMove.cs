using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {  
    
    public float runSpeed = 100;
    Rigidbody2D rb2D;

    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb2D.velocity = new Vector2(runSpeed*2, rb2D.velocity.y);
        }

        else if (Input.GetKey(KeyCode.DownArrow)) {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
        }

        else {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
    }
}
