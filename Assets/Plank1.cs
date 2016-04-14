using UnityEngine;
using System.Collections;

public class Plank1 : MonoBehaviour {

    private bool mB;
    private int mDecr;

	// Use this for initialization
	void Start () {
	    mB=false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!mB)
            if ((Light1.mL1)&&(Light1.mL2)&&(Light1.mL3)&&(Light1.mL4))
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
