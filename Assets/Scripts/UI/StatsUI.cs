using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsUI : MonoBehaviour {

	public GameObject StatsMenu;

	// Use this for initialization
	void Start () {
		Debug.Log(CharacterStats.characterID);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//quits the game when the quit button is pressed
	public void ExitButtonPressed()
	{
		StatsMenu.SetActive(false);
	}
}
