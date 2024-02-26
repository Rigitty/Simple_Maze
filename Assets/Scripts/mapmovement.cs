using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class mapmovement : MonoBehaviour
{
	public GameObject map;
	private bool mapup;
	public GameObject maplight;
	public GameObject scexe;
	private void Update()
	{
		if (scexe.GetComponent<Raycast>().mapbool == true) 
		{
			if (Input.GetKeyDown(KeyCode.Tab))
			{
				if (!mapup)
				{
					map.GetComponent<Animator>().SetTrigger("look");
					maplight.SetActive(true);
					mapup = true;
				}
				else
				{
					map.GetComponent<Animator>().SetTrigger("look");
					maplight.SetActive(false);
					mapup = false;
			}
		}
		}
	}
}
