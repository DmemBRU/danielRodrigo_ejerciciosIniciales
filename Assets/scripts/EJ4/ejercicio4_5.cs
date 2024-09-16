using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4_5 : MonoBehaviour
{
    float area;
    // Start is called before the first frame update
    void Start()
    {
        Circulo(25);
        Triangulo(36, 71);
        Cuadrado(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Circulo(float radio)
    {
        area = (radio * radio) * 3.14f;
        Debug.Log((area * 0.9f)+ " dolares");
    }
    void Triangulo(int altura, int basse)
    {
        area = (altura * basse) / 2;
        Debug.Log((area * 0.9f) + " dolares");
    }
    void Cuadrado(int lado)
    {
        area = lado * lado;
        Debug.Log((area * 0.9f) + " dolares");
    }
}
