using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3_6 : MonoBehaviour
{
    [SerializeField] int kilometrosHora;
    // Start is called before the first frame update
    void Start()
    {
        float metrosSegundo = kilometrosHora / 3.6f;
        Debug.Log(metrosSegundo + " metros por segundo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
