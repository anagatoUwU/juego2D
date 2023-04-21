using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguircamara : MonoBehaviour
{

    public GameObject Personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Personaje.transform.position.x,Personaje.transform.position.y,-10);
    }
}
