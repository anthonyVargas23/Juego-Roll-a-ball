using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // referencia a nuestro juegador
   public GameObject jugador;

   // para registrar la diferencia entre la posuxion de la camara y la del jugador 

   private Vector3 offset;

   // use this for inicialization 
    void Start()
    {
        // diferencia entre la posicion de la camara y la del jugador. 
        offset = transform.position - jugador.transform.position;

    }


    // se ejecuta cada frame, pero despues de haber procesado todo. es mas exacto para la camara. 

    void Update()
    {
        // actualizando la position de la camara.

        transform.position = jugador.transform.position + offset;
        
    }
}
