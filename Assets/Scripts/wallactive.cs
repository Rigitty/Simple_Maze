using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallactive : MonoBehaviour
{
    public bool isenter;
    public GameObject wall;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isenter)
            {
                wall.SetActive(true);
            }
            else
            {
                wall.SetActive(false);
            }
        }
    }
}
