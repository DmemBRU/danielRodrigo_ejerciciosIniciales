using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_3 : MonoBehaviour
{
    int vidas = 0;
    float exp = 0.5f;
    float producto;
    float cociente;
    float resto;
    int dobleVidas;
    float tripleExp;
    // Start is called before the first frame update
    void Start()
    {
        producto = vidas * exp;
        cociente= vidas / exp;
        resto = vidas % exp;
        dobleVidas = vidas *2;
        tripleExp = exp *3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
