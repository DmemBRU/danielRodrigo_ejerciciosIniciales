using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultado = metros(25000);
        Debug.Log(resultado + " m/seg");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float metros (float kilometros)
    {
        float resultado = kilometros / 3.6f;
        return resultado;
    }
}
