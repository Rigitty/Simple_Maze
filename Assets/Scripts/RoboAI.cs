using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;

public class RoboAI : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = player.transform.position;
        transform.LookAt(player.transform.position);
        transform.rotation = transform.rotation * Quaternion.Euler(-90, 0, 0);

    }
}
