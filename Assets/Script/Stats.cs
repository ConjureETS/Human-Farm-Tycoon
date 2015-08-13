using UnityEngine;
using System.Collections;
using System;

public class Stats : MonoBehaviour
{
    #region attributes

    private int nbTurns;

    private int amountOfRock;
    private int amountOfWood;
    private int amountOfCorpse;
    private int amountOfMeat;

    private int amountOfZombies;    
    private int amountOfHumans;
    private int amountOfZombiesAvail;

    private int nbOfWoodByZombie;
    private int nbOfRockByZombie;
    private int nbOfMeatByZombie;
    private int nbOfCorpseByZombie;

    private int nbZombieAssigneWood;
    private int nbZombieAssigneRock;
    private int nbZombieAssigneCorpse;
    private int nbZombieAssigneMeat;

    private int nbHumanHouses;
    private int nbZombieHouses;

    private int humanHunger;
    private int zombieHunger;

    public int AmountOfZHunger
    {
        get { return zombieHunger; }
        set { zombieHunger = value; }
    }

    public int AmountOfHHunger
    {
        get { return  humanHunger; }
        set {  humanHunger = value; }
    }

    public int AmountHumanHouse
    {
        get { return nbHumanHouses; }
        set { nbHumanHouses = value; }
    }

    public int AmountZombieHouse
    {
        get { return nbZombieHouses; }
        set { nbZombieHouses = value; }
    }

    public int NbZombieAssigneMeat
	{
		get { return nbZombieAssigneMeat;}
		set { nbZombieAssigneMeat = value;}
	}	

	public int NbZombieAssigneCorpse
	{
		get { return nbZombieAssigneCorpse;}
		set { nbZombieAssigneCorpse = value;}
	}

    public int NbZombieAssigneRock
    {
        get { return nbZombieAssigneRock; }
        set { nbZombieAssigneRock = value; }
    }  

    public int NbZombieAssigneWood
    {
        get { return nbZombieAssigneWood; }
        set { nbZombieAssigneWood = value; }
    }

    public int NbOfCorpseByZombie
    {
        get { return nbOfCorpseByZombie; }
        set { nbOfCorpseByZombie = value; }
    }    

    public int NbOfMeatByZombie
    {
        get { return nbOfMeatByZombie; }
        set { nbOfMeatByZombie = value; }
    } 

    public int NbOfRockByZombie
    {
        get { return nbOfRockByZombie; }
        set { nbOfRockByZombie = value; }
    }
    
    public int NbOfWoodByZombie
    {
        get { return nbOfWoodByZombie; }
        set { nbOfWoodByZombie = value; }
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

    public int NbTurns
    {
        get { return nbTurns; }
        set { nbTurns = value; }
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
#endregion

    public Stats(int nbRock, int nbWood, int nbCorpse, int nbMeat, int nbHumans, int nbZombies)
    {
        resetStats(nbRock, nbWood, nbCorpse, nbMeat, nbHumans, nbZombies, 5, 5, 5, 5);
    }

    public void resetStats(int nbRock, int nbWood, int nbCorpse, int nbMeat, int nbHumans, int nbZombies,
        int nbOfWoodByZombie, int nbOfRockByZombie, int nbOfMeatByZombie, int nbOfCorpseByZombie)
    {
        AmountOfCorpse = nbCorpse;
        AmountOfMeat = nbMeat;
        AmountOfRock = nbRock;
        AmountOfWood = nbWood;
        AmountOfHumans = nbHumans;
        AmountOfZombies = nbZombies;
        NbOfCorpseByZombie = nbOfCorpseByZombie;
        NbOfMeatByZombie = nbOfMeatByZombie;
        NbOfRockByZombie = nbOfRockByZombie;
        NbOfWoodByZombie = nbOfWoodByZombie;
        NbZombieAssigneWood = 0;
        NbZombieAssigneRock = 0;
        NbZombieAssigneCorpse = 0;
        NbZombieAssigneMeat = 0;
        AmountOfZombiesAvail = AmountOfZombies;
        AmountOfHHunger = 250 * AmountOfHumans;
        AmountOfZHunger = 500 * AmountOfZombies;
    }

    private void applyStatModifications()
    {
        AmountOfCorpse += (NbZombieAssigneCorpse * NbOfCorpseByZombie);
        AmountOfMeat += (NbZombieAssigneMeat * NbOfMeatByZombie);
        AmountOfRock += (NbZombieAssigneRock * NbOfRockByZombie);
        AmountOfWood += (NbZombieAssigneWood * NbOfWoodByZombie);
    }

    private void advanceTurn()
    {
        nbTurns++;
    }

    private bool isHumanMaxCapacity()
    {
        int cap = nbHumanHouses * 10;
        if (AmountOfHumans > cap)
            return true;
        else
            return false;
    }

    private bool isZombieMaxCapacity()
    {
        int cap = nbZombieHouses * 10;
        if (AmountOfZombies > cap)
            return true;
        else
            return false;
    }

    public void endTurn()
    {
        if (!isHumanMaxCapacity())
            AmountOfHumans += (2 * AmountHumanHouse);
        if (isZombieMaxCapacity())
            AmountOfZombies -= AmountOfZombies % (AmountZombieHouse * 10);
        applyStatModifications();
        calculateHunger();
        advanceTurn();
    }

    private void calculateHunger()
    {
        AmountOfHHunger -= 10 * AmountOfHumans;
        AmountOfZHunger -= 50 * AmountOfZombies;        
    }

    public String displayStats()
    {
        //TODO: Needs completion and formatting
        String body = "";
        body += "Wood: " + AmountOfWood + "\n";
        body += "Meat: " + AmountOfMeat + "\n";
        body += "Corpses: " + AmountOfCorpse + "\n";
        body += "Rock: " + AmountOfRock + "\n";

        return body;
    }

    public String displayAddingStats()
    {
        //TODO: Needs completion and formatting
        String body = "";
        body += "+" + NbZombieAssigneWood * NbOfWoodByZombie + "\n" + "\n";
        body += "+" + NbZombieAssigneRock * NbOfRockByZombie + "\n" + "\n";
        body += "+" + NbZombieAssigneMeat * NbOfMeatByZombie + "\n" + "\n";
        body += "+" + NbZombieAssigneCorpse * NbOfCorpseByZombie + "\n" + "\n";

        return body;
    }

    public String displayCurrentStats()
    {
        String body = "";
        body += AmountOfWood + "\n" + "\n";
        body += AmountOfRock + "\n" + "\n";
        body += AmountOfMeat + "\n" + "\n";
        body += AmountOfCorpse + "\n" + "\n";

        return body;

    }

    // Use this for initialization
    void Start () {
        resetStats(3, 6, 7, 8, 4, 1, 5, 5, 5, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}