using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour {

	private int number;
	private Text TileText;
	private Image TileImage;

	public int Number{
		get{
			return number;
		}
		set{
			number = value;	
			if (number == 0)
				SetEmpty ();
			else {
				ApplyStyle (number);
				SetVisible ();
			}
		}
	}

	void Awake(){
		TileText = GetComponentInChildren<Text> ();
		TileImage = transform.Find ("Number Cell").GetComponent<Image> ();
	}

	void ApplyStyleFromHolder(int index){
		TileText.text = TileStyleHolder.Instance.TileStyles [index].number.ToString();
		TileText.color = TileStyleHolder.Instance.TileStyles [index].TextColor;
		TileImage.color = TileStyleHolder.Instance.TileStyles [index].TileColor;
	}

	void ApplyStyle(int n) {
		switch (n) {
		case 2:
			ApplyStyleFromHolder (0);
			break;
		case 4:
			ApplyStyleFromHolder (1);
			break;
		case 8:
			ApplyStyleFromHolder (2);
			break;
		case 16:
			ApplyStyleFromHolder (3);
			break;
		case 32:
			ApplyStyleFromHolder (4);
			break;
		case 64:
			ApplyStyleFromHolder (5);
			break;
		case 128:
			ApplyStyleFromHolder (6);
			break;
		case 256:
			ApplyStyleFromHolder (7);
			break;
		case 512:
			ApplyStyleFromHolder (8);
			break;
		case 1024:
			ApplyStyleFromHolder (9);
			break;
		case 2046:
			ApplyStyleFromHolder (10);
			break;
		case 4096:
			ApplyStyleFromHolder (11);
			break;
		case 8192:
			ApplyStyleFromHolder (12);
			break;
		case 16384:
			ApplyStyleFromHolder (13);
			break;
		case 32764:
			ApplyStyleFromHolder (14);
			break;
		case 65536:
			ApplyStyleFromHolder (15);
			break;
		case 131072:
			ApplyStyleFromHolder (16);
			break;
		default:
			Debug.LogError ("check the numbers you want to apply style");
			break;
		}
	}

	private void SetVisible() {
		TileImage.enabled = true;
		TileText.enabled = true;
	}

	private void SetEmpty() {
		TileImage.enabled = false;
		TileText.enabled = false;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
