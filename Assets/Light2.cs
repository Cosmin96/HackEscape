using UnityEngine;
using System.Collections;

public class Light2 : MonoBehaviour {

    public static bool mL;
    private Renderer mRend;

	// Use this for initialization
	void Start () {
	    mL=false;
        mRend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	    if (mL)
            dostuff();
	}

    void dostuff()
    {
        mRend.material.color = Color.green;
    }
}
