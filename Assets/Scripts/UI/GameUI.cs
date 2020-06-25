using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour {

	public GameObject InventoryMenu;
	public GameObject StatsMenu;
	public GameObject EscMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void InventoryButton()
    {
		InventoryMenu.SetActive(true);
    }

	public void StatsButton()
	{
		StatsMenu.SetActive(true);
	}

	public void MenuButton()
	{
		EscMenu.SetActive(true);
	}
}
