using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tension3TR : MonoBehaviour
{
	public GameObject tension3;
	public GameObject robot;
	private void OnTriggerExit(Collider other)
	{
		if(other.transform.tag == "Player")
		{
			robot.SetActive(true);
			StartCoroutine(DObject());
		}
	}
	
	IEnumerator DObject()
	{
		yield return new WaitForSeconds(4f);
		Destroy(tension3);
	}
}
