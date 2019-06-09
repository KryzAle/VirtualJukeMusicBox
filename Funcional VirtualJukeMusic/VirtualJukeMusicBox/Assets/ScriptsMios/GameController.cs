using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject AudioBeat;
    public GameObject hazard;
    public GameObject hazard2;
    public Vector3 spawnValues;
    public Vector3 spawnValues2;
    public Vector3 spawnValues3;
    public int hazardCound;
    private float spawnWait = 1.27f;
    private float spawnWait2=1.2f;
    private float startWait = 2f;
    

    // Update is called once per frame
    IEnumerator SpawnWaves()
    {
        
        yield return new WaitForSeconds(startWait);
        for (int i = 0; i < 2; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
        }
        yield return new WaitForSeconds(2.422f);
        CrearIzquierda();
        yield return new WaitForSeconds(2.65f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.48f);
        CrearDerecha();
        yield return new WaitForSeconds(1.20f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.20f);
        CrearDerecha();
        yield return new WaitForSeconds(1.20f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.64f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.359f);
        CrearDerecha();
        yield return new WaitForSeconds(0.667f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.14f);
        CrearIzquierda();
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.31f);
            CrearDerecha();
            yield return new WaitForSeconds(0.31f);
            CrearDerecha();
            yield return new WaitForSeconds(0.31f);
            CrearIzquierda();
            yield return new WaitForSeconds(0.31f);
            CrearIzquierda();
        }
        yield return new WaitForSeconds(0.31f);
        CrearDerecha();
        yield return new WaitForSeconds(0.31f);
        CrearDerecha();
        yield return new WaitForSeconds(0.43f);
        CrearDerecha();
        yield return new WaitForSeconds(0.20f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.20f);
        CrearDerecha();
        yield return new WaitForSeconds(0.4f);
        for (int i = 0; i < 6; i++)
        {
            
            CrearIzquierda();
            yield return new WaitForSeconds(0.31f);
            CrearIzquierda();
            yield return new WaitForSeconds(0.31f);
            CrearDerecha();
            yield return new WaitForSeconds(0.31f);
            CrearDerecha();
        }

    }
    void CrearDerecha()
    {
        Vector3 spawnPosition = new Vector3();
        spawnPosition = new Vector3(spawnValues.x, spawnValues.y, spawnValues.z);
        Instantiate(hazard, spawnPosition, Quaternion.identity);

    }
    void CrearIzquierda()
    {
        Vector3 spawnPosition = new Vector3();
        spawnPosition = new Vector3(-spawnValues.x, spawnValues.y, spawnValues.z);
        Instantiate(hazard2, spawnPosition, Quaternion.identity);

    }
    // Start is called before the first frame update
    void Start()
    {
        //AudioBeat.GetComponent<BeatDetection>().CallBackFunction = MyCallbackEventHandler;
        StartCoroutine(SpawnWaves());
    }
}
