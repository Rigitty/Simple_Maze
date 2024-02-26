using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	private bool istopped;
	public GameObject settings;

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(!istopped)
			{
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
				settings.SetActive(true);
				Time.timeScale = 0;
				istopped = true;
			}
			else
			{
				back();
			}
		}
	}

	public void back()
	{
		settings.SetActive(false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		settings.SetActive(false);
		Time.timeScale = 1;
		istopped = false;
	}
}
