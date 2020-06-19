using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {

	public TileType[] tileTypes;
	int[,] tiles;

	int mapSizeY = 10;
	int mapSizeX = 10;

	// Use this for initialization
	void Start () {
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
		tiles [4, 4] = 2;
		tiles [4, 4] = 2;
		tiles [4, 4] = 2;
		tiles [4, 4] = 2;
		tiles [4, 5] = 2;
		tiles [4, 6] = 2;
		tiles [8, 5] = 2;
		tiles [8, 6] = 2;

		GenerateMapVisuals();
	}

	//spawn prefabs
	void GenerateMapVisuals() {
		for (int x = 0; x < mapSizeX; x++) {
			for (int y = 0; y < mapSizeY; y++) {

				TileType tt = tileTypes[tiles[x,y]];
				Instantiate (tt.tileVisualPrefab, new Vector3(x, y, 0), Quaternion.identity);
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
