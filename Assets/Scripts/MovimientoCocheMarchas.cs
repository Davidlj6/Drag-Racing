using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoCocheMarchas : MonoBehaviour
{
    Rigidbody2D rb2D;
    public CambioMarchas marchas;
    private const float ZERO_SPEED_ANGLE = 170;
    private const float MAX_SPEED_ANGLE = 37;
    int marcador = 1;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        //Marcha1
        if (Input.GetMouseButtonDown(0) && marcador == 1)
        {
            rb2D = GetComponent<Rigidbody2D>();
            //Adelantado
            if (marchas.GetSpeedRotation() > 58)
            {
                rb2D.velocity = new Vector2(20f, rb2D.velocity.y);
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 45)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 58 || marchas.GetSpeedRotation() >= 45)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            marcador = 2;
        }

        //Marcha2
        else if (Input.GetMouseButtonDown(0) && marcador == 2)
        {
            rb2D = GetComponent<Rigidbody2D>();
            //Adelantado
            if (marchas.GetSpeedRotation() > 53)
            {
                rb2D.velocity = new Vector2(20f, rb2D.velocity.y);
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 45)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 53 || marchas.GetSpeedRotation() >= 45)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            marcador = 3;
        }

        //Marcha3
        else if (Input.GetMouseButtonDown(0) && marcador == 3)
        {
            rb2D = GetComponent<Rigidbody2D>();
            //Adelantado
            if (marchas.GetSpeedRotation() > 50)
            {
                rb2D.velocity = new Vector2(20f, rb2D.velocity.y);
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 45)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 50 || marchas.GetSpeedRotation() >= 45)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            marcador = 4;
        }

        //Marcha4
        else if (Input.GetMouseButtonDown(0) && marcador == 4)
        {
            rb2D = GetComponent<Rigidbody2D>();
            //Adelantado
            if (marchas.GetSpeedRotation() > 47)
            {
                rb2D.velocity = new Vector2(20f, rb2D.velocity.y);
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 42)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 47 || marchas.GetSpeedRotation() >= 42)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            marcador = 5;
        }

        //Marcha5
        else if (Input.GetMouseButtonDown(0) && marcador == 5)
        {
            rb2D = GetComponent<Rigidbody2D>();
            //Adelantado
            if (marchas.GetSpeedRotation() > 44)
            {
                rb2D.velocity = new Vector2(20f, rb2D.velocity.y);
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 43)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 44 || marchas.GetSpeedRotation() >= 43)
            {
                rb2D.velocity = new Vector2(30f, rb2D.velocity.y);
            }
            marcador = 6;
        }
    }
}
