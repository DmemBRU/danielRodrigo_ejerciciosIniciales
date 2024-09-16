using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5_5 : MonoBehaviour
{
    int nivel = 30;
    // Start is called before the first frame update
    void Start()
    {
        if (nivel % 2 == 0) 
        {
            Debug.Log("El nivel del personaje es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
