using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReinciarVida : MonoBehaviour
{
    // Start is called before the first frame update
    public int aciertos = 0;
    public int score = 0;
    public GameObject explosion1;
    public GameObject explosion2;
    public GameOver game;
    public Text textoPunto;

    


    void Start()
    {
        ActualizarMarcadorPuntos();
    }
    void ActualizarMarcadorPuntos() {
        textoPunto.text = "Puntos: " +score;
            
    }

    // Update is called once per frame
    void Update()
    {
        if (aciertos == 5)
        {
            game.Reiciar();
            aciertos = 0;
        }
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.CompareTag("cubo1"))
        {
            Instantiate(explosion1, transform.position, otherObj.transform.rotation);
            Destroy(otherObj.gameObject, .01f);
            aciertos++;
            score++;
            ActualizarMarcadorPuntos();
        }
        if (otherObj.gameObject.CompareTag("cubo2"))
        {
            Instantiate(explosion2, transform.position, otherObj.transform.rotation);
            Destroy(otherObj.gameObject, .01f);
            aciertos++;
            score++;
            ActualizarMarcadorPuntos();
        }

    }
}
