using UnityEngine;
using System.Collections;

public class MaisonZombie : Maison{


    private int nbZombie;

    void addZombie(int montant)
    {
        if (nbZombie < MAX_CARACTERES)
        {
            //TODO: assign zombie to this house or decrement houseless zombie
            nbZombie++;
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
