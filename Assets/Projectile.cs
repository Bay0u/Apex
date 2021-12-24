using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            print(player.transform.position.x);
            // print(gameObject.transform.position.x);
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = gameObject.transform.position;
            player.GetComponent<CharacterController>().enabled = true;
            Destroy(gameObject);
        }
    }
}
