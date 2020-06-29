using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressSound : MonoBehaviour {

    public AudioSource buttonPress;

	public void PlaySound()
    {
        buttonPress.Play();
    }
}
