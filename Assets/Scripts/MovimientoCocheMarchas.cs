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

    public GameObject TextoFlotanteMalCambio;
    public GameObject TextoFlotanteCambioPerfecto;
    public GameObject TextoFlotanteBuenCambio;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Debug.Log(marchas.GetSpeedRotation());
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
                if (TextoFlotanteMalCambio)
                {
                    MostrarTextoMalCambio();
                }
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 58 || marchas.GetSpeedRotation() >= 45)
            {
                rb2D.velocity = new Vector2(64f, rb2D.velocity.y);
                if (TextoFlotanteCambioPerfecto)
                {
                    MostrarTexoCambioPerfecto();
                }
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 45)
            {
                rb2D.velocity = new Vector2(43f, rb2D.velocity.y);
                if (TextoFlotanteBuenCambio)
                {
                    MostrarTextoBuenCambio();
                }
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
                if (TextoFlotanteMalCambio)
                {
                    MostrarTextoMalCambio();
                }
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 53 || marchas.GetSpeedRotation() >= 45)
            {
                rb2D.velocity = new Vector2(64f, rb2D.velocity.y);
                if (TextoFlotanteCambioPerfecto)
                {
                    MostrarTexoCambioPerfecto();
                }
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 45)
            {
                rb2D.velocity = new Vector2(43f, rb2D.velocity.y);
                if (TextoFlotanteBuenCambio)
                {
                    MostrarTextoBuenCambio();
                }
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
                if (TextoFlotanteMalCambio)
                {
                    MostrarTextoMalCambio();
                }
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 50 || marchas.GetSpeedRotation() >= 45)
            {
                rb2D.velocity = new Vector2(64f, rb2D.velocity.y);
                if (TextoFlotanteCambioPerfecto)
                {
                    MostrarTexoCambioPerfecto();
                }
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 45)
            {
                rb2D.velocity = new Vector2(43f, rb2D.velocity.y);
                if (TextoFlotanteBuenCambio)
                {
                    MostrarTextoBuenCambio();
                }
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
                if (TextoFlotanteMalCambio)
                {
                    MostrarTextoMalCambio();
                }
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 47 || marchas.GetSpeedRotation() >= 42)
            {
                rb2D.velocity = new Vector2(64f, rb2D.velocity.y);
                if (TextoFlotanteCambioPerfecto)
                {
                    MostrarTexoCambioPerfecto();
                }
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 42)
            {
                rb2D.velocity = new Vector2(43f, rb2D.velocity.y);
                if (TextoFlotanteBuenCambio)
                {
                    MostrarTextoBuenCambio();
                }
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
                if (TextoFlotanteMalCambio)
                {
                    MostrarTextoMalCambio();
                }
            }
            //Perfecta
            else if (marchas.GetSpeedRotation() <= 44 || marchas.GetSpeedRotation() >= 43)
            {
                rb2D.velocity = new Vector2(64f, rb2D.velocity.y);
                if (TextoFlotanteCambioPerfecto)
                {
                    MostrarTexoCambioPerfecto();
                }
            }
            //Atrasado
            else if (marchas.GetSpeedRotation() < 43)
            {
                rb2D.velocity = new Vector2(43f, rb2D.velocity.y);
                if (TextoFlotanteBuenCambio)
                {
                    MostrarTextoBuenCambio();
                }

            }
            marcador = 6;
        }
    }

    public void MostrarTextoMalCambio()
    {
        GameObject textoMalCambio = Instantiate(TextoFlotanteMalCambio);
        textoMalCambio.transform.position = new Vector3(1357, 385, -3);
    }

    public void MostrarTexoCambioPerfecto()
    {
        GameObject textoCambioPerfecto = Instantiate(TextoFlotanteCambioPerfecto);
        textoCambioPerfecto.transform.position = new Vector3(1357, 385, -3);
    }

    public void MostrarTextoBuenCambio()
    {
        GameObject textoBuenCambio = Instantiate(TextoFlotanteBuenCambio);
        textoBuenCambio.transform.position = new Vector3(1357, 385, -3);
    }
}
