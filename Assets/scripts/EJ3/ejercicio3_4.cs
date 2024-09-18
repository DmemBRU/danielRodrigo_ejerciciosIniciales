using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int EXP;
    // Start is called before the first frame update
    void Start()
    {
        int LVL = 32+(9*EXP/5);
        Debug.Log("Tu nivel es: " + LVL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
