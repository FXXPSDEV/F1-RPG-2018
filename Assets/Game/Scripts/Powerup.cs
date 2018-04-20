using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public int scoreValue = 1;
    [SerializeField]
    private float _speed = 3.0f;

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("colide with: " + other.name);
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.down * Time.deltaTime * _speed);
        _Movement();

    }

    private void _Movement()
    {
      
        if (transform.position.y < -45)
        {
            transform.position = new Vector3(transform.position.x, 10, 0);
   
        }if (transform.position.y < -7 && transform.position.y > -7.1)
        {
            Voltas.score += scoreValue;
            
        }
        
    }
}
