using UnityEngine;
using System.Collections;

public class Tasks {

    private readonly int NB_WOOD_BY_ZOMBIE = 5;
    private readonly int NB_ROCK_BY_ZOMBIE = 5;
    private readonly int NB_MEAT_BY_ZOMBIE = 5;
    private readonly int NB_CORPS_BY_ZOMBIE = 5;

    private int woodGather;
    private int rockGather;
    private int meatGather;
    private int corpsGather;

    public Tasks(int nbZombieGoingToWood, int nbZombieGoingToRock, int nbZombieGoingToMeat, int nbZombieGoingToCorps)
    {
        woodGather = NB_WOOD_BY_ZOMBIE* nbZombieGoingToWood;
        rockGather = NB_ROCK_BY_ZOMBIE * nbZombieGoingToRock;
        meatGather = NB_MEAT_BY_ZOMBIE * nbZombieGoingToMeat;
        corpsGather = NB_CORPS_BY_ZOMBIE * nbZombieGoingToCorps;
    }

}
