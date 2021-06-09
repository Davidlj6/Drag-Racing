using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoSalida : MonoBehaviour
{
    public float TiempoEjecucion = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoEjecucion -= Time.deltaTime;
        if (TiempoEjecucion <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
