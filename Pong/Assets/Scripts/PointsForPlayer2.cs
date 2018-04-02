using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsForPlayer2 : MonoBehaviour {

	// Use this for initialization
	private bool change = false;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(change){
			Invoke ("ChangeArenaToScoreBoard", 1);
		}
	}
	void OnTriggerEnter2D(Collider2D coll){
		if(coll.tag.Equals("Ball")){

			BallMovement.points2 = BallMovement.points2 + 1;
			change = true;
			DestroyObject(coll.gameObject);
		}
	}
	void ChangeArenaToScoreBoard(){
		SceneManager.LoadScene (2);
	}
}
