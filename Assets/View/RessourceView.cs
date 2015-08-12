using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RessourceView: MonoBehaviour{

    private RessourceController rc;
    public Text corpseText;
    public Text rockText;
    public Text woodText;
    public Text meatText;

    void Start()
    {
        Stats stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
        rc = new RessourceController(stats, corpseText, rockText, woodText, meatText);
        setResources();
    }

    public void setResources() {
        rc.UpdateView();
    }

    void Update()
    {
        

    }
}
