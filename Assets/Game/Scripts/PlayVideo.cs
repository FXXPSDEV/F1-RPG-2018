using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class PlayVideo : MonoBehaviour
{

    public MovieTexture video;
    public AudioSource audio;
    private float segundo = 13.0f;

    void Start()
    {

        GetComponent<RawImage>().texture = video as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = video.audioClip;
        video.Play();
        audio.Play();
    }

    void Update()
    {
        
            segundo -= Time.deltaTime;
            if (segundo <= 0.0f)
            {
                Destroy(this.gameObject);
                
                
                segundo = 10.0f;
            }
            
        
        if (Input.GetKey(KeyCode.Space) && video.isPlaying)
        {
            video.Pause();
        }
        if (Input.GetKey(KeyCode.Space) && !video.isPlaying)
        {
            video.Play();
        }
    }
}
