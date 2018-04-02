using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	void FixedUpdate () {
		controls ();
	}
	void controls(){
		//manual control for player2

		float yplayer2 = Input.GetAxis ("Vertical1")*1f;  
		transform.Translate (0, yplayer2, 0);
	}
}
