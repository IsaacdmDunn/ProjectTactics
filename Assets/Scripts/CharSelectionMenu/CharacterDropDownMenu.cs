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
				break;
			case 1:
				Portrait1.SetActive(false);
				Portrait2.SetActive(true);
				Portrait3.SetActive(false);
				Portrait4.SetActive(false);
				Portrait5.SetActive(false);

				AbilityIcon1.text = "Light-Footed";
				AbilityDescription.text = "Can avoid encounters with hostiles more effectively.";
				break;
			case 2:
				Portrait1.SetActive(false);
				Portrait2.SetActive(false);
				Portrait3.SetActive(true);
				Portrait4.SetActive(false);
				Portrait5.SetActive(false);

				AbilityIcon1.text = "Cultist";
				AbilityDescription.text = "understands symbols of the cosmic horrors.";
				break;
			case 3:
				Portrait1.SetActive(false);
				Portrait2.SetActive(false);
				Portrait3.SetActive(false);
				Portrait4.SetActive(true);
				Portrait5.SetActive(false);

				AbilityIcon1.text = "Scholar";
				AbilityDescription.text = "Able to learn experience from encounters.";
				break;
			case 4:
				Portrait1.SetActive(false);
				Portrait2.SetActive(false);
				Portrait3.SetActive(false);
				Portrait4.SetActive(false);
				Portrait5.SetActive(true);

				AbilityIcon1.text = "Soldier";
				AbilityDescription.text = "Finds extra amno when searching for supplies.";
				break;
		}
	}
}
