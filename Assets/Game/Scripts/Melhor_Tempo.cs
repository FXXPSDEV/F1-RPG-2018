using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Melhor_Tempo : MonoBehaviour
{
    private string texto;
    public static float tempo;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        tempo = 0;
    }


    void Update()
    {
        texto = string.Format("{0:#.#,##}", tempo);
        text.text = "Melhor volta: \n" + texto + " min";

    }
}
