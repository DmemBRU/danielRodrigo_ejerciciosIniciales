using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5_1 : MonoBehaviour
{
    int vidaPersonaje1 = 10;
    int vidaPersonaje2 = 20;
    // Start is called before the first frame update
    void Start()
    {
        if (vidaPersonaje1 == vidaPersonaje2)
        {
            Debug.Log("La batalla esta reñida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
