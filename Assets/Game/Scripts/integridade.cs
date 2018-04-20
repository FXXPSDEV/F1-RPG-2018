using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class integridade : MonoBehaviour {

	public static int integrid;

	Text text;

	void Start () {
		text = GetComponent<Text>();
		integrid = 0;

	}

	// Update is called once per frame
	void Update () {
		text.text = "Integridade: " + integrid;

        if (integrid >= 75)
        {
            text.color = Color.green;
        }else if(integrid>=50){
            text.color = Color.yellow;

        }
        else
        {
            text.color = Color.red;
        }
    }
}
