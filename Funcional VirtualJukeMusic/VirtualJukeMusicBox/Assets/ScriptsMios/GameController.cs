using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    public Vector3 spawnValues2;
    public Vector3 spawnValues3;
    public int hazardCound;
    private float spawnWait = 1.22f;
    private float spawnWait2;
    private float startWait = 4f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    IEnumerator SpawnWaves()
    {
        Vector3 spawnPosition = new Vector3();
        yield return new WaitForSeconds(startWait);
        for (int i = 0; i < hazardCound; i++)
        {

            spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Instantiate(hazard, spawnPosition, Quaternion.identity);



            yield return new WaitForSeconds(spawnWait);

        }

    }
}
