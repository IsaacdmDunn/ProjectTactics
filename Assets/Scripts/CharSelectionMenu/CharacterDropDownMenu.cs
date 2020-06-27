using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDropDownMenu : MonoBehaviour {

	public GameObject Portrait1;
	public GameObject Portrait2;
	public GameObject Portrait3;
	public GameObject Portrait4;
	public GameObject Portrait5;

	public Text AbilityIcon1;
	public Text AbilityDescription;

	public Text HealthTxt;
	public Text AttackTxt;
	public Text DefenceTxt;
	public Text MysticismTxt;

	//CharacterStats characterStats;

	public void UpdateStatText()
	{
		HealthTxt.text = CharacterStats.health.ToString();
		AttackTxt.text = CharacterStats.attack.ToString();
		DefenceTxt.text = CharacterStats.defence.ToString();
		MysticismTxt.text = CharacterStats.mysticism.ToString();
	}

	public void DropDownMenuChange(int selected)
	{
		switch (selected)
		{
			case 0:
				Portrait1.SetActive(true);
				Portrait2.SetActive(false);
				Portrait3.SetActive(false);
				Portrait4.SetActive(false);
				Portrait5.SetActive(false);

				AbilityIcon1.text = "Forager";
				AbilityDescription.text = "Can forage for more food in the forests.";

				CharacterStats.characterID = 0;
				CharacterStats.health = 8;
				CharacterStats.attack = 3;
				CharacterStats.defence = 1;
				CharacterStats.mysticism = 5;
				UpdateStatText();
				break;
			case 1:
				Portrait1.SetActive(false);
				Portrait2.SetActive(true);
				Portrait3.SetActive(false);
				Portrait4.SetActive(false);
				Portrait5.SetActive(false);

				AbilityIcon1.text = "Light-Footed";
				AbilityDescription.text = "Can avoid encounters with hostiles more effectively.";

				CharacterStats.characterID = 1;
				CharacterStats.health = 6;
				CharacterStats.attack = 2;
				CharacterStats.defence = 2;
				CharacterStats.mysticism = 7;
				UpdateStatText();
				break;
			case 2:
				Portrait1.SetActive(false);
				Portrait2.SetActive(false);
				Portrait3.SetActive(true);
				Portrait4.SetActive(false);
				Portrait5.SetActive(false);

				AbilityIcon1.text = "Cultist";
				AbilityDescription.text = "understands symbols of the cosmic horrors.";

				CharacterStats.characterID = 2;
				CharacterStats.health = 5;
				CharacterStats.attack = 4;
				CharacterStats.defence = 1;
				CharacterStats.mysticism = 10;
				UpdateStatText();
				break;
			case 3:
				Portrait1.SetActive(false);
				Portrait2.SetActive(false);
				Portrait3.SetActive(false);
				Portrait4.SetActive(true);
				Portrait5.SetActive(false);

				AbilityIcon1.text = "Scholar";
				AbilityDescription.text = "Able to learn experience from encounters.";

				CharacterStats.characterID = 3;
				CharacterStats.health = 7;
				CharacterStats.attack = 1;
				CharacterStats.defence = 4;
				CharacterStats.mysticism = 7;
				UpdateStatText();
				break;
			case 4:
				Portrait1.SetActive(false);
				Portrait2.SetActive(false);
				Portrait3.SetActive(false);
				Portrait4.SetActive(false);
				Portrait5.SetActive(true);

				AbilityIcon1.text = "Soldier";
				AbilityDescription.text = "Finds extra amno when searching for supplies.";

				CharacterStats.characterID = 4;
				CharacterStats.health = 10;
				CharacterStats.attack = 4;
				CharacterStats.defence = 3;
				CharacterStats.mysticism = 0;
				UpdateStatText();
				break;
		}
	}
}
