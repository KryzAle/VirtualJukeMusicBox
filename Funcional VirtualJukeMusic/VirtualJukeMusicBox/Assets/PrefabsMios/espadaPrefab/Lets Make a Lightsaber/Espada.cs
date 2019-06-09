using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour {
    LineRenderer espada;
    public Transform startPos;
    public Transform endPos;
    private float textura = 0f;
    private bool on = false;
    private Vector3 endPostExtend;
    // Use this for initialization
    void Start() {
        espada = GetComponent<LineRenderer>();
        endPostExtend = endPos.localPosition;



	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (on)
            {
                on = false;
            }
            else
            {
                on = true;
            }
        }

        if (on)
        {
            endPos.localPosition = Vector3.Lerp(endPos.localPosition, endPostExtend, Time.deltaTime * 5f);
        }
        else
        {
            endPos.localPosition = Vector3.Lerp(endPos.localPosition, startPos.localPosition, Time.deltaTime * 5f);
        }

        espada.SetPosition(0, startPos.position);
        espada.SetPosition(1,endPos.position);

        textura -= Time.deltaTime * 2;
        if (textura<-10f)
        {
            textura += 10f;
        }

        espada.sharedMaterials[1].SetTextureOffset("_MainTex", new Vector2(textura, 0f));

 	}
}
