using UnityEngine;
using System.Collections;

public class PlayerColor : MonoBehaviour {

	private int selectedColor = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RotateSelectedColor(){
		if(selectedColor >= Colors.Length - 1){
			selectedColor = 0;
		}
		else{
			selectedColor++;
		}
		EditGridSquare(currentGridSquare);
	}

	public void EditGridSquare(int index){
		LevelManager.INSTANCE.Grid[index].renderer.material.mainTexture = Colors[selectedColor];
		gridSquareColor[index] = selectedColor;
	}
}
