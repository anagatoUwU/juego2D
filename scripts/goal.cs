using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public GameObject personaje;
    public static bool soundGoal = false;
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
    principal.score +=1;
    soundGoal = true;
    Destroy(this.gameObject);
    gestorSonido.GetComponent<audioManager>().scoreSE();

    
    
    }
}
