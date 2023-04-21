using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class principal : MonoBehaviour
{
    public static int vidas = 3;
    public static int score = 0;
    GameObject player;

    public GUISkin miSkin;

    public Texture2D logoJuego;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log(vidas);
       if (Input.GetKeyDown(KeyCode.Escape)){
        SceneManager.LoadScene("inicio");

       }

     
    }

    void OnGUI()
    {
        GUI.skin= miSkin;
        GUI.Label(new Rect(20,20,150,100),"Vidas:"+vidas,"estiloVidas");
        GUI.Label(new Rect(20,20,150,100),"Score:"+score,"estiloScore");
        GUI.DrawTexture(new Rect(Screen.width-100,120,60,60), logoJuego);
        
    }
}
