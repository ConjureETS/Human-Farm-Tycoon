using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RessourceController{
    Bank bank;
    Text viewWood;
    Text viewRock;
    Text viewCorpse;
    Text viewMeat;

    public RessourceController(Bank b, Text viewW, Text viewR, Text viewC, Text viewM)
    {
        this.bank = b;
        this.viewCorpse = viewC;
        this.viewWood = viewW;
        this.viewRock = viewR;
        this.viewMeat = viewM;
    }

    public void setRock(int nbRock){
        bank.AmountOfRock = nbRock;
    }
    public int getRock(){
        return bank.AmountOfRock;
    }
    public void setWood(int nbWood)
    {
        bank.AmountOfWood = nbWood;
    }
    public int getWood()
    {
        return bank.AmountOfWood;
    }
    public void setCorpse(int nbCorpse)
    {
        bank.AmountOfCorpse = nbCorpse;
    }
    public int getCorpse()
    {
        return bank.AmountOfCorpse;
    }
    public void setMeat(int nbMeat)
    {
        bank.AmountOfMeat = nbMeat;
    }
    public int getMeat()
    {
        return bank.AmountOfMeat;
    }

    public void UpdateView()
    {
        viewRock.text = ""+ getRock() +"";
        viewMeat.text = "" + getMeat() + "";
        viewWood.text = "" + getWood() + "";
        viewCorpse.text = "" + getCorpse() + "";
    }
	
}
