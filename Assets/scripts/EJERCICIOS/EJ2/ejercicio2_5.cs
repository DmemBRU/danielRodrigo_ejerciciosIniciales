using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_5 : MonoBehaviour
{
    int vidasP1 = 5;
    int vidasP2 = 10;
    int vidasP3 = 15;
    int vidasP4 = 20;
    int respaldoP2;
    // Start is called before the first frame update
    void Start()
    {
        respaldoP2 = vidasP2;
        vidasP2 = vidasP3;
        vidasP3 = vidasP1;
        vidasP1 = vidasP4;
        vidasP4 = respaldoP2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
