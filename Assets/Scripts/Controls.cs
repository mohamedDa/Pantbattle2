using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			LevelManager.INSTANCE.PlayerMoveRequest(LevelManager.Direction.North);
			//			if(PlayerMoveRequest){
			//				//moveplayer
			//			}
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			LevelManager.INSTANCE.PlayerMoveRequest(LevelManager.Direction.East);
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			LevelManager.INSTANCE.PlayerMoveRequest(LevelManager.Direction.South);
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			LevelManager.INSTANCE.PlayerMoveRequest(LevelManager.Direction.West);
		}
		if(Input.GetKeyDown(KeyCode.C)){
			LevelManager.INSTANCE.RotateSelectedColor();
		}
	}
}
