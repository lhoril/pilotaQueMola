using UnityEngine;

public class controladorDeCamera : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 desplaçament;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        desplaçament = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = jugador.transform.position + desplaçament;
    }
}
