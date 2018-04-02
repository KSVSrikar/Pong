using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public static bool Multiplayer = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Quit(){
		Application.Quit ();
	}

	public void LoadPVPArena(){

		Multiplayer = true;
		SceneManager.LoadScene (1);

	}
	public void LoadPVCArena(){

		Multiplayer = false;
		SceneManager.LoadScene (1);

	}

}
