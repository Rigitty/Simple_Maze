using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tension4TR : MonoBehaviour
{
	public GameObject tension4;
	public GameObject knife;
	public AudioClip audioclip;
	private void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Player")
		{
			knife.SetActive(true);
			StartCoroutine(ac());
			GetComponent<Collider>().enabled = false;
		}

		IEnumerator ac()
		{
			yield return new WaitForSeconds(0.15f);
			GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().PlayOneShot(audioclip);
		}
	}
}
