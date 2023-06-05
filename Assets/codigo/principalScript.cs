using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class principalScript : MonoBehaviour {


public static int Score =0;

public static int Vida = 3;

public static int Enemigos = 0;

public GUISkin miSkin;

public Texture2D logoJuego;

int Anchopantalla;

void Awake(){
  DontDestroyOnLoad(gameObject);
}

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
      Anchopantalla = Screen.width/2;

      if(Input.GetKeyDown(KeyCode.Escape)){

        Application.Quit();
      }



      /*
      Debug.Log("Vida "+Vida);  
      Debug.Log("Score "+Score); 
      Debug.Log("Enemigos "+Enemigos);
      */
    }

    void OnGUI (){
      GUI.skin = miSkin;
      GUI.Label(new Rect(20, 30, 150, 80),"Vida: "+Vida.ToString(),"estiloScore");
      GUI.Label(new Rect(140, 30, 150, 80),"Score: "+Score.ToString(),"estiloScore");
      GUI.Label(new Rect(260, 30, 150, 80),"Enemigos: "+Enemigos.ToString(),"estiloScore");
      GUI.Label(new Rect(Anchopantalla-100, 20, 200, 100), "Nombre Juego", "estiloTitulo");
      //imagen
      GUI.DrawTexture(new Rect(Screen.width-120, 30, 80, 80),logoJuego);
    }


}// fin clase
