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
						"\nExtract the essence of the goats.";
	}

	public void LaserMessage (string l) {
		descText.text = "Laser" +
						"\nCost: " + main.laserCost + 
						"\nGaining: +" + main.lasermps + " mps" +
						"\nPew pew pew pew pew.";
	}

	public void GoatMessage (string g) {
		descText.text = "Goat" +
						"\nCost: " + main.goatCost + 
						"\nGaining: +" + main.goatmps + " mps" +
						"\nMoooooooooo!";
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
	public void juniorGoat () {
		descText.text = "Requirements:" +
						"\nCost: " + main.upGoat1Cost +
						"\n3 Goats & 25 Miners." +
						"\nMPS: " + main.upGoat1mps;
	}
	public void seniorGoat () {
		descText.text = "Requirements:" +	
						"\nCost: " + main.upGoat2Cost +
						"\n8 Goats & 50 Minecarts." +
						"\nMPS: " + main.upGoat2mps;
	}
	public void monsterGoat () {
		descText.text = "Requirements:" +
						"\nCost: " + main.upGoat3Cost +
						"\n20 Goats & 30 Robot." +
						"\nMPS: " + main.upGoat3mps;
	}
	public void zombieGoat () {
		descText.text = "Requirements:" +
						"\nCost: " + main.upGoat4Cost +
						"\n50 Goats & 50 Lasers" +
						"\nMPS: " + main.upGoat4mps;
	}
	public void terminatorGoat () {
		descText.text = "Requirements:" +
						"\nCost: " + main.upGoat5Cost +
						"\n100 Goats & 90 Lasers" +
						"\nMPS: " + main.upGoat5mps;
	}
	public void superGoat () {
		descText.text = "Requirements:" +
						"\nCost: " + main.upGoat6Cost +
						"\n150 Goats & 130 Lasers" +
						"\nMPS: " + main.upGoat6mps;
	}	

	public void exitMessage (string ex) {
		descText.text = "";
	}
}







