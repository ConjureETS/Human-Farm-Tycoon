using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

    private int amountOfRock;
    private int amountOfWood;
    private int amountOfCorpse;
    private int amountOfMeat;

    private int amountOfZombies;    
    private int amountOfHumans;
    private int amountOfZombiesAvail;

    public int AmountOfMeat
    {
        get { return amountOfMeat; }
        set { amountOfMeat = value; }
    }

    public int AmountOfRock
    {
        get { return amountOfRock; }
        set { amountOfRock = value; }
    }

    public int AmountOfWood
    {
        get { return amountOfWood; }
        set { amountOfWood = value; }
    }

    public int AmountOfCorpse
    {
        get { return amountOfCorpse; }
        set { amountOfCorpse = value; }
    }

    public int AmountOfZombies
    {
        get { return amountOfZombies; }
        set { amountOfZombies = value; }
    }

    public int AmountOfHumans
    {
        get { return amountOfHumans; }
        set { amountOfHumans = value; }
    }

    public int AmountOfZombiesAvail
    {
        get { return amountOfZombiesAvail; }
        set { amountOfZombiesAvail = value; }
    }

    public Stats(int nbRock, int nbWood, int nbCorpse, int nbMeat, int nbHumans, int nbZombies)
    {
        resetStats(nbRock, nbWood, nbCorpse, nbMeat, nbHumans, nbZombies);
    }

    public void resetStats(int nbRock, int nbWood, int nbCorpse, int nbMeat, int nbHumans, int nbZombies) 
    {
        AmountOfCorpse = nbCorpse;
        AmountOfMeat = nbMeat;
        AmountOfRock = nbRock;
        AmountOfWood = nbWood;
        AmountOfHumans = nbHumans;
        AmountOfZombies = nbZombies;
    }

    public void addCorpse()
    {
        amountOfCorpse++;
    }

    public void addWood()
    {
        amountOfWood++;
    }

    public void addMeat()
    {
        amountOfMeat++;
    }

    public void addRock()
    {
        amountOfRock++;
    }

    public void addZombie()
    {
        amountOfZombies++;
    }

    public void addHuman()
    {
        amountOfHumans++;
    }

    public void addZombieAvail()
    {
        amountOfZombiesAvail++;
    }

    public void removeCorpse()
    {
        amountOfCorpse--;
    }

    public void removeWood()
    {
        amountOfWood--;
    }

    public void removeMeat()
    {
        amountOfMeat--;
    }

    public void removeRock()
    {
        amountOfRock--;
    }

    public void removeZombie()
    {
        amountOfZombies--;
    }

    public void removeHuman()
    {
        amountOfHumans--;
    }

    public void removeZombieAvail()
    {
        amountOfZombiesAvail--;
    }

	// Use this for initialization
	void Start () {
        resetStats(0, 0, 0, 0, 4, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
