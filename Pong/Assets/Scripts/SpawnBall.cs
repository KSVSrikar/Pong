using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBall : MonoBehaviour {

	// Use this for initialization
	public GameObject BallPrefab;
	private Vector2 pos;          //placeholder of random spawn of ball

	void Start () {
		if (MenuManager.Multiplayer)
			Invoke ("MakeBall", 2);            // initial spawn of ball
		else
			Invoke ("MakeBallC", 2);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			BallMovement.points1 = 0;
			BallMovement.points2 = 0;
			SceneManager.LoadScene (0);
		}
	}
	void MakeBall(){
		float y1 = Random.Range (-18, 18);
		pos = new Vector2 (0, y1); 
		Instantiate (BallPrefab,pos,Quaternion.identity); 
	}
	void MakeBallC(){
		float y1 = 0;
		pos = new Vector2 (0, y1); 
		Instantiate (BallPrefab,pos,Quaternion.identity); 
	}
}
