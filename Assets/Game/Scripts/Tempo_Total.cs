using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Tempo_Total : MonoBehaviour
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
        text.text = "Tempo Total: \n" + texto + " min";

    }
}
