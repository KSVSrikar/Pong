using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {


	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Player1Movement> ().enabled = MenuManager.Multiplayer;
		gameObject.GetComponent<ComputerControl> ().enabled = !MenuManager.Multiplayer;
	}


	void FixedUpdate () {
		controls ();
	}
	void controls(){

 		float yplayer1 = Input.GetAxis ("Vertical")*1f;
		transform.Translate (0, yplayer1, 0);
	}

}

