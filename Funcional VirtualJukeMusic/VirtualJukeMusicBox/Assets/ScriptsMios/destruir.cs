using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour
{
    public GameObject explosion;
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
        Instantiate(explosion, transform.position, otherObj.transform.rotation);
        Destroy(gameObject, .01f);

    }
}
