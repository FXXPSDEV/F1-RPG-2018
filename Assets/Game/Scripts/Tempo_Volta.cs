using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Tempo_Volta : MonoBehaviour
{
    private string texto;
    public static float tempo;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        tempo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        texto = string.Format("{0:#.#,##}", tempo);
        text.text = "Tempo Volta: \n" + texto + " min";
        
    }
}
