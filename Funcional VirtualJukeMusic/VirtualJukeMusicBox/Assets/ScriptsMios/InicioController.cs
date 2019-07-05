using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.CompareTag("play1"))
        {
            SceneManager.LoadScene("SONG1");
        }
        if (otherObj.gameObject.CompareTag("play2"))
        {
            SceneManager.LoadScene("SONG2");
        }
        if (otherObj.gameObject.CompareTag("reintentar"))
        {
            SceneManager.LoadScene("MenuInicio");
        }

    }
}
