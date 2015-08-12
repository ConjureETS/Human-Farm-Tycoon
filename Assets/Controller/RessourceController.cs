using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RessourceController{
    Stats stats;
    Text viewWood;
    Text viewRock;
    Text viewCorpse;
    Text viewMeat;

    public RessourceController(Stats stats, Text viewW, Text viewR, Text viewC, Text viewM)
    {
        this.stats = stats;
        this.viewCorpse = viewC;
        this.viewWood = viewW;
        this.viewRock = viewR;
        this.viewMeat = viewM;
    }

    public void setRock(int nbRock){
        stats.AmountOfRock = nbRock;
    }
    public int getRock(){
        return stats.AmountOfRock;
    }
    public void setWood(int nbWood)
    {
        stats.AmountOfWood = nbWood;
    }
    public int getWood()
    {
        return stats.AmountOfWood;
    }
    public void setCorpse(int nbCorpse)
    {
        stats.AmountOfCorpse = nbCorpse;
    }
    public int getCorpse()
    {
        return stats.AmountOfCorpse;
    }
    public void setMeat(int nbMeat)
    {
        stats.AmountOfMeat = nbMeat;
    }
    public int getMeat()
    {
        return stats.AmountOfMeat;
    }

    public void UpdateView()
    {
        viewRock.text = ""+ getRock() +"";
        viewMeat.text = "" + getMeat() + "";
        viewWood.text = "" + getWood() + "";
        viewCorpse.text = "" + getCorpse() + "";
    }
	
}
