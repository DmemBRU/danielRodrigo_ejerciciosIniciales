using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5_4 : MonoBehaviour
{
    int numero;
    int dividendo;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        if (dividendo > 0) 
        { 
            resultado = numero / dividendo;
            Debug.Log(resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
