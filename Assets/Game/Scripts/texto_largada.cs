using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class texto_largada : MonoBehaviour {

	public static int integrid;
    private float time = 3.0f;

    Text text;

	void Start () {
		text = GetComponent<Text>();
		integrid = 0;

	}

	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;

        if(time >= 0.0f)
        {
            text.text = string.Format("{0:#}", time);

        }
        if(time <= 0.0f)
        {
            
            text.text = "Vai";
            text.color = Color.green;
        }
        
    }
}
