﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {

	public TileType[] tileTypes;
	int[,] tiles;

	int mapSizeY = 10;
	int mapSizeX = 10;

	public GameObject SelectedUnit;

	// Use this for initialization
	void Start () {
		
		GenerateMapTiles ();
		GenerateMapVisuals();
	}

	void GenerateMapTiles ()
	{
		//allocate map tiles
		tiles = new int[mapSizeX, mapSizeY];

		//init grass map tiles
		for (int x = 0; x < mapSizeX; x++) {
			for (int y = 0; y < mapSizeY; y++) {
				tiles [x, y] = 0;
			}
		}

		//init swamp map tiles
		for (int x = 3; x < 5; x++) {
			for (int y = 0; y < 4; y++) {
				tiles [x, y] = 1;
			}
		}

		//init mountain tiles
		tiles [4, 4] = 2;
		tiles [5, 4] = 2;
		tiles [6, 4] = 2;
		tiles [7, 4] = 2;
		tiles [8, 4] = 2;
		tiles [4, 5] = 2;
		tiles [4, 6] = 2;
		tiles [8, 5] = 2;
		tiles [8, 6] = 2;
	}

	//spawn prefabs
	void GenerateMapVisuals() {
		for (int x = 0; x < mapSizeX; x++) {
			for (int y = 0; y < mapSizeY; y++) {

				TileType tt = tileTypes[tiles[x,y]];
				GameObject go = Instantiate (tt.tileVisualPrefab, new Vector3(x, y, 0), Quaternion.identity);

				ClickableTile ct = go.GetComponent<ClickableTile> ();
				ct.tileX = x;
				ct.tileY = y;
				ct.map = this;
			}
		}
	}

	public void MoveUnitToTile(int x, int y) {
		SelectedUnit.transform.position = new Vector3 (x, y, 0);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
