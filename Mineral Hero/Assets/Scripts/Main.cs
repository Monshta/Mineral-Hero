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

	public bool activateMiner = false;
	public bool newMiner;
	public bool minerBuff;
	public int minerBuffButton = 0;
	public int minerBuffCount;

	public int cartCount = 0;
	public int cartCost = 50;
	public int cartmps = 2;
	public Text cartCountUI;

	public bool activateCart = false;
	public bool newCart;
	public bool cartBuff;
	public int cartBuffButton = 0;
	public int cartBuffCount;

	public int robotCount = 0;
	public int robotCost = 100;
	public int robotmps = 5;
	public Text robotCountUI;

	public bool activateRobot = false;
	public bool newRobot;
	public bool robotBuff;
	public int robotBuffButton = 0;
	public int robotBuffCount;

	public int extractorCount = 0;
	public int extractorCost = 300;
	public int extractormps = 8;
	public Text extractorCountUI;

	public bool activateExtractor = false;
	public bool newExtractor;
	public bool extractorBuff;
	public int extractorBuffButton = 0;
	public int extractorBuffCount;

	public int laserCount = 0;
	public int laserCost = 700;
	public int lasermps = 10;
	public Text laserCountUI;

	public bool activateLaser = false;
	public bool newLaser;
	public bool laserBuff;
	public int laserBuffButton = 0;
	public int laserBuffCount;

	public int goatCount = 0;
	public int goatCost = 1000;
	public int goatmps = 15;
	public Text goatCountUI;

	public bool activateGoat = false;
	public bool newGoat;
	public bool goatBuff;
	public int goatBuffButton = 0;
	public int goatBuffCount;

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
		//Miner Modifyer
		while ((newMiner==true)&(activateMiner == true)) { ///Might have over killed it, but it works...
			if (minerBuff == true) {					// Except for the first part, it jumps to 4 when activated
					minerBuffCount = minerCount * 2;	//i think it excecutes the else statement too
					mineralPerSecond += minerBuffCount;
					minerBuff = false;
			} 
			else {
					mineralPerSecond += 1;
					newMiner=false;
				}
		}
		//Cart Modifyer
		while ((newCart==true)&(activateCart == true)) { 
			if (cartBuff == true) {					
				cartBuffCount = cartCount * 4;	
				mineralPerSecond += minerBuffCount;
				cartBuff = false;
			} 
			else {
				mineralPerSecond += 3;
				newCart=false;
			}
		}
		//Robot Modifyer
		while ((newRobot==true)&(activateRobot == true)) { //im gonna stop tweaking the numbers here coz they 
			if (robotBuff == true) {	//start getting out of hand				
				robotBuffCount = robotCount * 4;	
				mineralPerSecond += robotBuffCount;
				robotBuff = false;
			} 
			else {
				mineralPerSecond += 3;
				newRobot=false;
			}
		}
		//Extractor Modifyer
		while ((newExtractor==true)&(activateExtractor == true)) {  //these if/else mechanics are so wierd
			if (extractorBuff == true) {					// we can fix the numbers when we work on it together saturday
				extractorBuffCount = extractorCount * 4;	
				mineralPerSecond += extractorBuffCount;
				extractorBuff = false;
			} 
			else {
				mineralPerSecond += 3;
				newExtractor = false;
			}
		}
		//Laser Modifyer
		while ((newLaser==true)&(activateLaser == true)) {  
			if (laserBuff == true) {					
				laserBuffCount = laserCount * 4;	
				mineralPerSecond += laserBuffCount;
				laserBuff = false;
			} 
			else {
				mineralPerSecond += 3;
				newLaser = false;
			}
		}
		//Goat modifyer
		while ((newGoat==true)&(activateGoat == true)) {  
			if (goatBuff == true) {					
				goatBuffCount = goatCount * 4;	
				mineralPerSecond += goatBuffCount;
				goatBuff = false;
			} 
			else {
				mineralPerSecond += 3;
				newGoat = false;
			}
		}
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
			newMiner = true;
		}				
	}
	public void steroids(int s){
		minerBuff = true;
		activateMiner = true;

	}
	public void upgradeCart(int ca){	//UPGRADE CART
		if (mineralCount >= cartCost) {
			mineralPerSecond += cartmps;
			cartCount++;
			mineralCount -= cartCost;
			cartCost += 10;
			newCart = true;
		}
	}

	public void oil(int o){
	cartBuff = true;
	activateCart = true;
	
	}
	public void upgradeRobot(int r){ //Robot upgrade
		if (mineralCount >= robotCost) {
			mineralPerSecond += robotmps;
			robotCount ++;
			mineralCount -= robotCost;
			robotCost += 25;
			newRobot = true;
		}
	}
	public void Batt(int b){
		robotBuff = true;
		activateRobot = true;
		
	}
	public void upgradeExtractor(int e){ //extractor upgrade
		if (mineralCount >= extractorCost) {
			mineralPerSecond += extractormps;
			extractorCount ++;
			mineralCount -= extractorCost;
			extractorCost += 50;
			newExtractor = true;
			}
	}
	public void Titanium(int b){
			extractorBuff = true;
			activateExtractor = true;
			
	}

	public void upgradeLaser(int l){ //Laser upgrade
		if(mineralCount>= laserCost){
			mineralPerSecond += lasermps;
			laserCount ++;
			mineralCount -= laserCost;
			laserCost+=100;
			newLaser = true;
		}
	}
	public void Magnify(int m){
		laserBuff = true;
		activateLaser = true;
		
	}
	public void upgradeGoat(int g){ //goat upgrade, yep he's OP
		if(mineralCount>= goatCost){
			mineralPerSecond += goatmps;
			goatCount ++;
			mineralCount -= goatCost;
			goatCost+=500;
			newGoat = true;
		}

	}
	public void GOAT(int go){
		goatBuff = true;
		activateGoat = true;
		
	}
}







