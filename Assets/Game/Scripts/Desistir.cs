using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Desistir : MonoBehaviour {
    private float segundos = 10.0f;
    public Button Button;
    // Use this for initialization
    void Start () {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(ClickButton);
    }
	
	// Update is called once per frame
	void Update () {
        segundos -= Time.deltaTime;
        
	}
    void ClickButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
