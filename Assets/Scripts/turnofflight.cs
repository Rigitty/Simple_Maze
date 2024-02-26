using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnofflight : MonoBehaviour
{
    private GameObject[] lamps;
    public AudioClip powercutsound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           lamps= GameObject.FindGameObjectsWithTag("lamba");

            for(int counter=0; counter<lamps.Length; counter++)
            {
                lamps[counter].SetActive(false);
            }
            other.GetComponent<AudioSource>().PlayOneShot(powercutsound);
            Destroy(this.gameObject);
        }
    }
}
