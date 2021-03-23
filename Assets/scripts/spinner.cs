using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 1f;

    void Start()
    {
        
    }
    void Update()
    {
        float yAngle =  rotateSpeed * Time.deltaTime;
        transform.Rotate(0, yAngle, 0);
    }
}
