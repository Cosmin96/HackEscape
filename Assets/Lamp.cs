using UnityEngine;
using System.Collections;

public class Lamp : MonoBehaviour {

    private Color startcolor;
    private Renderer mRend;

	// Use this for initialization
	void Start () {

	    mRend = GetComponent<Renderer>();

	}
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseEnter()
    {
        startcolor=mRend.material.color;
        mRend.material.color = Color.white;
    }

    void OnMouseExit()
    {
        mRend.material.color=startcolor;
    }

    void OnMouseDown()
    {

        if ((Light1.mL1)&&(Light1.mL2)&&(Light1.mL3)&&(Light1.mL4)&&(!Light2.mL))
        {
            Light2.mL = true;
            transform.Translate(0,-100f,0);
        }
    }

}
