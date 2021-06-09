using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalidaCoche2 : MonoBehaviour
{
    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        StartCoroutine("EsperarSalida");
    }

    IEnumerator EsperarSalida()
    {
        yield return new WaitForSeconds(5);
        rb2D.velocity = new Vector2(600f, rb2D.velocity.y);
    }
}
