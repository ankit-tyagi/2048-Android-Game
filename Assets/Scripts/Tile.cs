using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour {

	private Text TileText;
	private Image TileImage;

	void Awake(){
		TileText = GetComponentInChildren<Text> ();
		TileImage = transform.Find ("Number Cell").GetComponent<Image> ();
	}

	void ApplyStyleFromHolder(int index){

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
