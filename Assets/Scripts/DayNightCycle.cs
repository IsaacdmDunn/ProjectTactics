using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

	public Light light;
	float lightRotation = 330;
	
	// Update is called once per frame
	void Update () {
		lightRotation += 0.1f;
		light.transform.rotation = Quaternion.Euler(0, lightRotation, 0);
	}
}
