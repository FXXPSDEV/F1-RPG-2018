using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static int pitstops;
    public static int recarga;
    public static int posic;
    public static int lugar;
    public static int voltasC;
	public static int integridadee;
    public static float melhor_volta=99999999;
    public static float tempo_total=0;

	// Use this for initialization
	void Start () {
        //transform.position = new Vector3(0.4f, -3.0f, 0);
        pitstops = 2;
        posic = lugar;
		integridadee = 100;
        
	}
	
	// Update is called once per frame
	void Update () {

		posicao.posi = posic;
		integridade.integrid = integridadee;
        
        }  

   
	}



