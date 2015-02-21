using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
//this is a git test
public class ScoreManager : MonoBehaviour {

	Text txt;	//VARIABLE FOR THE TEXT COMPONENT
	private GameObject gameManager;	//VARIABLE FOR THE "GAMEMANAGER" GAMEOBJECT
	private Main main;	//VARIABLE FOR THE "MAIN" SCRIPT

	void Start () {
		txt = GetComponent<Text> ();	//REFERS TO TEXT COMPONENT FROM PARENT OF THIS SCRIPT
		gameManager = GameObject.Find ("GameManager");	//FINDS FOR THE GAMEOBJECT CALLED "MINE"
		main = gameManager.GetComponent<Main> ();	//REFERS TO THE "MAIN" SCRIPT COMPONENT FROM THE "MINE" GAMEOBJECT
	}

	void Update () {
		txt.text = Mathf.FloorToInt (main.mineralCount) + "";	//ROUNDS THE MINERAL COUNT TO AN INTEGER
	}
}
