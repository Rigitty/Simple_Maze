using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tension4 : MonoBehaviour
{
	public GameObject scexe;
	public GameObject tr;

	private void Update()
	{
		if (scexe.GetComponent<Raycast>().m4bool == true)
		{
			tr.SetActive(true);
		}
	}
}
