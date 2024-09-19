using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocidadP1;
    [SerializeField] int velocidadP2;
    [SerializeField] int velocidadP3;
    // Start is called before the first frame update
    void Start()
    {
        if (velocidadP1 > velocidadP3 && velocidadP1 > velocidadP2)
        {
            Debug.Log("El primer turno lo tiene el P1");
        }
        if (velocidadP2 > velocidadP1 && velocidadP2 > velocidadP3)
        {
            Debug.Log("El primer turno lo tiene el P2");
        }
        if (velocidadP3 > velocidadP2 && velocidadP3 > velocidadP1)
        {
            Debug.Log("El primer turno lo tiene el P3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
