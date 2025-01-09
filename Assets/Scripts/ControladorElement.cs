using UnityEngine;

public class ControladorElement : MonoBehaviour
{
    public float VelocitatRotacio = 5F;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(1,30,-100) * Time.deltaTime);   
        transform.RotateAround(new Vector3(0F,1F,0F), VelocitatRotacio * Time.deltaTime);
    }
}
