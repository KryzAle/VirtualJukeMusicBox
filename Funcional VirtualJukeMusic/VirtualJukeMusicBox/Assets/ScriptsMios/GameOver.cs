using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public int contadorFallos = 0;
    public GameObject destruir;
    public Lives vida_canvas;
    int vida = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (contadorFallos==4)
        {
            SceneManager.LoadScene("GameOverView");
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
}
