using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string nombreCompleto = ConstruirNombre("Daniel", "Rodrigo", "Mora");
        Debug.Log(nombreCompleto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string ConstruirNombre(string nombre, string apellido1, string apellido2) 
    {
        string nombreCompleto = nombre + apellido1 + apellido2;
        return nombreCompleto;
    }
}
