using UnityEngine;
using System.Collections;

public class Maison
{
    private Vector2 position;
    protected readonly int MAX_CARACTERES = 10;


    public Maison()
    {
        position = new Vector2(0, 0);
    }


    Maison(Vector2 position)
    {
        this.position = position;
    }

    Vector2 getPosition()
    {
        return position;
    }

    void Start()
    {

    }

    void update()
    {

    }

}

