using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class largada : MonoBehaviour
{
    private float time = 4.0f;
  

    Image imagem;

    void Start()
    {
        imagem = GetComponent<Image>();
 
    }

    void Update()
    {

        time -= Time.deltaTime;

        if (time >= 3.0f)
        {
            imagem.color = Color.red;
        }
        else if (time >= 2.0f)
        {
            imagem.color = Color.yellow;

        }
        else if (time >= 1.0f)
        {
            imagem.color = Color.green;

        }
    }
}
