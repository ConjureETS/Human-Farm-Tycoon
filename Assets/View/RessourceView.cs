using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RessourceView: MonoBehaviour{

    private RessourceController rc;
    public Text corpseText;
    public Text rockText;
    public Text woodText;
    public Text meatText;
	public Text zombieText;
	public Text humanText;
	

    void Start()
    {
        Stats stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
        rc = new RessourceController(stats, woodText, rockText, corpseText, meatText,humanText,zombieText);
    }

    void Update()
    {
        rc.UpdateView();
    }
}
