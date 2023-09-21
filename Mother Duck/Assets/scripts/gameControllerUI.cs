using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameControllerUI : MonoBehaviour
{
    public static gameControllerUI UI;
    public Text patoText;

    [Header("Quantidade de Patos coletados")]
    public int patosColetados;

    void Awake()
    {
       if (UI == null)
        {
            UI = this;
        }
        else if (UI != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
