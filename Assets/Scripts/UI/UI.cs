using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
	public GameObject settings;
	public GameObject mm;
	public GameObject image;
	public GameObject op;

	public void Start()
	{
		StartCoroutine(destop());
	}
	public void Play_btn()
	{
		StartCoroutine(vignet());
	}
	public void Settings_btn()
	{
		settings.SetActive(true);
		mm.SetActive(false);
	}

	public void main_btn()
	{
		SceneManager.LoadScene("mainmenu");
	}

	public void Exit_btn()
	{
		Application.Quit();
	}
	
	public void openitch()
	{
		Application.OpenURL("https://rigitty.itch.io");
	}

	IEnumerator vignet()
	{
		image.SetActive(true);
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("ingame");
	}

	IEnumerator destop()
	{
		yield return new WaitForSeconds(4.5f);
		Destroy(op);
	}
}
