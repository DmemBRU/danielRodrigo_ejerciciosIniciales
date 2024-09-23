using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajito : MonoBehaviour
{
    string nombre;
    int vida;
    float experiencia;

    // Start is called before the first frame update
    void Start()
    {
        float calcularNivel = experiencia / 1000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
