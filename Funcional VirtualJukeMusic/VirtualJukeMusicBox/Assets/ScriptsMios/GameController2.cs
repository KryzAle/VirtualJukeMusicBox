using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController2 : MonoBehaviour
{
    public GameObject hazard;
    public GameObject hazard2;
    public Vector3 spawnValues;
    public Vector3 spawnValues2;
    public Vector3 spawnValues3;
    public int hazardCound;
    private float spawnWait = 0.48f;
    private float spawnWait2 = 0.18f;
    private float startWait = 2f;


    // Update is called once per frame
    IEnumerator SpawnWaves()
    {
        //Intro
        //vuelta 1

        yield return new WaitForSeconds(startWait);

        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        //vuelta2
        yield return new WaitForSeconds(0.24f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }//vuelta3
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        
        yield return new WaitForSeconds(0.24f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        //vuelta4
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(0.24f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        //vuelta 5
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(0.24f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        //vuelta 6
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(0.288f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        //vuelta 7
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(0.288f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        //coro
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro2
        yield return new WaitForSeconds(1.30f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro3
        yield return new WaitForSeconds(1.30f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro 4
        yield return new WaitForSeconds(1.30f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //Reinicio
        yield return new WaitForSeconds(1.25f);

        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        //vuelta2
        yield return new WaitForSeconds(0.22f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }//vuelta3
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();

        yield return new WaitForSeconds(0.23f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        //vuelta4
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(0.22f);
        for (int i = 0; i < 3; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        CrearIzquierda();
        yield return new WaitForSeconds(spawnWait);
        CrearDerecha();
        yield return new WaitForSeconds(spawnWait);
        CrearIzquierda();
        //coro
        yield return new WaitForSeconds(1.07f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro2
        yield return new WaitForSeconds(1.07f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro3
        yield return new WaitForSeconds(1.07f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro 4
        yield return new WaitForSeconds(1.59f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.30f);
        for (int i = 0; i < 21; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(0.50f);
            CrearDerecha();
            yield return new WaitForSeconds(0.50f);

        }
        //reinicio  2 coro
        //coro
        yield return new WaitForSeconds(1.37f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro2
        yield return new WaitForSeconds(1.07f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro3
        yield return new WaitForSeconds(1.07f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        //coro 4
        yield return new WaitForSeconds(1.59f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(0.5f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();
        yield return new WaitForSeconds(1.45f);
        CrearDerecha();
        yield return new WaitForSeconds(0.5f);
        CrearIzquierda();

        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("WinView");
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
