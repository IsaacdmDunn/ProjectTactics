using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {

	public TileType[] tileTypes;
	int[,] tiles;
	Node[,] graph;

	List<Node> currentPath = null;

	int mapSizeY = 10;
	int mapSizeX = 10;

	public GameObject SelectedUnit;

	// Use this for initialization
	void Start () {
		
		GenerateMapTiles ();
		GeneratePathFindingGraph ();
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

	public Vector3 TileCoordToWorld(int x, int y) {
		return new Vector3(x, y, 0);
	}

	public void MoveUnitToTile(int x, int y) {
		//clear units old path
		SelectedUnit.GetComponent<Unit>().currentPath = null;

		//pathfinding algorithgm
		Dictionary<Node, float> distance = new Dictionary<Node, float> ();
		Dictionary<Node, Node> previousNode = new Dictionary<Node, Node> ();

		List<Node> unvisitedNodes = new List<Node> ();

		Node source = graph [
			              SelectedUnit.GetComponent<Unit> ().tileX,
			              SelectedUnit.GetComponent<Unit> ().tileY];
		Node target = graph [x, y];

		distance [source] = 0;
		previousNode[source] = null;

		foreach (Node v in graph) {
			if (v != source) {
				distance[v] = Mathf.Infinity;
				previousNode[v] = null;
			}	

			unvisitedNodes.Add(v);

			while(unvisitedNodes.Count > 0) {
				//u == unvisited node with smallest distance
				Node u = null;

				foreach (Node possibleU in unvisitedNodes) {
					if (u == null || distance[possibleU] < distance[u]) {
						u = possibleU;
					}
				}

				//target found break from loop
				if (u == target) {
					break;
				}

				unvisitedNodes.Remove(u);

				foreach (Node vert in u.neighbours) {
					float alt = distance[u] + u.DistanceTo(vert);
					if (alt < distance[vert]) {
						distance[vert] = alt;
						previousNode[vert] = u;
					}
				}
			}

			//if shortest path found or no possible path found
			if(previousNode[target] == null){	//no route
				return;
			}

			List<Node> currentPath = new List<Node>();
			Node curr = target;

			while (curr != null) {
				currentPath.Add(curr);
				curr = previousNode[curr];
			}

			//inverts path
			currentPath.Reverse();
			SelectedUnit.GetComponent<Unit>().currentPath = currentPath;
		}
	}

	public class Node {
		public List<Node> neighbours;
		public int x;
		public int y;

		public Node() {
			neighbours = new List<Node>();
		}

		public float DistanceTo(Node n) {

			return Vector2.Distance( new Vector2(x,y), new Vector2(n.x, n.y));
		}

	}

	void GeneratePathFindingGraph () 
	{
		//init array
		graph = new Node[mapSizeX, mapSizeY];

		//init nodes in array
		for (int x = 0; x < mapSizeX; x++) {
			for (int y = 0; y < mapSizeY; y++) {

				graph[x,y] = new Node();

				graph[x, y].x = x;
				graph[x, y].y = y;
			}
		}

		//calc node neighbours
		for (int x = 0; x < mapSizeX; x++) {
			for (int y = 0; y < mapSizeY; y++) {

				if (x > 0) {
					graph [x, y].neighbours.Add (graph [x - 1, y]);
				}
				if (x < mapSizeX-1) {
					graph [x, y].neighbours.Add (graph [x + 1, y]);
				}
				if (y > 0) {
					graph [x, y].neighbours.Add (graph [x, y - 1]);
				}
				if (y < mapSizeY-1) {
					graph [x, y].neighbours.Add (graph [x, y + 1]);
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
