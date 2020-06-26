using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOverAbilityInfo : MonoBehaviour {

	public GameObject AbilityText;

	public void OnMouseEnterAbility() {
		AbilityText.SetActive(true);
	}

	public void OnMouseExitAbility() {
		AbilityText.SetActive(false);
	}
}
