using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakbulb : MonoBehaviour
{
    public GameObject bulb;
    public AudioClip breaksound;
    public GameObject breakeffect;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(breakeffect,bulb.transform.position, bulb.transform.rotation);
        bulb.GetComponent<AudioSource>().PlayOneShot(breaksound);
        bulb.GetComponent<Light>().intensity=0;
        this.gameObject.SetActive(false);
    }
}
