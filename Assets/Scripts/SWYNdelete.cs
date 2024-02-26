using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWYNdelete : MonoBehaviour
{
    public GameObject parent;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "swyn")
        {
            Destroy(parent.gameObject);
        }
    }
}
