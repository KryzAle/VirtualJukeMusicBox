using UnityEngine;
using System.Collections;

public class EventExample : MonoBehaviour {

    public GameObject AudioBeat;

    public int cubos=0;

    public void MyCallbackEventHandler(BeatDetection.EventInfo eventInfo)
    {
        switch(eventInfo.messageInfo)
        {
            case BeatDetection.EventType.Kick:
                StartCoroutine(showText());
                break;
            case BeatDetection.EventType.Snare:
                StartCoroutine(showText());
                break;
        }
    }

    private IEnumerator showText()
    {
        cubos++;
        yield break;
    }

    // Use this for initialization
    void Start () {
        //Register the beat callback function
        AudioBeat.GetComponent<BeatDetection>().CallBackFunction = MyCallbackEventHandler;
    }

}
