using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//lo que salga de esta plantilla (clase) son instancias u objetos
public class Personaje : MonoBehaviour
{
    //AKA como se define a un personaje
    //propiedades o atributos
    //se pueden poner en public para que se pueda editar los valores fuera de la plantilla pero no es recomendable hacer todos los valres publicos
    //PARA PODER USAR LOS VALORES FUERA DEL SCRIPT ALT + ENTER ---> ENCAPSULAR CAMPO _____ (PERO SEGUIR USANDOLO)
  private string nombre;
  private float vida;
  private float altura;
  private float velocidad;

    //ahora aqui nos da la referencia de donde se esta usando el valor vida en este caso
    //esto indica que hay derechos de lectura (get) y de escritura (set) respectivamente
    public float Vida { get => vida; set => vida = value; }

    //AKA que es lo que hace un personaje
    //funcionalidades
    //tambian se puede hacer public para darle los valores
    public void Mover( float x, float y, float z)
    {

    }
    void Atacar()
    {


    }
    void saltar() 
    {

    }
}
