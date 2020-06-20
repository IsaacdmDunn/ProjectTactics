using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	public int tileX;
	public int tileY;
	public TileMap map;

	public List<Node> currentPath = null;

	void Update() {
		if (currentPath != null) {
			int currentNode = 0;

			while (currentNode < currentPath.Count-1) {
				Vector3 start = map.TileCoordToWorld(currentPath[currentNode].x, currentPath[currentNode].y)
					+ new Vector3(0,0,-1);
				Vector3 end = map.TileCoordToWorld(currentPath[currentNode + 1].x, currentPath[currentNode + 1].y)
					+ new Vector3(0,0,-1);
				Debug.DrawLine(start, end);
				currentNode++;
			}
		}
	}

}
