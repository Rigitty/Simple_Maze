using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
	public GameObject reddot;
	private GameObject player;
	private float destz;
	private float conz;
	private float destx;
	private float conx;
	public float offsetx, offsetz;
	public bool easymode;
	public GameObject scexe;
	private void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	private void Update()
	{
		if(GameObject.FindGameObjectWithTag("Sett") != null)
			easymode = GameObject.FindGameObjectWithTag("Sett").GetComponent<Dontdestroy>().wp;
        if(scexe.GetComponent<Raycast>().mapbool == true)
        {
			if (easymode)
			{
				reddot.SetActive(true);
				destx = 40 - player.transform.position.z;
				destz = 40 - player.transform.position.x;
				conx = Mathf.Clamp(destx * 0.0096f - offsetx, -0.3f, 0.3f);
				conz = Mathf.Clamp(destz * 0.0096f - offsetz, -0.3f, 0.3f);

				reddot.transform.localPosition = new Vector3(conx, 0.028f, -conz);
			}
			else
			{
				reddot.SetActive(false);
			}
		}
	}
}
