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
    public float spawnWait = 1f;
    public float spawnWait2=1.2f;
    public float startWait = 0.8f;
    

    // Update is called once per frame
    IEnumerator SpawnWaves()
    {
        
        yield return new WaitForSeconds(startWait);
        for (int i = 0; i < 2; i++)
        {
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
        }
        yield return new WaitForSeconds(2f);
        CrearIzquierda();
        yield return new WaitForSeconds(2.6f);
        CrearIzquierda();
        for (int i = 0; i < 2; i++)
        {
            yield return new WaitForSeconds(1.2f);
            CrearDerecha();
            yield return new WaitForSeconds(1);
            CrearIzquierda();
        }
        yield return new WaitForSeconds(2.8f);
        CrearIzquierda();
        yield return new WaitForSeconds(2f);
        CrearDerecha();
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(spawnWait);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait2);
            CrearIzquierda();
            yield return new WaitForSeconds(spawnWait);
            CrearDerecha();
            yield return new WaitForSeconds(spawnWait2);
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
        Instantiate(hazard, spawnPosition, Quaternion.identity);

    }
    /* public void MyCallbackEventHandler(BeatDetection.EventInfo eventInfo)
     {
         switch (eventInfo.messageInfo)
         {
             case BeatDetection.EventType.Kick:
                 StartCoroutine(createMusic(hazard));
                 break;

         }
     }

     private IEnumerator createMusic(GameObject objeto)
     {
         Random rnd = new Random();
         Vector3 spawnPosition = new Vector3();
         spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
         Instantiate(hazard, spawnPosition, Quaternion.identity);
         yield break;
     }*/
    // Start is called before the first frame update
    void Start()
    {
        //AudioBeat.GetComponent<BeatDetection>().CallBackFunction = MyCallbackEventHandler;
        StartCoroutine(SpawnWaves());
    }
}
