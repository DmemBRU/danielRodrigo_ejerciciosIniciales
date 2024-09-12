using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4_1 : MonoBehaviour
{
    float area;
    // Start is called before the first frame update
    void Start()
    {
        circulo(5);
        Debug.Log("El area del circulo es " + area);
        triangulo(5, 8);
        Debug.Log("El area del circulo es " + area);
        cuadrado(5);
        Debug.Log("El area del circulo es " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void circulo(int radio) 
    {
        area = (radio ^ 2)* 3.14f;
    } 
    void triangulo(int altura, int basse) 
    {
        area = (altura * basse) / 2;
    
    }
    void cuadrado(int lado) 
    {
        area = lado*lado;
    }
}
