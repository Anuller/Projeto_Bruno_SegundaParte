using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject pato, pato2, pato3, pato4, pato5;

    public GameObject final;

    public void Update()
    {
        if (pato == null && pato2 == null && pato3 == null && pato4 == null && pato5 == null)
        {
            final.SetActive(true);
            //Time.timeScale = 0f;
        }
        else if (pato != null && pato2 != null && pato3 != null && pato4 != null && pato5 != null)
        {
            final.SetActive(false);
            //Time.timeScale = 1f;
        }
    }
}
