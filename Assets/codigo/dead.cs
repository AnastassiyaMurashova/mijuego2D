using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour {

    public GameObject Personaje;

    public GameObject gestorSonido;

    private static int contadorTrigger;

    void Awake(){
        gestorSonido = GameObject.Find ("AudioManager");
    }

    void Start() {
        contadorTrigger = 0;
    }
    


    // Update is called once per frame
    void Update() {
        // Debug.Log(contadorTrigger);
        
    }

    void OnTriggerEnter2D () {
        if(contadorTrigger <= 0){
            //añadir efecto
            Debug.Log("EfectoEco!!");
            contadorTrigger++;
        }else if(contadorTrigger >= 1){
        UnityEngine.Debug.Log("HAS muerto!!!!!");
        //gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<audioManager>().sonidoMuerte, 1f);
        gestorSonido.GetComponent<audioManager>().sonidoDead();
        principalScript.Vida--;
        Personaje.transform.position = new Vector2 (-0.44f,-0.45f);
        contadorTrigger++;        
        }
        
    
    }//Fin TriggerEnter2D

    void OnTriggerExit2D(){
        contadorTrigger--;
    }



}

