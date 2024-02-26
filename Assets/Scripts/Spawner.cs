using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject scexe;
	public GameObject wall;
	public GameObject robot;
	private bool iswalladded;
	private bool isturned;
	private bool isrobotspawned;
	private bool runonce;
	private GameObject player;
	public GameObject chase;
	public GameObject ambient;
	public GameObject sound;
	public GameObject run;

	private void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	private void OnTriggerStay(Collider other)
	{
		if(scexe.GetComponent<Raycast>().key == true && runonce ==false)
		{
			wall.SetActive(true);
			iswalladded = true;
			runonce = true;
		}
		if (iswalladded)
		{
			if (player.transform.localEulerAngles.y < 330 && player.transform.localEulerAngles.y > 230)
			{
				isturned = true;
			}
			if (isturned)
			{
				if (player.transform.localEulerAngles.y > 10 && player.transform.localEulerAngles.y < 155)
				{
					robot.SetActive(true);
					isrobotspawned = true;
					run.GetComponent<Animator>().SetTrigger("showtext");
				}
				if (isrobotspawned)
				{
					if (player.transform.localEulerAngles.y > 35 && player.transform.localEulerAngles.y < 140)
					{
						wall.SetActive(false);
						chase.SetActive(true);
						ambient.SetActive(false);
					}
				}
			}
		}
	}
}
