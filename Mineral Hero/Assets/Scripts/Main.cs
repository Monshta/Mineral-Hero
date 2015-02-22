using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Main : MonoBehaviour {
	public float mineralCount = 0;	//TOTAL MINERALS
	public float mineralPerSecond = 0;	//HOW MANY MINERALS YOU GAIN PER SECOND

	public int clickStrength = 1;	//HOW MANY MINERALS YOU GAIN PER CLICK

	public int clickerCount = 0;
	public Text clickerCountUI;
	public int minerCount = 0;
	public Text minerCountUI;
	public int cartCount = 0;
	public Text cartCountUI;

	void Awake (){

	}

	void Update (){
		mineralCount += mineralPerSecond * Time.deltaTime;	//INCREASE TOTAL MINERALS BY MINERALPERSECOND EVERY SECOND
		//COUNTER UI
		clickerCountUI.text = clickerCount + "";
		minerCountUI.text = minerCount + "";
		cartCountUI.text = cartCount + "";
	}
	public void upgradeClick(int c) {	//UPGRADE CLICKER
		clickStrength++;
		clickerCount++;

	}
	public void upgradeMiner(int m){	//UPGRADE MINER
		mineralPerSecond++;
		minerCount++;
	}
	public void upgradeCart(int ca){	//UPGRADE CART
		mineralPerSecond += 2;
		cartCount++;
	}
}







