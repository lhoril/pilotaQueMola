using UnityEngine;

public class controladorDeCamera : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 desplašament;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        desplašament = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = jugador.transform.position + desplašament;
    }
}
