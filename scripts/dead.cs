using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    public GameObject personaje;
    public GameObject gestorSonido;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D otro){
    Debug.Log("Ha triggerizado");
    principal.vidas = principal.vidas -1;
    personaje.transform.position = new Vector3 (-9, -2, 0);
    gestorSonido.GetComponent<audioManager>().deadSE();
    }

}


