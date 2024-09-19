using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4_1 : MonoBehaviour
{
    float area;
    // Start is called before the first frame update
    void Start()
    {
        Circulo(5f);
        Debug.Log("El area del circulo es " + area);
        Triangulo(5, 8);
        Debug.Log("El area del circulo es " + area);
        Cuadrado(5);
        Debug.Log("El area del circulo es " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Circulo(float radio) 
    {
        area = (radio * radio)* 3.14f;
    } 
    void Triangulo(int altura, int basse) 
    {
        area = (altura * basse) / 2;
    
    }
    void Cuadrado(int lado) 
    {
        area = lado*lado;
    }
}
