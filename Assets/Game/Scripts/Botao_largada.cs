﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Botao_largada : MonoBehaviour
{

    public static int integrid;
    public GameObject botao1;
    public GameObject botao2;
    public Text texto;
    public GameObject botao3;
    public GameObject panel;
    public static int  ok = 0;
    private float time = 3.0f;

    Text text;

    void Start()
    {
        //text = GetComponent<Text>();
        
        Instantiate(botao1);
        Instantiate(botao2);
        Instantiate(botao3);

    }
    

    // Update is called once per frame
    void Update()
    {

        Pause();
        time -= Time.deltaTime;
        Debug.Log(time);

        if(time == 3.0f)
        {
            text.text ="" + time;
            //botao1(Color.red);
            //botao2(Color.red);
            //botao3(Color.red);
        }
        else if(time == 2.0f)
        {
            text.text = "" + time;
            //botao1(Color.yellow);
            //botao2(Color.yellow);
            //botao3(Color.yellow);
        }
        else if(time == 1.0f)
        {
            text.text = "" + time;
            //botao1 = Color.green;
            //botao2(Color.green);
            //botao3(Color.green);
        }
        else if(time <= -1.0f)
        {
            Destroy(botao1);
            Destroy(botao2);
            Destroy(botao3);
            Destroy(texto);
            Destroy(panel);

            ok = 1;
        }

    }

    void Pause()
    {
        /*if (ok == true)
        {
            //hello world!
        }
        else
        {
            //faz a execução do script!!
        }*/
    }
    
}
