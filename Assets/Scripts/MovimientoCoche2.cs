using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche2 : MonoBehaviour { 

    void Start() {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(100f, 0, 0);
    }

    void Update() {

    }
}
