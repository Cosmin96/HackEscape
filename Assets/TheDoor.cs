using UnityEngine;
using System.Collections;

public class TheDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (Light3.mL)
            Application.Quit();
    }
}
