using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamecontroller : MonoBehaviour
{
    public GameObject telaMorte;
    public void GameOver()
    {
        telaMorte.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Reset()
    {
        telaMorte.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
