using UnityEngine;
using System.Collections;

public class BuildHuman : MonoBehaviour {
	private GameObject[] Grid;
	public GameObject humanHouse;
	private Stats stats;
	public void onClick()
	{
		stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
		if (stats.AmountOfWood >= 6 && stats.AmountOfRock>=3) {
			stats.removeWood(6);
			stats.removeRock(3);
			stats.displayStats();
			stats.AmountHumanHouse ++;
			Grid = GameObject.FindGameObjectsWithTag ("Human");
			Instantiate (humanHouse, Grid[Grid.Length-1].transform.position, Grid[Grid.Length-1].transform.rotation);
			DestroyObject (Grid[Grid.Length-1]);
		}
	}
}
