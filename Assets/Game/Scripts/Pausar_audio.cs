using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar_audio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        //BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().UnPause();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
