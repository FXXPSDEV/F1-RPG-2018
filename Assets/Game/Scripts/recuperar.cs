using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recuperar : MonoBehaviour {
	

	public Button Button;
	private int recu = 15; 
	private int pos = 1;
	private int voltC;

		void Start()
		{
		Button btn = Button.GetComponent<Button>();

		btn.onClick.AddListener(ClickButton);

		}

         void Update()
         {
          if (Player.integridadee > 100)
            {
            Player.integridadee = 100;
            }

        }

    void ClickButton()
		{ 
        
        Player.integridadee += recu;
           
        
        Player.voltasC += voltC;
        
        if(Player.posic < 30)
        {
            Player.posic += pos;
        }
            

    }
	}

