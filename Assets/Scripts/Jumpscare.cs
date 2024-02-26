using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
	public AudioSource sound;
	public GameObject player;
	public GameObject jumpcam;
	public GameObject img;
	public GameObject scexe;
	public GameObject robot;
	public GameObject jspos;
	public GameObject lostmenuobj;
	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player")
		{
			jspos.GetComponent<JSposition>().enable = false;
			sound.Play();
			robot.SetActive(false);
			jumpcam.SetActive(true);
			player.SetActive(false);
			StartCoroutine(EndJump());
		}
		IEnumerator EndJump()
		{
			yield return new WaitForSeconds(1.35f);
			scexe.GetComponent<Raycast>().isplayeralive = false;
			img.SetActive(true);
			StartCoroutine(lostmenu());
		}
		IEnumerator lostmenu()
		{
			yield return new WaitForSeconds(1.35f);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			lostmenuobj.SetActive(true);
		}
	}
}
