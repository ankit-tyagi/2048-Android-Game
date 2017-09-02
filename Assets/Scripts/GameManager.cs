using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private Tile[,] AllTiles = new Tile[4, 4];
	private List<Tile> EmptyTiles = new List<Tile>();

	// Use this for initialization
	void Start () {
		Tile[] AllTilesOneDim = GameObject.FindObjectsOfType<Tile> ();
		foreach (Tile t in AllTilesOneDim) {
			t.Number = 0;
			AllTiles [t.IndexRow, t.IndexCol] = t;
			EmptyTiles.Add (t);
		} 
	}

	void Generate(){
		/*if (EmptyTiles.Count > 0) {
			int IndexForNewNumber = Random.Range (0, EmptyTiles.Count);
			EmptyTiles [IndexForNewNumber].Number = 2;
			EmptyTiles.RemoveAt (IndexForNewNumber);
		}*/
		if (EmptyTiles.Count > 0) 
		{
			int indexForNewNumber = Random.Range(0, EmptyTiles.Count);
			int randomNum = Random.Range(0,10);
			if (randomNum == 0)
				EmptyTiles[indexForNewNumber].Number = 4;
			else
				EmptyTiles[indexForNewNumber].Number = 2;
			EmptyTiles.RemoveAt(indexForNewNumber);
		}
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G))
			Generate ();
	}

	public void Move(MoveDirection md) {
		Debug.Log (md.ToString () + "move.");
	}

}
