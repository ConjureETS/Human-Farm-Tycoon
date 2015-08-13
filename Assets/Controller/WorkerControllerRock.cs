using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WorkerControllerRock : MonoBehaviour{

    public Text nbWorker;
    public Text zombieAvailable;
    public Text nbRessourceExpected;
    public Button AddButton;
    public Button RemoveButton;
    private Stats stats;

    

    public void AddWorker()
    {
        stats.removeZombieAvail();
        stats.NbZombieAssigneRock++;
        UpdateView();
    }

    public void LessWorker()
    {
        stats.addZombieAvail();
        stats.NbZombieAssigneRock--;
        UpdateView();
    }

    private void UpdateView()
    {
        zombieAvailable.text = stats.AmountOfZombiesAvail + "/" + stats.AmountOfZombies;
        nbRessourceExpected.text = ""+stats.NbOfRockByZombie * stats.NbZombieAssigneRock;
        nbWorker.text = "" + stats.NbZombieAssigneRock;

        if (stats.AmountOfZombiesAvail <= 0)
        {
            AddButton.enabled = false;
        }
        else
        {
            AddButton.enabled = true;
        }

        if (stats.NbZombieAssigneRock <= 0)
        {
            RemoveButton.enabled = false;
        }
        else
        {
            RemoveButton.enabled = true;
        }
    }

	// Use this for initialization
	void Start () {
        stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();
        
	}
	
	// Update is called once per frame
	void Update () {
	    UpdateView();
	}
}
