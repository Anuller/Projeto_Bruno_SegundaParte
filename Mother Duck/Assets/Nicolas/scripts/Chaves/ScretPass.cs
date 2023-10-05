using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScretPass : MonoBehaviour
{
    //public gamecontroller controller;

    public GameObject Porta;

    public GameObject chave1;
    public GameObject chave2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chaves")
        {
            Debug.Log("Eu colidi");
            Destroy(chave1);
        }
        if (collision.gameObject.tag == "Chaves1")
        {

            Destroy(chave2);
        }
    }

    public void Update()
    {
        if (chave1 == null && chave2 == null)
        {
            Destroy(Porta);
        }
    }


}
