using UnityEngine;
using System.Collections;

public class Light1 : MonoBehaviour {

    public static bool mL1,mL2,mL3,mL4;
    private Renderer mRend;

	// Use this for initialization
	void Start () {
	    mL1=false;
        mL2=false;
        mL3=false;
        mL4=false;
        mRend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	    if (mL1 & mL2 & mL3 & mL4)
            dostuff();
	}

    void dostuff()
    {
        mRend.material.color = Color.green;
    }
}
