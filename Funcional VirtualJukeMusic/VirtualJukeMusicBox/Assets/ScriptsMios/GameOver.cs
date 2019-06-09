using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public int contadorFallos = 0;
    public GameObject destruir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contadorFallos == 4)
        {
        StartCoroutine(Terminar());
        }
    }
    IEnumerator Terminar()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOverView");
    }
    public void Reiciar()
    {
        contadorFallos = 0;
    }
    void OnCollisionEnter(Collision collision)
    {
        Instantiate(destruir, transform.position, collision.transform.rotation);
        Destroy(collision.gameObject, .01f);

        contadorFallos++;
    }
}
