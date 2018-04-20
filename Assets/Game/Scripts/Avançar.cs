using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;



public class Avançar : MonoBehaviour
{
    public float segundos = 100.0f;
    protected bool paused;
    public GameObject Acidente1;
    public GameObject Acidente2;
    public GameObject Acidente3;
    public GameObject Ultrapassado;
    public GameObject Ultrapassagem;
    public static int ativo;
    public Button Button;
    public static int pos = 1;
	public static int integr = 10;
    public static int voltC = 1;
    public static int pitStop = 2;
    private int detona = 0;
    


    void Update()
    {
        if (detona == 1)
        {
            segundos -= Time.fixedDeltaTime;

            if (segundos <= 0.0f)
            {
 
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

            }
        }
        

        Button btn = Button.GetComponent<Button> ();
		if (ativo > 0) {
			Button.interactable = true;

		} else if (ativo == 0) {
			Button.interactable = false;
		}       
    }
	void Start(){
 
        if (Button.interactable == true) {
			Button btn = Button.GetComponent<Button> ();
			btn.onClick.AddListener (ClickButton);
		}

        //Ultrapassagem = GetComponent<GameObject>();
    }

    void ClickButton()
    {
		ativo = 0;
        int b = Random.Range(0, 10);
        if (b <= 7)
        {
            if(Player.posic != 1)
            {
                Player.posic -= pos;
            }
            
        }
        Player.integridadee -= integr;
        Player.voltasC += voltC;

        if (Player.integridadee <= 40)
        {
            Acidente();
        }if (Player.integridadee == 0)
        {
            detona = 1;
            int acide = Random.Range(0, 3);
            if (acide == 0)
            {
                Instantiate(Acidente1);                
            }
            else if (acide == 1)
            {
                Instantiate(Acidente2);
            }
            else if (acide == 2)
            {
                Instantiate(Acidente3);
            }
        }
    }

	void Acidente(){
		int a = Random.Range (0, 10);
		if(a == 1){
            detona = 1;
            int acid = Random.Range(0, 3);
            if(acid == 0) {
                Instantiate(Acidente1);            
            } else if (acid == 1){
                Instantiate(Acidente2);                   
            } else if (acid == 2){
                Instantiate(Acidente3);                   
            }
        }
	}
}

