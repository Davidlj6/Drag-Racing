using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEstado : MonoBehaviour
{
    public static ControladorEstado controladorEstado;
    public int estadoSalida;


    private void Awake()
    {
        if (controladorEstado == null)
        {
            controladorEstado = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (controladorEstado != this)
        {
            Destroy(gameObject);
        }
       
    }

    public void setEstado(int estadoSalida)
    {
        this.estadoSalida = estadoSalida;
    }

    public int getEstado()
    {
        return estadoSalida;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
