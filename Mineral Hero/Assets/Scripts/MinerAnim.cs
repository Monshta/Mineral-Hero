using UnityEngine;
using System.Collections;

public class MinerAnim : MonoBehaviour {

	private GameObject gameManager;
	private Main main;
	private SpriteRenderer spriteRend;

	public int numberOfMiner;

	void Start () {
		gameManager = GameObject.Find ("GameManager");
		main = gameManager.GetComponent<Main> ();
		spriteRend = gameObject.GetComponent<SpriteRenderer>();
	}

	void Update () {
		if (main.minerCount >= numberOfMiner) {
			spriteRend.enabled = true;
		}else {
			spriteRend.enabled = false;
		}
	}
}
