using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;


public class Raycast : MonoBehaviour
{
	private RaycastHit hit;
	public float hitrange;
	public LayerMask touchable;
	public GameObject crosshair;
	public AudioClip knock;
	public GameObject maplight;
	public GameObject map14,M1;
	public bool m1;
	public GameObject map24,M2;
	public bool m2;
	public GameObject map34,M3;
	public bool m3;
	public GameObject map44,M4;
	public bool m4;
	public bool mapbool = false;
	public GameObject fl;
	public GameObject flground;
	public GameObject wall1, wall2, wall3, wall4;
	public GameObject keyobj;
	public GameObject exitdoor;
	public GameObject exittext;
	public bool key;
	public bool isplayeralive = true;
	private bool once = false;
	public GameObject inreact;
	public GameObject ml;
	public GameObject fltext;
	public GameObject tabtext;
	public bool flbool;
	public bool kapibool,kapibool2;
	public bool m3bool,m4bool;
	public GameObject waypointobj;
	public GameObject winmenu;
	private void Start()
	{
		exittext.GetComponent<Animator>().SetTrigger("showtext");
	}
	private void Update()
	{

		if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, hitrange, touchable))
		{
			crosshair.SetActive(true);
			if(once == false && hit.transform.tag != "exit")
			{
				once = true;
				inreact.GetComponent<Animator>().SetTrigger("showtext");
			}

			if (Input.GetKeyDown(KeyCode.E))
			{
				if (hit.transform.tag == "lastexit")
				{
					Cursor.visible = true;
					Cursor.lockState = CursorLockMode.None;
					Time.timeScale = 0f;
					winmenu.SetActive(true);
				}
				if (hit.transform.tag == "exit")
				{
					if(!key)
					{
						exittext.GetComponent<Animator>().SetTrigger("showtext");
					}
				}
				if (hit.transform.tag == "key")
				{
					exitdoor.SetActive(true);
					keyobj.SetActive(false);
					key = true;
				}
				if (hit.transform.tag == "kapi")
				{
					hit.transform.GetComponent<AudioSource>().PlayOneShot(knock);
					hit.transform.Translate(10,0,0);
					kapibool = true;
				}
				if (hit.transform.tag == "kapi2")
				{
					hit.transform.GetComponent<AudioSource>().PlayOneShot(knock);
					hit.transform.Translate(10, 0, 0);
					kapibool2 = true;
				}
				if (hit.transform.tag == "map14")
				{
					tabtext.GetComponent<Animator>().SetTrigger("showtext");
					StartCoroutine(waypointtxt());
					mapbool = true;
					Destroy(ml); ml = null;
					M1.SetActive(false);
					map14.SetActive(true);
					m1 = true;
					wall1.SetActive(false);
				}
				if (hit.transform.tag == "map24")
				{
					M2.SetActive(false);
					map14.SetActive(false);
					map24.SetActive(true);
					m2 = true;
					wall2.SetActive(false);
				}
				if (hit.transform.tag == "map34")
				{
					m3bool = true;
					M3.SetActive(false);
					map24.SetActive(false);
					map34.SetActive(true);
					m3 = true;
					wall3.SetActive(false);
				}
				if (hit.transform.tag == "map44")
				{
					m4bool = true;
					M4.SetActive(false);
					map34.SetActive(false);
					map44.SetActive(true);
					m4 = true;
					wall4.SetActive(false);
				}
				if (hit.transform.tag == "fener")
				{
					flbool = true;
					fltext.GetComponent<Animator>().SetTrigger("showtext");
					flground.SetActive(false);
					fl.SetActive(true);
				}
			}
		}
		else
		{
			crosshair.SetActive(false);
		}
	}

	IEnumerator waypointtxt()
	{
		yield return new WaitForSeconds(4);
		waypointobj.GetComponent<Animator>().SetTrigger("showtext");
	}
}
