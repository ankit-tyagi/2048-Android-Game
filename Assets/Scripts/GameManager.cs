using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private Tile[,] AllTiles = new Tile[4, 4];

	private List<Tile[]> columns = new List<Tile[]> ();
	private List<Tile[]> rows = new List<Tile[]> ();
	private List<Tile> EmptyTiles = new List<Tile>();

	// Use this for initialization
	void Start () {
		Tile[] AllTilesOneDim = GameObject.FindObjectsOfType<Tile> ();
		foreach (Tile t in AllTilesOneDim) {
			t.Number = 0;
			AllTiles [t.IndexRow, t.IndexCol] = t;
			EmptyTiles.Add (t);
		} 

		columns.Add (new Tile[4] {AllTiles [0, 0], AllTiles [1, 0], AllTiles [2, 0], AllTiles [3, 0]});
		columns.Add (new Tile[4]{ AllTiles [0, 1], AllTiles [1, 1], AllTiles [2, 1], AllTiles [3, 1] });
		columns.Add (new Tile[4]{ AllTiles [0, 2], AllTiles [1, 2], AllTiles [2, 2], AllTiles [3, 2] });
		columns.Add (new Tile[4]{ AllTiles [0, 3], AllTiles [1, 3], AllTiles [2, 3], AllTiles [3, 3] });

		rows.Add (new Tile[4]{ AllTiles [0, 0], AllTiles [0, 1], AllTiles [0, 2], AllTiles [0, 3] });
		rows.Add (new Tile[4]{ AllTiles [1, 0], AllTiles [1, 1], AllTiles [1, 2], AllTiles [1, 3] });
		rows.Add (new Tile[4]{ AllTiles [2, 0], AllTiles [2, 1], AllTiles [2, 2], AllTiles [2, 3] });
		rows.Add (new Tile[4]{ AllTiles [3, 0], AllTiles [3, 1], AllTiles [3, 2], AllTiles [3, 3] });

	}

	bool MakeOneMoveDownIndex(Tile[] LineOfTiles){
		for (int i = 0; i <LineOfTiles.Length-1 ; i++) {
			//move block
			if (LineOfTiles [i].Number == 0 && LineOfTiles [i + 1].Number != 0) {
				LineOfTiles [i].Number = LineOfTiles [i + 1].Number;
				LineOfTiles [i + 1].Number = 0;
				return true;
			}
		}
		return false;
	}

	bool MakeOneMoveUpIndex(Tile[] LineOfTiles){
		for (int i = LineOfTiles.Length-1; i > 0 ; i--) {
			//move block
			if (LineOfTiles [i].Number == 0 && LineOfTiles [i - 1].Number != 0) {
				LineOfTiles [i].Number = LineOfTiles [i - 1].Number;
				LineOfTiles [i - 1].Number = 0;
			}
		}
	}

	void Generate(){
		if (EmptyTiles.Count > 0) 
		{
			int indexForNewNumber = Random.Range(0, EmptyTiles.Count);
			int randomNum = Random.Range(0,10);
			if (randomNum == 0 || randomNum == 1)
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
