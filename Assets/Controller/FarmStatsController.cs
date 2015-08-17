using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FarmStatsController : MonoBehaviour {

    public Text textNbMaison;
    public Text textNbHuman;
    public Text textNbMaxHuman;
    private Stats stats;

    // Use this for initialization
    void Start()
    {
        stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
        UpdateView();
    }

    // Update is called once per frame
    void Update()
    {
		UpdateView();
    }

    private void UpdateView()
    {
        textNbMaison.text = "# Human houses : " + stats.AmountHumanHouse;
        textNbHuman.text = "# Humans : " + stats.AmountOfHumans;
        textNbMaxHuman.text = "Max Humans : " + stats.AmountHumanHouse * 10;
    }
}
