using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WorkerController : MonoBehaviour{

    public Text nbWorker;
    public Text zombieAvailable;
    public Text nbRessourceExpected;
    private Stats stats;

    public void AddWorker()
    {
        stats.AmountOfZombiesAvail --;
        UpdateView();
    }

    public void LessWorker()
    {
        stats.AmountOfZombiesAvail ++;
        UpdateView();
    }

    public void UpdateView()
    {
        zombieAvailable.text = stats.AmountOfZombiesAvail + "/" + stats.AmountOfZombies;
        
    }

	// Use this for initialization
	void Start () {
        Stats stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
