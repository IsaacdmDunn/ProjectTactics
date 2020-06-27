using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour {

	public GameObject StatsMenu;

	public Image Portrait;
	public Text PortraitName;

	public Text HealthText;
	public Text RationsText;
	public Text MedsText;
	public Text AttackText;
	public Text DefenceText;
	public Text MysticismText;

	public Sprite Lena;
	public Sprite Lance;
	public Sprite Danielle;
	public Sprite Sabastian;
	public Sprite Ace;

	// Use this for initialization
	void Start () {
		Debug.Log(CharacterStats.characterID);
		HealthText.text = CharacterStats.health.ToString();
		RationsText.text = CharacterStats.rations.ToString();
		MedsText.text = CharacterStats.meds.ToString();
		AttackText.text = CharacterStats.attack.ToString();
		DefenceText.text = CharacterStats.defence.ToString();
		MysticismText.text = CharacterStats.mysticism.ToString();
		PortraitName.text = CharacterStats.characterName;
		//Portrait.gameObject.GetComponent<Image>().sprite = Lena;

		switch (CharacterStats.characterID)
		{
		case 0:
			Portrait.gameObject.GetComponent<Image>().sprite = Lena;
			break;
		case 1:
			Portrait.gameObject.GetComponent<Image>().sprite = Lance;
			break;
		case 2:
			Portrait.gameObject.GetComponent<Image>().sprite = Danielle;
			break;
		case 3:
			Portrait.gameObject.GetComponent<Image>().sprite = Sabastian;
			break;
		case 4:
			Portrait.gameObject.GetComponent<Image>().sprite = Ace;
			break;
		}
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
