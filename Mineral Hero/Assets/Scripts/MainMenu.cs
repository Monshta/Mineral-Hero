using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;



public class MainMenu: MonoBehaviour
{
	public void startButton(int sb)
	{
		Application.LoadLevel("main");
	}
}