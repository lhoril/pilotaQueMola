using System.Collections.Generic;
using UnityEngine;

public class respawnPerLimits : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 vectorPoint = Vector3.zero;

    private void Start()
    {
        vectorPoint = new Vector3(
            0F, 1.5F, -2.72F
            );
    }

    private void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.position = vectorPoint;
    }
}
