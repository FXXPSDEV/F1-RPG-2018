using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Intro : MonoBehaviour {
    private float segundos = 10.0f;
    void Update()
    {
       
       segundos -= Time.deltaTime;


        if (segundos <= 0.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        

           
        }

    }
