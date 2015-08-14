using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HungerScript : MonoBehaviour {

    public Slider sliderZombie;
    public Slider sliderHumans;
    private Stats stats;

    // Use this for initialization
    void Start()
    {
        stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
        sliderHumans.maxValue = stats.MaxHungerHuman;
        sliderZombie.maxValue = stats.MaxHungerZombies;
        sliderHumans.value = sliderHumans.maxValue;
        sliderZombie.value = sliderZombie.maxValue;
    }
	
	// Update is called once per frame
	void Update () {
        sliderHumans.maxValue = stats.MaxHungerHuman;
        sliderZombie.maxValue = stats.MaxHungerZombies;
        sliderHumans.value = stats.AmountOfHHunger;
        sliderZombie.value = stats.AmountOfZHunger;
	}
}
