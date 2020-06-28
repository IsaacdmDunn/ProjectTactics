using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenuUI : MonoBehaviour {

	public GameObject EscMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//quits the game when the quit button is pressed
	public void ExitButtonPressed()
	{
		EscMenu.SetActive(false);
	}

	public void DesktopButtonPressed()
	{
		Application.Quit();
	}
	
	public void MainMenuButtonPressed()
	{
		SceneManager.LoadScene("MainMenu");
	}
	
	public void SaveButtonPressed()
	{
		EscMenu.SetActive(false);
	}
	
	public void LoadButtonPressed()
	{
		EscMenu.SetActive(false);
	}
}
