using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{
    //GameObject gestorSonido;
    public GameObject bala;
    //public GameObject gestorSonido;
    //Start is called before the first frame update
    void Start()
    {
        //SonidoDead = gestorSonido.GetComponent<audioManager>(deadSE);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) == true){
        
            Debug.Log("Pium");
            //this.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<audioManager>().disparoSE,1f);
            Instantiate (bala, new Vector2(transform.position.x,transform.position.y), transform.rotation);
        }//fin if
        
    }
}
