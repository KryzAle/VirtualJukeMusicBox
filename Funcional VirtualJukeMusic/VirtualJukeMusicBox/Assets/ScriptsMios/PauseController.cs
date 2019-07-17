using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public AudioSource audioSource;
    public string nombreMapa;
    public ReinciarVida bdd;
    Text nombre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pause")) { 
            nombre = GameObject.Find("nick").GetComponent<Text>();
            TimeSpan time = TimeSpan.FromSeconds(audioSource.time);
            bdd.Guardar(nombre.text, bdd.score, time.ToString("mm':'ss"), nombreMapa);
            SceneManager.LoadScene("GameOverView");
        }
    }
}
