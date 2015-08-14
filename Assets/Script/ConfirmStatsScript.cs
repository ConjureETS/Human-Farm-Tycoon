using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConfirmStatsScript : MonoBehaviour {

    public Text currentValues;
    public Text addedValues;
    public Text alertTitle;
    public Text descrEvent;
    private Stats stats;


    void Awake()
    {
        stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
    }

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateView()
    {
        currentValues.text = stats.displayCurrentStats();
        addedValues.text = stats.displayAddingStats();
        alertTitle.text = "DAY " + stats.NbTurns;
    }

    public void ModifieStats()
    {

        descrEvent.text = stats.UpdateStats();
    }
}
