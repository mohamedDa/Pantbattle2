using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

	public static LevelManager INSTANCE;

	public GameObject GridPlanePrefab;
	public Texture[] Colors;

	private int gridWidth = 8;
	private int gridHeigth = 8;
	private GameObject[] grid;
	private int maxPlanes;  

	public enum Direction{
		North, 
		East, 
		South, 
		West,
	}
	
	void Awake(){
		INSTANCE = this;
	}

	// Use this for initialization
	void Start () {
		GenerateGrid();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GenerateGrid(){
		maxPlanes = gridWidth * gridHeigth;
		grid = new GameObject[maxPlanes];
		
		for(int x = 0; x < gridWidth; x++){
			for(int z = 0; z < gridHeigth; z++){
				GameObject gridPlane = (GameObject)Instantiate(GridPlanePrefab);
				gridPlane.transform.position = new Vector3(gridPlane.transform.position.x + x, gridPlane.transform.position.y, gridPlane.transform.position.z + z);
				gridPlane.AddComponent("GridSquare");
				gridPlane.gameObject.tag = "GridPlane";
				int gridID = (z * gridWidth + x);
				gridPlane.name = gridID.ToString();
				grid[gridID] = gridPlane;
			}
		}

		gridSquareColor = new Dictionary<int, int>();

		for(int i = 0; i < maxPlanes; i++){
			gridSquareColor.Add(i, selectedColor);
		}
	}

	/**
	 * Returns true if the player is allowed to move in that direction.
	 * Prevents player from going outside the grid.
	 **/ 
	public bool PlayerMoveRequest(Direction direction){
		switch(direction){
		case Direction.North:
			if(currentGridSquare <= maxPlanes - gridWidth){
				currentGridSquare += gridWidth;
				EditGridSquare(currentGridSquare);
				return true;
			}
			else{
				return false;
			}
			break;
		case Direction.East:
			if(currentGridSquare < maxPlanes - 1){
				currentGridSquare += 1;
				EditGridSquare(currentGridSquare);
				return true;
			}
			else{
				return false;
			}
			break;
		case Direction.South:
			if(currentGridSquare >= gridWidth){
				currentGridSquare -= gridWidth;
				EditGridSquare(currentGridSquare);
				return true;
			}
			else{
				return false;
			}
			break;
		case Direction.West:
			if(currentGridSquare > 0){
				currentGridSquare -= 1;
				EditGridSquare(currentGridSquare);
				return true;
			}
			else{
				return false;
			}
			break;
		default:
			return false;
			break;
		}
	}

	public void EditGridSquare(int index){
		grid[index].renderer.material.mainTexture = Colors[selectedColor];
		gridSquareColor[index] = selectedColor;
	}
}