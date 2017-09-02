using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveDirection{
	Left, Right, Up, Down
}


public class InputManager : MonoBehaviour {

	public GameManager gm;

	void Awake(){
		gm = GameObject.FindObjectOfType<GameManager> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			//Right move
			gm.Move(MoveDirection.Right);
		}	else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			//left move
			gm.Move(MoveDirection.Left);
		} 	else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//Up move
			gm.Move(MoveDirection.Up);
		} 	else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//Down move
			gm.Move(MoveDirection.Down);
		}
	}
}
