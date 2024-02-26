using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walksound : MonoBehaviour
{
    private GameObject player;
    public AudioSource walkas, sprintas;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        transform.position = player.transform.position;
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))&& player.GetComponent<PlayerController>().isground == true)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                walkas.enabled = false;
                sprintas.enabled = true;
            }
            else
            {
                walkas.enabled = true;
                sprintas.enabled = false;
            }
        }
        else
        {
            walkas.enabled = false;
            sprintas.enabled = false;
        }
    }
}
