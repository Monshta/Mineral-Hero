using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Main : MonoBehaviour {
	public float mineralCount = 0;	//TOTAL MINERALS
	public float mineralPerSecond = 0;	//HOW MANY MINERALS YOU GAIN PER SECOND
	public float timer;

	public int clickStrength = 1;
	public int clickerCount = 0;
	public int clickerCost = 5;
	public Text clickerCountUI;

	public int minerCount = 0;
	public int minerCost = 10;
	public int minermps = 1;
	public Text minerCountUI;

	public int cartCount = 0;
	public int cartCost = 50;
	public int cartmps = 2;
	public Text cartCountUI;

	public int robotCount = 0;
	public int robotCost = 100;
	public int robotmps = 5;
	public Text robotCountUI;

	public int extractorCount = 0;
	public int extractorCost = 300;
	public int extractormps = 8;
	public Text extractorCountUI;

	public int laserCount = 0;
	public int laserCost = 700;
	public int lasermps = 10;
	public Text laserCountUI;

	public int goatCount = 0;
	public int goatCost = 1000;
	public int goatmps = 15;
	public Text goatCountUI;

	void Awake (){

	}

	void Update (){
		//mineralCount += mineralPerSecond * Time.deltaTime;	//INCREASE TOTAL MINERALS BY MINERALPERSECOND EVERY SECOND
		if (mineralPerSecond > 0) {
			timer += Time.deltaTime;
		}
		if (timer >= 1) {
			mineralCount += mineralPerSecond;
			timer = 0;
		}
		//COUNTER UI
		clickerCountUI.text = clickerCount + "";
		minerCountUI.text = minerCount + "";
		cartCountUI.text = cartCount + "";
		robotCountUI.text = robotCount + "";
		extractorCountUI.text = extractorCount + "";
		laserCountUI.text = laserCount + "";
		goatCountUI.text = goatCount + "";
	}
	public void upgradeClick(int c) {	//UPGRADE CLICKER
		if(mineralCount >= clickerCost){
			clickStrength++;
			clickerCount++;
			mineralCount -= clickerCost;
			clickerCost+=2;
		}
	}
	public void upgradeMiner(int m){	//UPGRADE MINER
		if (mineralCount >= minerCost) {
			mineralPerSecond += minermps;
			minerCount++;
			mineralCount -= minerCost;
			minerCost += 3;
		}				
	}
	public void upgradeCart(int ca){	//UPGRADE CART
		if (mineralCount >= cartCost) {
			mineralPerSecond += cartmps;
			cartCount++;
			mineralCount -= cartCost;
			cartCost += 10;
		}
	}
	public void upgradeRobot(int r){ //Robot upgrade
		if (mineralCount >= robotCost) {
			mineralPerSecond += robotmps;
			robotCount ++;
			mineralCount -= robotCost;
			robotCost += 25;
		}
	}
	public void upgradeExtractor(int e){ //extractor upgrade
		if (mineralCount >= extractorCost) {
			mineralPerSecond += extractormps;
			extractorCount ++;
			mineralCount-= extractorCost;
			extractorCost+= 50;
		}
	}
	public void upgradeLaser(int l){ //Laser upgrade
		if(mineralCount>= laserCost){
			mineralPerSecond += lasermps;
			laserCount ++;
			mineralCount -= laserCost;
			laserCost+=100;
		}
	}
	public void upgradeGoat(int g){ //goat upgrade, yep he's OP
		if(mineralCount>= goatCost){
			mineralPerSecond += goatmps;
			goatCount ++;
			mineralCount -= goatCost;
			goatCost+=500;
		}

	}
}







