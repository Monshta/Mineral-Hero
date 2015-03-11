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
	public int clickerCost = 10;
	public Text clickerCountUI;
	
	public int minerCount = 0;
	public float minerCost = 30f;
	public int minermps = 1;
	public Text minerCountUI;
	
	public int cartCount = 0;
	public float cartCost = 150f;
	public int cartmps = 2;
	public Text cartCountUI;
	
	public int robotCount = 0;
	public float robotCost = 500f;
	public int robotmps = 5;
	public Text robotCountUI;
	
	public int extractorCount = 0;
	public int extractorCost = 1500;
	public int extractormps = 8;
	public Text extractorCountUI;
	
	public int laserCount = 0;
	public int laserCost = 5000;
	public int lasermps = 15;
	public Text laserCountUI;
	
	public int goatCount = 0;
	public int goatCost = 10000;
	public int goatmps = 25;
	public Text goatCountUI;
	
	public GameObject steroidModUI;
	public GameObject oilModUI;
	public GameObject batteryModUI;
	public GameObject titaniumModUI;
	public GameObject glassModUI;
	public GameObject goatModUI;
	
	public int steroidModCost = 150;
	public int oilModCost = 250;
	public int batteryModCost = 800;
	public int titaniumModCost = 3000;
	public int glassModCost = 8000;
	public int goatModCost = 15000;
	
	
	void Update (){
		mineralPerSecond =  (minermps * minerCount)+
			(cartmps * cartCount)+
				(robotmps * robotCount)+
				(extractormps * extractorCount)+
				(lasermps * laserCount)+
				(goatmps * goatCount);
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
			clickerCost*=2;
		}
	}
	public void upgradeMiner(int m){	//UPGRADE MINER
		if (mineralCount >= minerCost) {
			minerCount++;
			mineralCount -= minerCost;
			minerCost *= 1.7f;
		}				
	}
	public void upgradeCart(int ca){	//UPGRADE CART
		if (mineralCount >= cartCost) {
			cartCount++;
			mineralCount -= cartCost;
			cartCost *= 1.8f;
		}
	}
	public void upgradeRobot(int r){ //Robot upgrade
		if (mineralCount >= robotCost) {
			mineralPerSecond += robotmps;
			robotCount ++;
			mineralCount -= robotCost;
			robotCost *= 1.9f;
		}
	}
	public void upgradeExtractor(int e){ //extractor upgrade
		if (mineralCount >= extractorCost) {
			mineralPerSecond += extractormps;
			extractorCount ++;
			mineralCount -= extractorCost;
			extractorCost *= 3;
		}
	}
	public void upgradeLaser(int l){ //Laser upgrade
		if(mineralCount>= laserCost){
			mineralPerSecond += lasermps;
			laserCount ++;
			mineralCount -= laserCost;
			laserCost*=2;
		}
	}
	public void upgradeGoat(int g){ //goat upgrade, yep he's OP
		if(mineralCount>= goatCost){
			mineralPerSecond += goatmps;
			goatCount ++;
			mineralCount -= goatCost;
			goatCost*=2;
		}
	}
	
	public void steroidMod(int s) {
		if (mineralCount >= steroidModCost) {
			minermps *= 2;
			mineralCount-=steroidModCost;
			steroidModUI.SetActive (false);
		}
	}
	public void oilMod(int o) {
		if (mineralCount >= oilModCost) {
			cartmps *= 2;
			mineralCount-=oilModCost;
			oilModUI.SetActive (false);
		}
	}
	public void batteryMod(int b) {
		if(mineralCount>=batteryModCost){
			robotmps *= 2;
			mineralCount-=batteryModCost;
			batteryModUI.SetActive (false);
		}
	}
	public void titaniumMod(int t) {
		if(mineralCount>=titaniumModCost){
			extractormps *= 2;
			mineralCount-=titaniumModCost;
			titaniumModUI.SetActive (false);
		};
	}
	public void glassMod(int g) {
		if(mineralCount>=glassModCost){	
			lasermps *= 2;
			mineralCount-=glassModCost;
			glassModUI.SetActive (false);
		}
	}
	public void goatMod(int go) {
		if(mineralCount>=goatModCost){
			goatmps *= 2;
			mineralCount-=goatModCost;
			goatModUI.SetActive (false);
		}
	}
}
