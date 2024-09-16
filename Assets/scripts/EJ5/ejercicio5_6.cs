using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5_6 : MonoBehaviour
{
    int nivel = 50;
    // Start is called before the first frame update
    void Start()
    {
        if (nivel % 10 == 0) 
        {
            Debug.Log("Tu pokemon puede aprender un ataque nuevo!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
