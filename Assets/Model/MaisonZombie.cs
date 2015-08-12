using UnityEngine;
using System.Collections;

public class MaisonZombie : Maison{

    private int nbZombies;

    void addZombie(int montant)
    {
        if (nbZombies < MAX_CARACTERES)
        {
            //TODO: assign zombie to this house OR decrement houseless zombie
            nbZombies++;
        }

        else
        {
            //TODO: alert to player: Too many zombies in one house! You must construct additional zombie houses.
        }
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
