using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    int hits = 0;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "hit" && other.gameObject.tag !="ground")
        {
        hits++;
        Debug.Log("You bumped this many times: " + hits);
        }
    }
}
