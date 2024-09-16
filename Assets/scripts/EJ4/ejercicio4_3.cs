using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string resultado =Convertir(45, "dolares");
        Debug.Log(resultado);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string Convertir(float cantidad, string moneda) 
    {
       string resultado = (cantidad * 0.9f ) + moneda;
        return resultado;
    }
}
