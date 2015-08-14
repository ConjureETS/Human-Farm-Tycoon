using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConfirmStatsScript : MonoBehaviour {

    public Text currentValues;
    public Text addedValues;
    public Text alertTitle;
    private Stats stats;

	// Use this for initialization
	void Start () {
        stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
        currentValues.text = stats.displayCurrentStats();
        addedValues.text = stats.displayAddingStats();
        alertTitle.text = "DAY " + stats.NbTurns;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ModifieStats()
    {
        stats.UpdateStats();
    }
}
