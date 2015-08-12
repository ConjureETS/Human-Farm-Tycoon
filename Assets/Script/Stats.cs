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

    public Stats(int nbRock, int nbWood, int nbCorpse, int nbMeat, int nbHumans, int nbZombies)
    {
        AmountOfCorpse = nbCorpse;
        AmountOfMeat = nbMeat;
        AmountOfRock = nbRock;
        AmountOfWood = nbWood;
    }

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

	// Use this for initialization
	void Start () {
        AmountOfCorpse = 1;
        AmountOfMeat = 2;
        AmountOfRock = 3;
        AmountOfWood = 4;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
