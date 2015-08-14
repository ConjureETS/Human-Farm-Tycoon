using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VillageStatsController : MonoBehaviour {

    public Text textNbMaison;
    public Text textNbZombie;
    public Text textNbMaxZombie;
    private Stats stats;

	// Use this for initialization
	void Start () {
        stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
        UpdateView();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void UpdateView(){
        textNbMaison.text = "Nb Maisons : " + stats.AmountZombieHouse;
        textNbZombie.text = "Nb Zombies : " + stats.AmountOfZombies;
        textNbMaxZombie.text = "Max Zombies : " + stats.AmountZombieHouse * 10;
    }
}
