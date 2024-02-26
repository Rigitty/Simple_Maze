using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour
{
	public float mousesens = 85;
	public bool wp = false;
	private void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}

	private void Update()
	{
		mousesens = PlayerPrefs.GetFloat("mousenspeed");
	}
}
