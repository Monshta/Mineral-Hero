using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public GameObject mps;
	public RectTransform mpsUI;

	Text txt;	//VARIABLE FOR THE TEXT COMPONENT
	private GameObject gameManager;	//VARIABLE FOR THE "GAMEMANAGER" GAMEOBJECT
	private Main main;	//VARIABLE FOR THE "MAIN" SCRIPT

	public Text mpsText;

	void Start () {
		txt = GetComponent<Text> ();	//REFERS TO TEXT COMPONENT FROM PARENT OF THIS SCRIPT
		gameManager = GameObject.Find ("GameManager");	//FINDS FOR THE GAMEOBJECT CALLED "MINE"
		main = gameManager.GetComponent<Main> ();	//REFERS TO THE "MAIN" SCRIPT COMPONENT FROM THE "MINE" GAMEOBJECT
		mpsUI = mps.GetComponent<RectTransform> ();
	}

	void Update () {
		mpsUI.sizeDelta = new Vector2 (main.timer * 125, 20);
		txt.text = Mathf.FloorToInt (main.mineralCount) + "";	//ROUNDS THE MINERAL COUNT TO AN INTEGER
		mpsText.text = main.mineralPerSecond + " MPS";
	}
}
