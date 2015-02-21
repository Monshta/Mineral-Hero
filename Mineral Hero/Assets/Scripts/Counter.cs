using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour {

	Text txt;
	private GameObject gameManager;
	private Main main;

	void Start () {
		txt = GetComponent<Text> ();
		gameManager = GameObject.Find ("GameManager");
		main = gameManager.GetComponent<Main> ();
	}

	void Update () {
		txt.text = main.clickerCount + "";
	}
}
