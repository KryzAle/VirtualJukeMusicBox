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
    private float spawnWait = 1.22f;
    private float spawnWait2;
    private float startWait = 4f;
    

    // Update is called once per frame
    /*IEnumerator SpawnWaves()
    {
        Vector3 spawnPosition = new Vector3();
        yield return new WaitForSeconds(startWait);
        for (int i = 0; i < hazardCound; i++)
        {

            spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Instantiate(hazard, spawnPosition, Quaternion.identity);



            yield return new WaitForSeconds(spawnWait);

        }

    }*/
    public void MyCallbackEventHandler(BeatDetection.EventInfo eventInfo)
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
    }
    // Start is called before the first frame update
    void Start()
    {
        AudioBeat.GetComponent<BeatDetection>().CallBackFunction = MyCallbackEventHandler;
        //StartCoroutine(SpawnWaves());
    }
}
