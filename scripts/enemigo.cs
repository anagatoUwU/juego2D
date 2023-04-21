using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
   public string clonBala;
   


    Vector3 posicionInicial; //IA


    float distanciaPlayer = 4f; //IA


    public float SpeedEnemigo= 1f; //IA

    public GameObject player; //IA
    
    public GameObject gestorSonido;// ruido




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 Objetivo = posicionInicial;
       float distancia = Vector2.Distance(player.transform.position, transform.position);
       if (distancia < distanciaPlayer){

           Objetivo = player.transform.position;
       }

       float Velocidadfija = SpeedEnemigo*Time.deltaTime;
       transform.position = Vector3.MoveTowards(transform.position, Objetivo, Velocidadfija);

       Debug.DrawLine(transform.position, Objetivo, Color.green);
    }

    
    
    
    
    
    
    
    void OnTriggerEnter2D (Collider2D col)
    {
    clonBala = col.gameObject.name;

   if (clonBala == "bala(Clone)"){

       gestorSonido.GetComponent<audioManager>().deadSE();
       Destroy (this.gameObject, 0.1f);
       

    
    }//end if
     if (clonBala == "Personaje"){
       principal.vidas -=1;
        player.transform.position = new Vector3 (-9, -2, 0);
        gestorSonido.GetComponent<audioManager>().deadSE();


    
    }
    //end if
    }

    
    

}

