using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Flashlight : MonoBehaviour
{
    private bool isflashturnon;
    public GameObject fl;
    public GameObject buttonlight;
    public AudioClip click;
    public GameObject rc;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && rc.GetComponent<Raycast>().flbool == true)
        {
            GetComponent<AudioSource>().PlayOneShot(click);
            if (!isflashturnon)
            {
                buttonlight.SetActive(true);
                fl.SetActive(true);
                isflashturnon = true;
            }
            else
            {
                buttonlight.SetActive(false);
                fl.SetActive(false);
                isflashturnon = false;
            }
        }
    }
}
