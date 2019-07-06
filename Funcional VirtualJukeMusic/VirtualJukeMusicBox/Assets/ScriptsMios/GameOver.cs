using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mono.Data.Sqlite;
using System.Data;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public int contadorFallos = 0;
    public GameObject destruir;
    public Lives vida_canvas;
    int vida = 3;
    public Text nombre;
    public ReinciarVida bdd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (contadorFallos==4)
        {
            
            perdiste();
        }
        
        if (vida >= 0)
        {
            vida_canvas.CambioVida(vida);
        }

    }
    public void Reiciar()
    {
        
        contadorFallos = 0;
        vida = 3;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("cubo1")|| collision.gameObject.CompareTag("cubo2"))
        {
            Instantiate(destruir, transform.position, collision.transform.rotation);
            Destroy(collision.gameObject, .01f);
            contadorFallos++;
            vida--;
        }
    }
    public void perdiste()
    {
        nombre = GameObject.Find("nick").GetComponent<Text>();
        bdd.Guardar(nombre.text, bdd.score);
        SceneManager.LoadScene("GameOverView");
    }
}
