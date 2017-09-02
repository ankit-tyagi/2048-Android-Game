using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Tile[] AllTilesOneDim = GameObject.FindObjectsOfType<Tile> ();
		foreach (Tile t in AllTilesOneDim) {
			t.Number = 0;
		} 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Move(MoveDirection md) {
		Debug.Log (md.ToString () + "move.");
	}

}
