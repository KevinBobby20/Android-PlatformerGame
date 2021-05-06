using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update

    public void HowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }
    public void StartGame(){
        Destroy(GameObject.Find("BackgroundMusic"));
        SceneManager.LoadScene("Level 1");
    }

    public void ExitGame(){
        Application.Quit();
        Debug.Log("exit game");
    }

    public void Credit(){
        SceneManager.LoadScene("Credit");
    }

    public void Back(){
        SceneManager.LoadScene("Main Menu");
    }

    public void Retry(){
        SceneManager.LoadScene("Level 1");
    }

    public void Options(){
        SceneManager.LoadScene("Options");
    }
}
