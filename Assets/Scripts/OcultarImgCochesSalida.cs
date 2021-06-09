using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class OcultarImgCochesSalida : MonoBehaviour
{
    public bool isImgOn;
    public Image img;

    void Start()
    {
        img.enabled = true;
        isImgOn = true;
    }

    void Update()
    {
        StartCoroutine("OcultarImg");
    }

    IEnumerator OcultarImg()
    {
        yield return new WaitForSeconds(5);
        img.enabled = false;
        isImgOn = false;
    }
}
