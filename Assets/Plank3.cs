using UnityEngine;
using System.Collections;

public class Plank3 : MonoBehaviour {

    private bool mB;
    private int mDecr;

	// Use this for initialization
	void Start () {
	    mB=false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!mB)
            if (Light3.mL)
            {
                mB=true;
                mDecr=300;
            }

        if (mDecr>0)
        {
            transform.Translate(0,-0.1f,0);
            mDecr--;
        }
	
	}
}
