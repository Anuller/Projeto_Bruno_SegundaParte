using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public gameControllerUI ui;

    public GameObject final;

    private void Start()
    {
        final.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Update()
    {
        if (ui.patosColetados>=5)
        {
            final.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
