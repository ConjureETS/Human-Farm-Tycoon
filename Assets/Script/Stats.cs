using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
    #region attributes
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
    }

	// Use this for initialization
	void Start () {
        resetStats(0, 0, 0, 0, 4, 1, 5, 5, 5, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
