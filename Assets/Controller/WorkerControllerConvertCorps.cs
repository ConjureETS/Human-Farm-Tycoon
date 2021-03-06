﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WorkerControllerConvertCorps : MonoBehaviour {

    public Text nbWorker;
    public Text zombieAvailable;
    public Text nbRessourceExpected;
    public Text nbCorpseAvailable;
    public Button AddButton;
    public Button RemoveButton;
    private Stats stats;
    
    public void AddWorker()
    {
        stats.removeZombieAvail();
        stats.NbZombieAssigneCorpse++;
        stats.AmountOfCorpse--;
        UpdateView();
    }

    public void LessWorker()
    {
        stats.addZombieAvail();
        stats.NbZombieAssigneCorpse--;
        stats.AmountOfCorpse--;
        UpdateView();
    }

    private void UpdateView()
    {
        zombieAvailable.text = "Zombie Available : " + stats.AmountOfZombiesAvail + "/" + stats.AmountOfZombies;
        nbRessourceExpected.text = "Zombie Expected : " + stats.NbZombieAssigneCorpse;
        nbWorker.text = "" + stats.NbZombieAssigneCorpse;
        nbCorpseAvailable.text = "Corpse : " + stats.AmountOfCorpse;

        if (stats.AmountOfZombiesAvail <= 0 || stats.AmountOfCorpse <= 0)
        {
            AddButton.enabled = false;
        }
        else
        {
            AddButton.enabled = true;
        }

        if (stats.NbZombieAssigneCorpse <= 0)
        {
            RemoveButton.enabled = false;
        }
        else
        {
            RemoveButton.enabled = true;
        }
    }

    // Use this for initialization
    void Start()
    {
        stats = GameObject.Find("Stats").gameObject.GetComponent<Stats>();

    }

    // Update is called once per frame
    void Update()
    {
        UpdateView();
    }
}
