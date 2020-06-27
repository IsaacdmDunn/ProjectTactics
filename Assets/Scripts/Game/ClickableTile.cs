using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableTile : MonoBehaviour {

	public int tileX;
	public int tileY;
	public TileMap map;

	// when tile is clicked
	void OnMouseOver () {
		if (Input.GetMouseButtonDown(1)) {
			map.MoveUnitToTile (tileX, tileY);
		}

	}

}
