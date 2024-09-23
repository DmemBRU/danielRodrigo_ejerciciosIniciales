using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
 //con esto se crea un personaje clase o tipo (en este caso personaje) + nombre
 //Se le pone un serialize field para poder darle el valor al personaje(cual por defecto es nulo) y asignarle el objeto de personaje(que tiene el script de personaje [duh]) desde unity y asi darle un valor
 //la sintaxis para asignar los valores de la clase en este caso seria link.nombre (por ejemplo)
    [SerializeField] Personaje Link;
    void Start()
    {
        //aqui el valor vida tiene otro nombre diferente al scrpit de personaje es por conveniencia y poder distinguir que variables editan el valor original de vidas
        Link.Vida = 100;
        Link.Mover(30, 50, 66);
    }

   
}
