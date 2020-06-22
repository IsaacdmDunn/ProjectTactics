using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {

    //represents the button objects in the main menu
    public GameObject PlayButton;
    public GameObject HelpButton;
    public GameObject QuitButton;

    //plays the game scene when the play button is pressed
    public void PlayButtonPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    //quits the game when the quit button is pressed
    public void QuitButtonPressed()
    {
        Application.Quit();
    }

    //displays the help menu when the help button is pressed
    public void HelpButtonPressed()
    {

    }
}
