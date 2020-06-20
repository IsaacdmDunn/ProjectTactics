using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	public int tileX;
	public int tileY;
	public TileMap map;

	int tileMovesPerTurn = 2;

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
	//moves to the next tile in the path
	public void MoveToTile() {
		float remainingMoves = tileMovesPerTurn;
		while(remainingMoves > 0) {
		//if path exists
			if (currentPath == null)
			{
				return;
			}
			//takes away moves when moving unit
			remainingMoves-= map.TileMovementCost(currentPath[0].x, currentPath[0].y, currentPath[1].x, currentPath[1].y);

			//move to next node on path
			tileX = currentPath[1].x;
			tileY = currentPath[1].y;
			transform.position = map.TileCoordToWorld(tileX, tileY);
		
			//removes older node in the path list
			currentPath.RemoveAt(0);

			//if last tile in path then clear current path
			if (currentPath.Count == 1)
			{
				currentPath = null;
			}
			
		}
	}
}
