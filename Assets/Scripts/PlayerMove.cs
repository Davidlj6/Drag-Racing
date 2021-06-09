using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    //public float runSpeed = 600;
    Rigidbody2D rb2D;
    public Marcador marcador;
    bool arrancar;
    int salida;

    public GameObject TextoFlotanteMalaSalida;
    public GameObject TextoFlotanteSalidaPerfecta;
    public GameObject TextoFlotanteBuenaSalida;


    void Start()
    {
        arrancar = false;
        StartCoroutine("Esperar");
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(5);
        arrancar = true;
    }

    void Update()
    {
        if (arrancar == false)
        {
            calentar();
        }
        else if (arrancar == true)
        {
            marcha();
        }
    }

    void marcha()
    {
        Transform needle = marcador.getNedle();
        rb2D = GetComponent<Rigidbody2D>();
        float valor = marcador.GetSpeedRotation();
        if (salida == 0)
        {
            rb2D.velocity = new Vector2(300f, rb2D.velocity.y);
            needle.eulerAngles = new Vector3(0, 0, valor);
            if (TextoFlotanteMalaSalida)
            {
                MostrarTextoMalaSalida();
            }
        }
        else if (salida == 1)
        {
            rb2D.velocity = new Vector2(600f, rb2D.velocity.y);
            needle.eulerAngles = new Vector3(0, 0, valor);
            if (TextoFlotanteBuenaSalida)
            {
                MostrarTextoBuenaSalida();
            }
        }
        else if (salida == 2)
        {
            rb2D.velocity = new Vector2(999f, rb2D.velocity.y);
            needle.eulerAngles = new Vector3(0, 0, valor);
            if (TextoFlotanteSalidaPerfecta)
            {
                MostrarTexoSalidaPerfecta();
            }
        }
    }

    void calentar()
    {
        Debug.Log(marcador.GetSpeedRotation());
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (marcador.GetSpeedRotation() > 50)
            {
                salida = 0;
            }
            else if (marcador.GetSpeedRotation() < 39)
            {
                salida = 1;
            }
            else if (marcador.GetSpeedRotation() <= 50 || marcador.GetSpeedRotation() >= 39)
            {
                salida = 2;
            }
        }
    }

    public void MostrarTextoMalaSalida() 
    {
        GameObject textoMalaSalida = Instantiate(TextoFlotanteMalaSalida);
        textoMalaSalida.transform.position = new Vector3(1357, 385, -3);
    }

    public void MostrarTexoSalidaPerfecta()
    {
        GameObject textoSalidaPerfecta = Instantiate(TextoFlotanteSalidaPerfecta);
        textoSalidaPerfecta.transform.position = new Vector3(1357, 385, -3);
    }

    public void MostrarTextoBuenaSalida()
    {
        GameObject textoBuenaSalida = Instantiate(TextoFlotanteBuenaSalida);
        textoBuenaSalida.transform.position = new Vector3(1357, 385, -3);
    }
}
