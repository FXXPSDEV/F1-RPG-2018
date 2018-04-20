using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pitstop : MonoBehaviour
{


    public Button Button;
    public GameObject pits;
    private int recu = 100;
    private int pos = 2;
    private int qtd = 1;
    private int voltC;
    private float segundo = 10.0f;
    public static int ativo = 0;
    private int recarga = 0;

    void Start()
    {
        Button btn = Button.GetComponent<Button>();
        if (Button.interactable == true)
        {

            btn.onClick.AddListener(ClickButton);
        }
        

    }
    void Update()
    {
        recarga = (Player.recarga / 10);
        if (recarga >= 1)
        {
            Player.pitstops += 1;
            Player.recarga = 0;
        }

        if (Player.pitstops > 0)
        {
            Button.interactable = true;
        }
        else if (Player.pitstops == 0)
        {
            Button.interactable = false;
        }
    }

    void ClickButton()
    {

        Instantiate(pits);
        Player.pitstops -= qtd;
        Player.integridadee = recu;
        Player.posic += pos;
        Player.voltasC += voltC;
        ativo = 1;
    }
}
