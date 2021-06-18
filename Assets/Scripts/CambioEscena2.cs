using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("MetaScene", LoadSceneMode.Single);

        }
        if (other.gameObject.tag == "Player2")
        {
            SceneManager.LoadScene("MetaScene2", LoadSceneMode.Single);

        }
    }
}
