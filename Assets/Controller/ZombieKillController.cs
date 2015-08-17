using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZombieKillController : MonoBehaviour {
	public Text nbWorker;
	public Text zombieAvailable;
	public Text nbRessourceExpected;
	public Text nbHumanAvailable;
	public Button AddButton;
	public Button RemoveButton;
	private Stats stats;
	
	public void AddWorker()
	{
		stats.removeZombieAvail();
		stats.NbZombieAssigneKillHuman++;
		//stats.AmountOfCorpse++;
		stats.AmountOfHumans--;
		UpdateView();
	}
	
	public void LessWorker()
	{
		stats.addZombieAvail();
		stats.NbZombieAssigneKillHuman--;
		//stats.AmountOfCorpse--;
		stats.AmountOfHumans++;
		UpdateView();
	}
	
	private void UpdateView()
	{
		zombieAvailable.text = "Zombie Available : " + stats.AmountOfZombiesAvail + "/" + stats.AmountOfZombies;
		nbRessourceExpected.text = "Corpse made  : " + stats.NbZombieAssigneKillHuman;
		nbWorker.text = "" + stats.NbZombieAssigneKillHuman;
		nbHumanAvailable.text = "Humans: " + stats.AmountOfHumans;
		
		if (stats.AmountOfZombiesAvail <= 0 || stats.AmountOfHumans <= 0)
		{
			AddButton.enabled = false;
		}
		else
		{
			AddButton.enabled = true;
		}
		
		if (stats.NbZombieAssigneKillHuman <= 0)
		{
			RemoveButton.enabled = false;
		}
		else
		{
			RemoveButton.enabled = true;
		}
	}
	
	// Use this for initialization
	void Start()
	{
		stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
	}
	
	// Update is called once per frame
	void Update()
	{
		UpdateView();
	}

}
