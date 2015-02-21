using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {

	public GameObject gameManager;
	private Main main;

	void Start () {
		main = gameManager.GetComponent<Main>();
	}

	void OnMouseDown () {
		main.mineralCount += main.clickStrength;
	}
}
