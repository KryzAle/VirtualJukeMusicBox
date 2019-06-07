using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarCubos : MonoBehaviour
{
    public GameObject AudioBeat;
   
    public GameObject cubo;
    public GameObject cubo2;
    
    public void MyCallbackEventHandler(BeatDetection.EventInfo eventInfo)
    {
        switch (eventInfo.messageInfo)
        {
           
            
            case BeatDetection.EventType.Kick:
                createMusic(cubo);
                break;
            case BeatDetection.EventType.Snare:
                createMusic(cubo2);
                break;
        }
    }

    private void createMusic(GameObject objeto)
    {
               
    }

    // Use this for initialization
    void Start()
    {
        //Register the beat callback function
        AudioBeat.GetComponent<BeatDetection>().CallBackFunction = MyCallbackEventHandler;
    }
}
