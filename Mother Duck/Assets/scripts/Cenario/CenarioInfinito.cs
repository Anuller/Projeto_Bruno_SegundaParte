using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioInfinito : MonoBehaviour
{

    public float velocitypainel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarCenario();
    }

    void MovimentarCenario()
    {
        Vector2 deslocar = new Vector2 (Time.time * velocitypainel, 0);
        GetComponent<Renderer>().material.mainTextureOffset = deslocar;
    }
}
