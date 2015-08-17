using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZombieEatController : MonoBehaviour {

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
        stats.NbZombieAssigneEat++;
        stats.AmountOfCorpse--;
        UpdateView();
    }

    public void LessWorker()
    {
        stats.addZombieAvail();
        stats.NbZombieAssigneEat--;
        stats.AmountOfCorpse++;
        UpdateView();
    }

    private void UpdateView()
    {
		stats.NbOfHungerByCoprseEat = 10;
        zombieAvailable.text = "Zombie Available : " + stats.AmountOfZombiesAvail + "/" + stats.AmountOfZombies;
        nbRessourceExpected.text = "Hunger Quenched  : " + stats.NbZombieAssigneEat * stats.NbOfHungerByCoprseEat;
        nbWorker.text = "" + stats.NbZombieAssigneEat;
        nbCorpseAvailable.text = "Corpse : " + stats.AmountOfCorpse;

        if (stats.AmountOfZombiesAvail <= 0 || stats.AmountOfCorpse <= 0)
        {
            AddButton.enabled = false;
        }
        else
        {
            AddButton.enabled = true;
        }

        if (stats.NbZombieAssigneEat <= 0)
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
