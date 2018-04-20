using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dificuldade : MonoBehaviour {
    private static int dificiu;
	 public void  Easy(){

        dificiu = Random.Range(1, 10);
        Player.lugar = dificiu;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
    }

    public void Medium()
    {

        dificiu = Random.Range(11, 20);
        Player.lugar = dificiu;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Hard()
    {

        dificiu = Random.Range(21, 30);
        Player.lugar = dificiu;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void VoltaMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

   



}
