using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3_7 : MonoBehaviour
{
    [SerializeField] int bases;
    [SerializeField] int altura;
    // Start is called before the first frame update
    void Start()
    {
        int area = (bases * altura)/2;
        Debug.Log("Tu area es: " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
