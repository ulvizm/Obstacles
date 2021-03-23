using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    MeshRenderer myRenderer;
    Rigidbody myRigidbody;
    [SerializeField] float dropTime = 5f;
    
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.enabled = false;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }
    void Update()
    {
        if (Time.time > dropTime)
        {
            myRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
