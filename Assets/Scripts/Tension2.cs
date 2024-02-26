using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tension2 : MonoBehaviour
{
	public GameObject as1, as2, as3;
	private void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Player")
		{
			if(gameObject.transform.tag == "t21")
			{
				as1.SetActive(true);
			}
			if (gameObject.transform.tag == "t22")
			{
				as2.SetActive(true);
			}
			if (gameObject.transform.tag == "t23")
			{
				as3.SetActive(true);
			}
		}
	}
}
