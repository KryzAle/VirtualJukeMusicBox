using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinciarVida : MonoBehaviour
{
    // Start is called before the first frame update
    public int aciertos=0;
    public GameObject explosion;
    public GameOver game;


    void Start()
    {
        
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
        if (otherObj.gameObject.CompareTag("cubo"))
        {
            Instantiate(explosion, transform.position, otherObj.transform.rotation);
            Destroy(otherObj.gameObject, .01f);
            aciertos++;
        }

    }
}
