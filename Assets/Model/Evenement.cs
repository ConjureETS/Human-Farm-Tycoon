using UnityEngine;
using System.Collections;

public class Evenement
{

    public int MultiWood { get; set; }
    public int MutliRock { get; set; }
    public int MultiCorps { get; set; }
    public string descriptionEvent { get; set; }

    /*
     * Pour les multiplicateur, 10 est la valeur de base, car il est divisé par 10 plus tard.
     * 
     */
    public void GetEventForThisRound(int nbRound)
    {

        System.Random rnd = new System.Random();
        int number = nbRound + rnd.Next(0, 5);


        switch (number)
        {
            case 1:
                descriptionEvent = "Sunny day";
                MultiWood = 12;
                MutliRock = 10;
                MultiCorps = 11;
                break;
            case 2:
                descriptionEvent = "Raining day";
                MultiWood = 8;
                MutliRock = 10;
                MultiCorps = 10;
                break;
            case 3:
                descriptionEvent = "Party time";
                MultiWood = 10;
                MutliRock = 10;
                MultiCorps = 10;
                break;
            case 4:
                descriptionEvent = "Tornado";
                MultiWood = 8;
                MutliRock = 8;
                MultiCorps = 8;
                break;
            case 5:
                descriptionEvent = "Eartquake";
                MultiWood = 10;
                MutliRock = 2;
                MultiCorps = 10;
                break;
            case 6:
                descriptionEvent = "Wood Fire";
                MultiWood = 2;
                MutliRock = 10;
                MultiCorps = 10;
                break;
            case 7:
                descriptionEvent = "Zombie Mutiny";
                MultiWood = 0;
                MutliRock = 0;
                MultiCorps = 0;
                break;
            default:
                descriptionEvent = "Normal day";
                MultiWood = 10;
                MutliRock = 10;
                MultiCorps = 10;
                break;
        }

    }
}
