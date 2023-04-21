using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float vel = 5;
    public float salto = 40f;
    public bool ActivaSalto = true;

    bool saltando = false;
    int vidas = 3;
    public static bool direccionBala = false;
    public static bool ParardireccionBala = false;

   Rigidbody2D miCuerpoRigido;

   Animator controlAnimacion;
   
    void Start()
    {
        miCuerpoRigido = GetComponent<Rigidbody2D>();
        controlAnimacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          if(principal.vidas <=0){
            return;
        }
        float movTeclas=Input.GetAxis ("Horizontal");
        movTeclas *= Time.deltaTime;
        movTeclas *= vel;
        transform.Translate(movTeclas,0,0);
        
        if (Input.GetKeyUp(KeyCode.None)){
            controlAnimacion.SetFloat("ActivaCamina", 1);
            Debug.Log("Tecla levantada");
            
        }

        if (movTeclas<0){
            transform.localScale = new Vector3(-1,1,1);
            controlAnimacion.SetFloat("ActivaCamina", 0);
            direccionBala = false;
            parallax.direccionPersonaje = "izquierda";
            

        }
        if (movTeclas==0 ){
        
            controlAnimacion.SetFloat("ActivaCamina", 1);
            parallax.direccionPersonaje = "parado";
            
        }
    
        if (movTeclas>0){
            transform.localScale = new Vector3(1,1,1);
            controlAnimacion.SetFloat("ActivaCamina", 0);
            direccionBala = true;
            parallax.direccionPersonaje = "derecha";
             
        }
    
    
        if (Input.GetKeyDown(KeyCode.Space) && ActivaSalto == true){
        Debug.Log("Tecla espacio pulsada");
        miCuerpoRigido.AddForce(new Vector2(0,salto), ForceMode2D.Impulse);
        ActivaSalto = false;
        }

    

       
    
    }//fin update
      void OnCollisionEnter2D(){
            ActivaSalto = true;

    
        }

}
