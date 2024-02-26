using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
	private GameObject scexe;
	public GameObject door;
	private void Start()
	{
		scexe = GameObject.FindGameObjectWithTag("scriptexe");
	}
	private void Update()
	{
		if(scexe.GetComponent<Raycast>().key == true)
		{
			door.SetActive(true);
		}
	}
}
