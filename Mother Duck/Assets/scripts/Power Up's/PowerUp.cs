using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PowerUpCollet(collision.gameObject);
        }
    }

    private void PowerUpCollet(GameObject player)
    {

        player.GetComponent<move>().speed = 30.0f;

        Destroy(gameObject);
    }

}
