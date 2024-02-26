using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class UIsettings : MonoBehaviour
{
	private bool isFullscreen = true;
	public GameObject mm;
	public GameObject settings;
	public GameObject sett;
	public AudioMixer amix;
	public void mousesens(float a)
	{
		PlayerPrefs.SetFloat("mousenspeed", a);
	}
	public void mastervolume(float a)
	{
		amix.SetFloat("MasterVolume", a);
	}
	public void back()
	{
		mm.SetActive(true);
		settings.SetActive(false);
		gameObject.SetActive(false);
	}
	public void SetFullscreen(bool fullscreen_enable)
	{
		Screen.fullScreen = fullscreen_enable;
		isFullscreen = fullscreen_enable;
	}
	public void SetResolution(int index)
	{
		if (index == 0)
		{
			Screen.SetResolution(1920, 1080, isFullscreen);
		}
		else if (index == 1)
		{
			Screen.SetResolution(1280, 720, isFullscreen);
		}
		else if (index == 2)
		{
			Screen.SetResolution(800, 600, isFullscreen);
		}
	}
	public void Setwp(bool wp)
	{
		if(wp == false)
		{
			GameObject.FindGameObjectWithTag("Sett").GetComponent<Dontdestroy>().wp = false;
		}
		else
		{
			GameObject.FindGameObjectWithTag("Sett").GetComponent<Dontdestroy>().wp = true;
		}
	}
	public void main_btn()
	{
		SceneManager.LoadScene("mainmenu");
	}
}
