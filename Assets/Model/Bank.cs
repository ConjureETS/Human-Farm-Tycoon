using UnityEngine;
using System.Collections;

public class Bank{

    private int amountOfRock;
    private int amountOfWood;
    private int amountOfCorpse;
    private int amountOfMeat;

    public Bank(int nbRock, int nbWood, int nbCorpse, int nbMeat)
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
}