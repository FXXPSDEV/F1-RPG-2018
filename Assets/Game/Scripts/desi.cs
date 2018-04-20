using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class desi : MonoBehaviour
{
    private float segundos = 7.0f;
    void Update()
    {

        segundos -= Time.deltaTime;


        if (segundos <= 0.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }



    }

}
