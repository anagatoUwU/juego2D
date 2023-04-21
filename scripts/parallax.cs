using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public GameObject Personaje;
    public GameObject Nubes;
    public GameObject arbolGrande;

    public static string direccionPersonaje;
    public float velocidadNubes = 0f;

    //public GameObject fondoArboles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /*if(direccionPersonaje=="derecha"){
        velocidadNubes = 0.1f;
      }  
      if(direccionPersonaje=="izquierda"){
        velocidadNubes = -0.1f;
      }  
      
      if(direccionPersonaje=="parado"){
        velocidadNubes = 0f;
      }  
    Nubes.transform.Translate(velocidadNubes,0,0);
    }
    */
    Nubes.transform.position = new Vector3(Personaje.transform.position.x/10f,
    Personaje.transform.position.y/10f,
     0 );

    //Nubes.transform.Translate(Personaje.transform.position.x,Personaje.transform.position.y,0);

    }
}
