using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaMovimientoCoches : MonoBehaviour
{

    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2D.velocity = new Vector2(800f, rb2D.velocity.y);
    }
}
