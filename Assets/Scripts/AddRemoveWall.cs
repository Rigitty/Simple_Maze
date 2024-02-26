using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class AddRemoveWall : MonoBehaviour
{
    public float offset;
    public GameObject player;
    private RaycastHit hit;
    public float hitrange=10;
    public GameObject removewall;
    public GameObject addwall;
    public LayerMask layer;
    public GameObject scexe;

    private void OnTriggerStay(Collider other)
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, hitrange, layer))
        {
            if(scexe.GetComponent<Raycast>().kapibool == true)
            {
				AddWall();
			}
			if (scexe.GetComponent<Raycast>().kapibool2 == true)
			{
				RemoveWall();
                Destroy(gameObject);
			}
		}
    }
    private void RemoveWall()
    {
       removewall.SetActive(false);
    }
    private void AddWall()
    {
        addwall.SetActive(true);
    }

}
