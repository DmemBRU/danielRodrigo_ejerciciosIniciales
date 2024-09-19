using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_8 : MonoBehaviour
{
    int vida = 120;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El jugador tiene " + vida + " puntos de vida");
        vida -= (vida %= 3);
        Debug.Log("El jugador tiene " + vida + " puntos de vida");
        vida -= (vida %= 6);
        Debug.Log("El jugador tiene " + vida + " puntos de vida");
        vida -= (vida %= 9);
        Debug.Log("El jugador tiene " + vida + " puntos de vida");
        vida -= (vida %= 12);
        Debug.Log("El jugador tiene " + vida + " puntos de vida");
        vida -= (vida %= 15);
        Debug.Log("El jugador tiene " + vida + " puntos de vida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
