using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void ToInn(){
        SceneManager.LoadScene(2);
    }

    public void ToShop(){
        SceneManager.LoadScene(3);
    }

    public void ToWorldMap(){
        SceneManager.LoadScene(3);
    }

    public void BackToTown(){
        SceneManager.LoadScene(1);
    }
}
