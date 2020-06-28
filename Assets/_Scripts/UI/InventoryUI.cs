using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour {

	public GameObject InventoryMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//quits the game when the quit button is pressed
	public void ExitButtonPressed()
	{
		InventoryMenu.SetActive(false);
	}
}
