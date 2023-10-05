using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocacena : MonoBehaviour
{
    // Start is called before the first frame update
    public void Teleport(string tp)
    {
        SceneManager.LoadScene(tp);

    }

    public void ExitGame()
    {
        Debug.Log ("Você saiu do jogo");
        Application.Quit();
    }

    public void goMenu(string tp)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(tp);
    }

}
