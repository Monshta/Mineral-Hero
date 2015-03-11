using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Description : MonoBehaviour {

	Text descText;
	private GameObject gameManager;
	private Main main;

	void Start () {
		descText = GetComponent<Text> ();
		gameManager = GameObject.Find ("GameManager");
		main = gameManager.GetComponent<Main> ();
	}	

	public void ClickerMessage (string c) {
		descText.text = "Clicker" +
						"\nCost: " + main.clickerCost + 
						"\nGaining: " + main.clickStrength + " Per Click" +
						"\nClick Click Click Click Click Click Click Click Click.";
	}

	public void MinerMessage (string m) {
		descText.text = "Miner" +
						"\nCost: " + Mathf.FloorToInt(main.minerCost) + 
						"\nGaining: +" + main.minermps + " mps" +
						"\nMiners Who Mine In Search Of The One True Goat.";
	}

	public void CartMessage (string ca) {
		descText.text = "Mine Cart" +
						"\nCost: " + Mathf.FloorToInt(main.cartCost) + 
						"\nGaining: +" + main.cartmps + " mps" +
						"\nThe Carts Of The Miners.";
	}

	public void RobotMessage (string r) {
		descText.text = "Robot" +
						"\nCost: " + Mathf.FloorToInt(main.robotCost) + 
						"\nGaining: +" + main.robotmps + " mps" +
						"\nBoom Bam Bop. Bada Bop Boom Pow!";
	}

	public void ExtractorMessage (string e) {
		descText.text = "Extractor" +
						"\nCost: " + main.extractorCost + 
						"\nGaining: +" + main.extractormps + " mps" +
						"\nI don't know what to put here yo.";
	}

	public void LaserMessage (string l) {
		descText.text = "Laser" +
						"\nCost: " + main.laserCost + 
						"\nGaining: +" + main.lasermps + " mps" +
						"\nLmfao it's 11:29PM and I'm tired.";
	}

	public void GoatMessage (string g) {
		descText.text = "Goat" +
						"\nCost: " + main.goatCost + 
						"\nGaining: +" + main.goatmps + " mps" +
						"\nIs that Gosu?!";
	}

	public void SteroidMessage (string g) {
		descText.text = "Steroid" +
						"\nCost: " + main.steroidModCost +
						"\nDoubles The Efficiency Of Miners";
	}
	public void OilMessage () {
		descText.text = "Oil" +
						"\nCost: " + main.oilModCost +
						"\nDoubles The Efficiency Of Minecarts";
	}
	public void BatteryMessage () {
		descText.text = "Battery" +
						"\nCost: " + main.batteryModCost +
						"\nDoubles The Efficiency Of Robots";
	}
	public void TitaniumMessage () {
		descText.text = "Titanium" +
						"\nCost: " + main.titaniumModCost +
						"\nDoubles The Efficiency Of Extractors";
	}
	public void GlassMessage () {
		descText.text = "Magnifying Glass" +
						"\nCost: " + main.glassModCost +
						"\nDoubles The Efficiency Of Lasers";
	}
	public void GoattMessage () {
		descText.text = "GOAT!" +
						"\nCost: " + main.goatModCost +
						"\nDoubles The Efficiency Of Goats!";
	}

	public void exitMessage (string ex) {
		descText.text = "";
	}
}







