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
		UpdateView();
	}

    private void UpdateView(){
        textNbMaison.text = "# of Zombie Houses : " + stats.AmountZombieHouse;
        textNbZombie.text = "# of Zombies : " + stats.AmountOfZombies;
        textNbMaxZombie.text = "Max Zombies : " + stats.AmountZombieHouse * 10;
    }
}
