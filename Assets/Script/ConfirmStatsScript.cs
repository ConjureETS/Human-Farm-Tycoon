using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConfirmStatsScript : MonoBehaviour {

    public Text currentValues;
    public Text addedValues;
    public Text alertTitle;

	// Use this for initialization
	void Start () {
        Stats stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
        currentValues.text = stats.displayCurrentStats();
        addedValues.text = stats.displayAddingStats();
        alertTitle.text = "DAY " + stats.NbTurns;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
