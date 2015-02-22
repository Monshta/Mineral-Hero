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
	public int robotCount = 0;
	public Text robotCountUI; // idk how to make the little images but i still made these for you
	public int extractorCount = 0;
	public Text extractorCountUI;
	public int laserCount = 0;
	public Text laserCountUI;
	public int goatCount = 0;
	public Text goatCountUI;

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
	public void upgradeRobot(int r){ //Robot upgrade
		mineralPerSecond += 5;
		robotCount ++;
	}
	public void upgradeExtractor(int e){ //extractor upgrade
		clickStrength += 5;
		extractorCount ++;
	}
	public void upgradeLaser(int l){ //Laser upgrade
		mineralPerSecond += 10;
		laserCount ++;
	}
	public void upgradeGoat(int g){ //goat upgrade
		mineralPerSecond += 10;
		clickStrength += 10;
		goatCount ++;

	}
}







