using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerControl : MonoBehaviour {

	// Use this for initialization
	public static float y1;
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		controls ();
	}
	void controls(){
		if(GameObject.FindGameObjectWithTag("Ball"))
			transform.Translate (0, y1*0.8f, 0);
	}
}
