using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Voltas : MonoBehaviour {

    public static int score;

    Text text;

	void Start () {

        text = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {

        text.text = "Voltas: " + score +"/47";
	}
}
