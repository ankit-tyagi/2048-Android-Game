using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class TileStyle {
	public int number;
	public Color32 TileColor;
	public Color32 TextColor;
}

public class TileStyleHolder : MonoBehaviour {

	public static TileStyleHolder Instance;
	public TileStyle[] TileStyles;	

	void Awake(){
		Instance = this;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
}
