using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimentacao : MonoBehaviour {

	private float move = 5.0f;
	private int x = 0;
    public int scoreValue = 1;
    [SerializeField]
    private float _speed = 3.0f;
    public static float tempo_volta;
    public static float melhor_volta = 99999999;
    public static float tempo_total = 0;
    private float rnd;

    // Use this for initialization

    // Update is called once per frame
    void Update () {
        
        if (Botao_largada.ok == 1)
        {
            
            _Movement();
        }
        
		}
    

    private void _Movement()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speed);

        if (transform.position.y < -45)
        {
            transform.position = new Vector3(transform.position.x, 10, 0);
   
        }if (transform.position.y < -7 && transform.position.y > -7.2) {
			x = 1; 
			if(x > 0){
				
				move -= Time.deltaTime;
                Voltas.score += 1;
                Avançar.ativo = scoreValue;
                Player.voltasC += 1;
                Player.recarga += 1;
                if (Player.voltasC == 47)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                }
                if (Player.posic == 1)
                {
                    rnd = Random.Range(0, 10);
                    if (rnd <= 7)
                    {
                        Player.posic += 1;
                    }
                }
                RandomTempo();

                if (move <= 0.0f){
                    
                    x = 0;
					move = 5.0f;
				}  
		}
		      
    }
}

    void RandomTempo()
    {
        float tempo = Random.Range(70, 100);
        tempo_volta =  (tempo / 60);

        Tempo_Volta.tempo = tempo_volta;
        Tempo_Total.tempo += tempo_volta;

        if (tempo_volta < melhor_volta)
        {
            melhor_volta = tempo_volta;
            Melhor_Tempo.tempo = melhor_volta;
        }

        tempo_total += tempo_volta;

    }
}
