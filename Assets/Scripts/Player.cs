using UnityEngine;
using System.Collections;

public class Player {

	private int selectedColor;
	private bool isReady;
	private int currentGridSquare;
	private int score;
	private string name;

	public Player(string name){
		this.name = name;
		this.selectedColor = 0;
		this.currentGridSquare = 0;
		this.score = 0;
		this.isReady = false;
	}

	public int SelectedColor {
		get {
			return this.selectedColor;
		}
		set {
			selectedColor = value;
		}
	}

	public int CurrentGridSquare {
		get {
			return this.currentGridSquare;
		}
		set {
			currentGridSquare = value;
		}
	}

	public bool IsReady {
		get {
			return this.isReady;
		}
		set {
			isReady = value;
		}
	}

	public int Score {
		get {
			return this.score;
		}
		set {
			score = value;
		}
	}

	public string Name {
		get {
			return this.name;
		}
		set {
			name = value;
		}
	}
}
