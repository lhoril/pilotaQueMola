using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RespawnPoint : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> checkPoints;
    public Vector3 vectorPoint = Vector3.zero;
    public float dead = -10;
    public Slider sldVida;
    public TextMeshProUGUI textFinal;

    private void Update()
    {
        if (player.transform.position.y <= -dead)
        {
            player.transform.position = vectorPoint;
            if (sldVida.value > 0)
            {
                sldVida.value = sldVida.value - 1;
            }
            else
            {
                sldVida.value = 0;
                Destroy(player);
                textFinal.text = "MORT";
            }
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
            if (sldVida.value > 0)
            {
                sldVida.value = sldVida.value - 1;
            }
            else
            {
                sldVida.value = 0;
                Destroy(player);
                textFinal.text = "MORT";
            }
        }
    }
}
