using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> checkPoints;
    public Vector3 vectorPoint = Vector3.zero;
    public float dead = 100;

    private void Update()
    {
        if (player.transform.position.y < -dead)
        {
            player.transform.position = vectorPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckPoint"))
        {
            vectorPoint = player.transform.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            player.transform.position = vectorPoint;
        }
    }
}
