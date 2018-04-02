using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour {


	private Vector2 dir;    // placeholder for direction of ball travel
	private int x; // To determine initial direction of ball (0 means left, 1 means right)
	[HideInInspector]
	public static int points1 = 0;
	[HideInInspector]
	public static int points2 = 0;

	void Start () {
		x = Random.Range (0, 2);
		if (x > 0) {
			dir = new Vector2 (0.65f, 0.65f);
		} else
			dir = new Vector2 (-0.65f, 0.65f);
	}

	void FixedUpdate () {
		transform.Translate (dir);
		ComputerControl.y1 = dir.y;
	}
	void OnTriggerEnter2D(Collider2D collision){

		if(collision.tag.Equals("Player")){
			dir.x = -1*dir.x;                     // ball hit by player
		}
		else if(collision.tag.Equals("BorderBounce")){
			dir.y = -1 * dir.y;                   // ball bounced by border
		}
	}		
}
