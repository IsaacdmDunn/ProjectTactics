using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMenuNavigationButtons : MonoBehaviour {

	public void PlayButton()
	{
		SceneManager.LoadScene("GameScene");
	}
	public void BackButton()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
