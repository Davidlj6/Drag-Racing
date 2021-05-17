using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorKm : MonoBehaviour
{

    public Text contador, marcha;
    private float tiempo = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo <= 22)
        {
            tiempo += Time.deltaTime * 18;
            contador.text = "" + tiempo.ToString("f0");
            marcha.text = "1";
        }
        else if (tiempo <= 47)
        {
            tiempo += Time.deltaTime * 16;
            contador.text = "" + tiempo.ToString("f0");
            marcha.text = "2";
        }
        else if (tiempo <= 68)
        {
            tiempo += Time.deltaTime * 14;
            contador.text = "" + tiempo.ToString("f0");
            marcha.text = "3";
        }
        else if (tiempo <= 93)
        {
            tiempo += Time.deltaTime * 12;
            contador.text = "" + tiempo.ToString("f0");
            marcha.text = "4";
        }
        else if (tiempo <= 121)
        {
            tiempo += Time.deltaTime * 10;
            contador.text = "" + tiempo.ToString("f0");
            marcha.text = "5";
        }
        else if (tiempo <= 143)
        {
            tiempo += Time.deltaTime * 8;
            contador.text = "" + tiempo.ToString("f0");
            marcha.text = "6";
        }
        else if (tiempo <= 169)
        {
            tiempo += Time.deltaTime * 2;
            contador.text = "" + tiempo.ToString("f0");
        }
        else if (tiempo <= 169)
        {
            tiempo += Time.deltaTime * 0;
            contador.text = "" + tiempo.ToString("f0");
        }
    }
}
