using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour {


    public GameObject Personaje;

    public GameObject FondoPlanetas;

    //public GameObject FondoArboles;

    public GameObject FondoNubes;

    public static string DireccionPersonaje;

    public float VelocidadPlanetas = 0f;
    //public float VelocidadArboles = 0f;
    public float VelocidadNubes = 0f;


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

        if(DireccionPersonaje == "derecha"){
            VelocidadPlanetas -= 0.001f;
            //VelocidadArboles -= 0.001f;
            VelocidadNubes -= 0.001f;

        }
        if(DireccionPersonaje == "izquierda"){
            VelocidadPlanetas += 0.001f;
            //VelocidadArboles += 0.001f;
            VelocidadNubes += 0.001f;

        }
        if(DireccionPersonaje == "parado"){
            VelocidadPlanetas = 0.0f;
            //VelocidadArboles = 0.0f;
            VelocidadNubes = 0.0f;

        }

      FondoPlanetas.transform.Translate(VelocidadPlanetas*Time.deltaTime,0,0); 
      //FondoArboles.transform.Translate(VelocidadArboles*Time.deltaTime,0,0);
      FondoNubes.transform.Translate(VelocidadNubes*Time.deltaTime,0,0); 

    }
}
