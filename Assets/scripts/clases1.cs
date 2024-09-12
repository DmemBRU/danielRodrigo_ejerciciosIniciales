
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clases1 : MonoBehaviour
{
    //mostrar en el inspector esta variable
    [SerializeField] int vida = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vida);
        CrearNuevosMetodos(1, 2);//llamas al metodo y asignas los valores de sus respectivas variables

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //el void se comvierte en int cuando se quiere extraer un valor
    int CrearNuevosMetodos(int ejemplo1, int ejemplo2) //se ejecuta cuando este mismo metodo es llamado y sus variables locales son declaradas
    {
        Debug.Log("Me llamaste puto");
        //variable local
        int valorQueExtraer = 0;
        return valorQueExtraer;
       
    }
}
