using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour {

	 public void  PlayGame(){


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
    }

    public void Tutorial()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
    }


    public void VoltaMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Sair(){
        Debug.Log("Quit");
        Application.Quit();
        
    }

    public void Tuto_Main()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void link()
    {
        Application.OpenURL("https://github.com/FXXPSDEV");
    }
    public void Podium()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }


}
