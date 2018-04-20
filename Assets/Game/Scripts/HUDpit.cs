using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HUDpit : MonoBehaviour
{

    public static int score;

    Text text;

    void Start()
    {

        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        score = Player.pitstops;
        text.text = "PitStops: " + score;
    }
}
