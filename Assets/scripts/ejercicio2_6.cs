using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 150;
    int puntuacion2 = 8;
    int puntuacion3 = 45;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La puntuacion 1 del jugador es: " + puntuacion1 + " la puntuacion 2 es: " + puntuacion2 + " y la puntuacion 3 es: " + puntuacion3);
        Debug.Log("La media es: " + ((puntuacion1 + puntuacion2 + puntuacion3) / 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
