using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TensionTrigger1 : MonoBehaviour
{
	public GameObject scexe;
	public GameObject arm;
    public AudioClip ac;
	private void OnTriggerStay(Collider other)
	{
        if (other.transform.tag == "Player")
        {
            if (scexe.GetComponent<Raycast>().m2 == true)
            {
                arm.SetActive(true);
            }
        }
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.transform.tag == "Player")
		{
            if (scexe.GetComponent<Raycast>().m2 == true)
            {
                arm.GetComponent<Animator>().SetTrigger("Trigger");
                other.transform.GetComponent<AudioSource>().PlayOneShot(ac);
                StartCoroutine(destroyobjs());
            }
        }
	}
    IEnumerator destroyobjs()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(arm);
        Destroy(gameObject);
    }
}
