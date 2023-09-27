using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(PowerUpCollet(collision.gameObject));
        }
    }

    private IEnumerator PowerUpCollet(GameObject player)
    {

        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;

        player.GetComponent<move>().speed = 12.0f;
        //player.GetComponent<move>().jumpforce = 25.0f;

        yield return new WaitForSeconds(5.0f);

        player.GetComponent<move>().speed = 8.0f;

        Destroy(gameObject);
    }

}
