using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioMarchas : MonoBehaviour
{

    private const float MAX_SPEED_ANGLE = 16;
    private const float ZERO_SPEED_ANGLE = 153;

    public Transform needleTransform;
    public Text marcha;
    Rigidbody2D rb2D;

    public Image UIImagen;

    private float speedMax;
    private float speedMin;
    private float speed;
    private int marchas = 1;

    // Getter
    public Transform getNedle()
    {
        return needleTransform;
    }


    // Setter
    public void setNedle(Transform needle)
    {
        this.needleTransform = needle;
    }

    private void Awake()
    {
        needleTransform = transform.Find("needle");

        speed = 0f;
        speedMax = 60f;
        UIImagen = GameObject.Find("Marcador").GetComponent<Image>();
    }

    public void Update()
    {
        //Acelera
        speed += 20f * Time.deltaTime;
        Debug.Log(marchas);
        if (marchas == 1 && Input.GetMouseButtonDown(0))
        {
            marcha.text = "2";
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/marcador1");
            speed -= 17f * Time.deltaTime * 999;
            marchas = 2;
            Debug.Log(marchas);
        }
        else if (marchas == 2)
        {
            StartCoroutine("Marcha2");
        }
        else if (marchas == 3)
        {
            StartCoroutine("Marcha3");
        }
        else if (marchas == 4)
        {
            StartCoroutine("Marcha4");
        }
        else if (marchas == 5)
        {
            StartCoroutine("Marcha5");
        }
        else if (marchas == 6)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/marcador6");
        }


        if (speed > speedMax) speed = speedMax;
        if (speed < speedMin) speed = speedMin;


        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());

    }

    IEnumerator Marcha2()
    {
        yield return new WaitForSeconds(2);
        if (marchas == 2 && Input.GetMouseButtonDown(0))
        {
            marcha.text = "3";
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/marcador3");
            speed -= 17f * Time.deltaTime * 999;
            marchas = 3;
            Debug.Log(marchas);
        }
    }

    IEnumerator Marcha3()
    {
        yield return new WaitForSeconds(2);
        if (marchas == 3 && Input.GetMouseButtonDown(0))
        {
            marcha.text = "4";
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/marcador4");
            speed -= 17f * Time.deltaTime * 999;
            marchas = 4;
            Debug.Log(marchas);
        }
    }

    IEnumerator Marcha4()
    {
        yield return new WaitForSeconds(2);
        if (marchas == 4 && Input.GetMouseButtonDown(0))
        {
            marcha.text = "5";
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/marcador5");
            speed -= 17f * Time.deltaTime * 999;
            marchas = 5;
            Debug.Log(marchas);
        }
    }

    IEnumerator Marcha5()
    {
        yield return new WaitForSeconds(2);
        if (marchas == 5 && Input.GetMouseButtonDown(0))
        {
            marcha.text = "6";
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/marcador6");
            speed -= 17f * Time.deltaTime * 999;
            marchas = 6;
            Debug.Log(marchas);
        }
    }



    public float GetSpeedRotation()
    {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }
}