using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour
{
	public GameObject tmtext;
	public GameObject tfltext;
	public GameObject maplight;
	private void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Player")
		{
			if(gameObject.transform.tag == "tmtext")
			{
				maplight.SetActive(true);
				tmtext.GetComponent<Animator>().SetTrigger("showtext");
				Destroy(gameObject);
			}
			if (gameObject.transform.tag == "tfltext")
			{
				tfltext.GetComponent<Animator>().SetTrigger("showtext");
				Destroy(gameObject);
			}
		}
	}
}
