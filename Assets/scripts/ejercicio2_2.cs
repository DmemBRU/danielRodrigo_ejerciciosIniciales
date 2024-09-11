using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float exp = 0.0f;
    char carac = 'a';
    float resultadoSuma;
    float resultadoResta;
    // Start is called before the first frame update
    void Start()
    {
        resultadoSuma = vidas + exp;
        resultadoResta = vidas - exp;
        Debug.Log("el resultado de la suma es: " +  resultadoSuma);
        Debug.Log("el resultado de la resta es: " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
