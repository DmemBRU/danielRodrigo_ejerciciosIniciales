using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero;
   
    // Start is called before the first frame update
    void Start()
    {
        int doble = numero * 2;
        int triple = numero * 3;
        Debug.Log("El doble de tu numero es: " +doble + " y el triple es: " + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
