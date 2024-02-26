using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tensionswyn : MonoBehaviour
{
	public GameObject spot;
	public GameObject arm;
	public AudioClip fluorescent;
	public GameObject asource;
	private bool once;
	private void OnTriggerEnter(Collider other)
	{
		if (once == false)
		{
			once = true;
			arm.SetActive(true);
			StartCoroutine(setactive());
		}
	}

	IEnumerator setactive()
	{
		yield return new WaitForSeconds(2.60f);
		arm.SetActive(false);
		spot.SetActive(false);
		asource.GetComponent<AudioSource>().PlayOneShot(fluorescent);
	}
}
