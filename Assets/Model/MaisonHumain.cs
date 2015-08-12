using UnityEngine;
using System.Collections;

public class MaisonHumain : Maison {

    private int nbHumans;

    void addHuman(int amount)
    {
        if (nbHumans < MAX_CARACTERES)
        {
            //TODO: assign zombie to this house or decrement houseless zombie
            nbHumans++;
        }

        else
        {
            //TODO: alert to player: Too many zombies in one house! You must construct additional zombie houses.
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
