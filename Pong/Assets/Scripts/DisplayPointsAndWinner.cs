using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayPointsAndWinner : MonoBehaviour {

	public int reqpoints;
	public TextMesh Score1;       // placeholder to display score1
	public TextMesh Score2;       // placeholder to display score2
	public TextMesh Winner;
	void Start () {
		Score1.text = "" + BallMovement.points1;   
		Score2.text = "" + BallMovement.points2;
		Instantiate (Score1);
		Instantiate (Score2);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			BallMovement.points1 = 0;
			BallMovement.points2 = 0;
			SceneManager.LoadScene (0);
		}
			
		if(BallMovement.points1 == reqpoints){
			Winner.text = "Player 1 Wins"; 
		}

		else 
			if(BallMovement.points2 == reqpoints){
			Winner.text = "Player 2 Wins"; 
		}

		else 
			Invoke ("ChangeScoreBoardToArena", 3);
	}
		
	void ChangeScoreBoardToArena(){
		SceneManager.LoadScene (1);
	}

}
