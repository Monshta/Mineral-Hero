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

	public int upGoat1mps = 35;
	public int upGoat1Count = 0;
	public int upGoat1Cost = 20000;

	public int upGoat2mps = 40;
	public int upGoat2Count = 0;
	public int upGoat2Cost = 50000;

	public int upGoat3mps = 45;
	public int upGoat3Count = 0;
	public int upGoat3Cost = 100000;

	public int upGoat4mps = 50;
	public int upGoat4Count = 0;
	public int upGoat4Cost = 200000;

	public int upGoat5mps = 5;
	public int upGoat5Count = 0;
	public int upGoat5Cost = 500000;

	public int upGoat6mps = 5;
	public int upGoat6Count = 0;
	public int upGoat6Cost = 10000000;
	
	void Update (){
		mineralPerSecond =  (minermps * minerCount)+
			(cartmps * cartCount)+
				(robotmps * robotCount)+
				(extractormps * extractorCount)+
				(lasermps * laserCount)+
				(goatmps * goatCount) + 
				(upGoat1mps * upGoat1Count) +
				(upGoat2mps * upGoat2Count) +
				(upGoat3mps * upGoat3Count) +
				(upGoat4mps * upGoat4Count) +
				(upGoat5mps * upGoat5Count) +
				(upGoat6mps * upGoat6Count);
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
	public void upGoat1(int up1){
		if ((mineralCount >= upGoat1Cost)&&(goatCount >= 0)&&(laserCount >= 0)){
			upGoat1Count ++; 
			mineralCount -= upGoat1Cost;
			upGoat1Cost *=2;
		}
		}
	public void upGoats2(int up2){
		if ((mineralCount >= upGoat2Cost)&&(goatCount >= 0)&&(laserCount >= 0)){
			upGoat2Count ++; 
			mineralCount -= upGoat2Cost;
			upGoat2Cost *=2;
		}
	}

	public void upGoats3(int up3){
		if ((mineralCount >= upGoat3Cost)&&(goatCount >= 0)&&(laserCount >= 0)){
			upGoat3Count ++; 
			mineralCount -= upGoat3Cost;
			upGoat3Cost *=2;
		}
	}

	public void upGoats4(int up4){
		if ((mineralCount >= upGoat3Cost) && (goatCount >= 0) && (laserCount >= 0)) {
			upGoat4Count ++; 
			mineralCount -= upGoat3Cost;
			upGoat4Cost *= 2;
		}
	}

	public void upGoats5(int up5){
		if ((mineralCount >= upGoat5Cost) && (goatCount >= 0) && (laserCount >= 0)) {
			upGoat5Count ++; 
			mineralCount -= upGoat5Cost;
			upGoat5Cost *= 2;
		}
	}

	public void upGoats6(int up6){
		if ((mineralCount >= upGoat6Cost) && (minerCount >= 0) && (laserCount >= 0)) {
			upGoat6Count ++; 
			mineralCount -= upGoat6Cost;
			upGoat6Cost *= 2;
		}
	}
		
}
