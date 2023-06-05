using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioManager : MonoBehaviour {

    public AudioClip bandaSonora;

    public AudioClip clicMenu;

    public AudioClip lanzaBola;

    public AudioClip sonidoMuerte;

    public AudioClip sonidoGoal;

    public AudioClip sonidoBola;

    private AudioSource hiloMusical;

    private Scene escenaActual;

    public static GameObject scriptDuplicado;

    
    void Awake () {
        DontDestroyOnLoad(this.gameObject);

        if(scriptDuplicado == null){
            scriptDuplicado = this.gameObject;
        }else if(scriptDuplicado != null){
            DestroyObject(this.gameObject);
        }

    } // Fin de Awake


    void Start(){
        hiloMusical = GetComponent<AudioSource>(); //
        hiloMusical.clip = bandaSonora;
        hiloMusical.loop = true;
        hiloMusical.Play();
        
    }// Fin de Start

   
    void Update(){
        escenaActual = SceneManager.GetActiveScene();
        if(escenaActual.name == "start"){
             hiloMusical.pitch = 1f;

        }else if (escenaActual.name == "Nivel1") {
             hiloMusical.volume = 0.4f;
             hiloMusical.pitch = 1.5f;
           
        }

     
    }// Fin de Update


    public void clicBoton (){
        hiloMusical.PlayOneShot(clicMenu, 1f);
    }//Fin clicBoton

    public void sonidoDead (){
        hiloMusical.PlayOneShot(sonidoMuerte, 1f);
    }//Fin sonidoDead

    public void sonidoPuntos (){
        hiloMusical.PlayOneShot(sonidoGoal, 1f);
    }//Fin sonidoPuntos
}
