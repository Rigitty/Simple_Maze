using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetFlashlight : MonoBehaviour
{
    private Vector3 vectOffset;
    [SerializeField] private float speed = 3f;
    public GameObject followobject;
    public GameObject delayobject;

    private void Start()
    {
        vectOffset = delayobject.transform.position - followobject.transform.position;
    }
    private void Update()
    {
        delayobject.transform.position =  followobject.transform.position + vectOffset;
        delayobject.transform.rotation = Quaternion.Slerp(delayobject.transform.rotation,followobject.transform.rotation,speed*Time.deltaTime);
    }
}
