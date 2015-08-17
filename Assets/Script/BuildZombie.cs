using UnityEngine;
using System.Collections;

public class BuildZombie: MonoBehaviour {
	private GameObject[] Grid;
	public GameObject zombieHouse;
	private Stats stats;
	public void onClick()
	{
		stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
		if (stats.AmountOfCorpse >= 6) {
			stats.removeCorpse(6);
			stats.AmountZombieHouse++;
			Grid = GameObject.FindGameObjectsWithTag ("Zombie");
			Instantiate (zombieHouse, Grid[Grid.Length-1].transform.position, Grid[Grid.Length-1].transform.rotation);
			DestroyObject (Grid[Grid.Length-1]);
			stats.displayStats();
		}
	}
}
