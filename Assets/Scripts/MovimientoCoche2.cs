using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche2 : MonoBehaviour {

    Rigidbody2D rb2D;

    public ControladorEstado ControladorEstado;

    int estadoC2 = 0;

    void Start()
    {
        estadoC2 = 0;
        rb2D = GetComponent<Rigidbody2D>();
        int estado = ControladorEstado.getEstado();
        Debug.Log(estado);
        if (estado == 1)
        {
            estadoC2 = 1;
        }
        if (estado == 2)
        {
            estadoC2 = 2;
        }
        if (estado == 3)
        {
            estadoC2 = 3;
        }
    }

    void Update() 
    {
        if (estadoC2 == 1)
        {
            rb2D.velocity = new Vector2(80f, rb2D.velocity.y);
        }
        if (estadoC2 == 2)
        {
            rb2D.velocity = new Vector2(40f, rb2D.velocity.y);
        }
        if (estadoC2 == 3)
        {
            rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
        }
    }
}
