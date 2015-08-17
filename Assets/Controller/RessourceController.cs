using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RessourceController{
    Stats stats;
    Text viewWood;
    Text viewRock;
    Text viewCorpse;
    Text viewMeat;
	Text viewHuman;
	Text viewZombie;

    public RessourceController(Stats stats, Text viewW, Text viewR, Text viewC, Text viewM,Text viewH,Text viewZ)
    {
        this.stats = stats;
        this.viewCorpse = viewC;
        this.viewWood = viewW;
        this.viewRock = viewR;
        this.viewMeat = viewM;
		this.viewHuman = viewH;
		this.viewZombie = viewZ;
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
	public int getHumans()
	{
		return stats.AmountOfHumans;
		
	}
	public int getZombies()
	{
		return stats.AmountOfZombies;
		
	}

    public void UpdateView()
    {
        viewRock.text = ""+ getRock() +"";
        viewMeat.text = "" + getMeat() + "";
        viewWood.text = "" + getWood() + "";
        viewCorpse.text = "" + getCorpse() + "";
		viewHuman.text = "" + getHumans() + "";
		viewZombie.text = "" + getZombies() + "";
    }
	
}
