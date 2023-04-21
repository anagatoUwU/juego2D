using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioManager : MonoBehaviour
{
    public AudioClip bandaSonora;
    public AudioClip clicMenu;
    public AudioClip lanzaBolas;
    public AudioClip SonidoDead;
    public AudioClip tilin;


    private AudioSource hiloMusical;

    public static GameObject scriptDuplicado;

    void Awake (){
    //DontDestroyOnLoad(this.gameObject);
    //if (scriptDuplicado == null){
    // scriptDuplicado =this.gameObject;

    //}else if(scriptDuplicado != null){
        //DestroyObject(this.gameObject);
    //}//end if

    }


    // Start is called before the first frame update
    void Start()
    {
        hiloMusical = GetComponent<AudioSource>();
        hiloMusical.clip = bandaSonora;
        hiloMusical.loop = true;
        //play esta mal
        hiloMusical.Play();

    }

    // Update is called once per frame
    void Update()
    {
        Scene escenaActual = SceneManager.GetActiveScene();

        if(escenaActual.name=="inicio"){
            hiloMusical.pitch =1f;
            


        }
        if(escenaActual.name=="Nivel1"){
            hiloMusical.pitch =1.3f;
             if (Input.GetKeyDown(KeyCode.E) == true){
                hiloMusical.PlayOneShot(lanzaBolas, 1f);
             }
           
        }
    }//fin update
    public void clicSE (){

        hiloMusical.PlayOneShot(clicMenu, 1f);
    }

    public void deadSE (){
        hiloMusical.PlayOneShot(SonidoDead, 1f);

    }

    public void disparoSE (){
        hiloMusical.PlayOneShot(lanzaBolas, 1f);

    }
    
     public void scoreSE (){
        hiloMusical.PlayOneShot(tilin, 1f);

    }
    
}

