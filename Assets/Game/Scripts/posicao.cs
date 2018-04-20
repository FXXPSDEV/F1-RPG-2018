using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class posicao : MonoBehaviour {

    public static int posi;

    Text text;

	void Start () {
        text = GetComponent<Text>();
        posi = 0;
       
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("oii");
    }

    // Update is called once per frame
    void Update () {
        text.text = "Posição: " + posi;
        
    }
}
