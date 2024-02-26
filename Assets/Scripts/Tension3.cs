using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tension3 : MonoBehaviour
{
	public GameObject scexe;
	public GameObject tr;

	private void Update()
	{
		if (scexe.GetComponent<Raycast>().m3bool == true)
		{
			tr.SetActive(true);
		}
	}
}
