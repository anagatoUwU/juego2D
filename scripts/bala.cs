using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour


{
    public float vel= 3.0f;
    bool direccion = false;// false derecha true izquierda
    

    // Start is called before the first frame update
    void Start()
    {
        if (mov.direccionBala == true){
          direccion=true;

        }else{
           direccion=false; 
        }



        Destroy (gameObject, 0.6f);//destruir bala
    }

    // Update is called once per frame
    void Update()
    {
     if (direccion == true){
        
            
         transform.Translate(new Vector2 (Time.deltaTime * 7, 0));
         

     

     }else{
        transform.Translate(new Vector2 (Time.deltaTime * -7, 0));
        

     }//end if
     }

        
         

    
}
