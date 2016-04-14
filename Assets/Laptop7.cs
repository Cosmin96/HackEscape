using UnityEngine;
using System.Collections;

public class Laptop7 : MonoBehaviour {

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
        Light1.mL3 = true;
    }

}
