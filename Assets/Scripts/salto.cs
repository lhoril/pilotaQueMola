using UnityEngine;

public class salto : MonoBehaviour
{
    public float ForçaDeSalt = 0.4f;
    public Rigidbody rb;
    public float thrust = 10;
    bool m_isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && m_isGrounded == true)
        {
            Jump();
        }
    }

    public void Jump()
    {
        m_isGrounded = false;
        rb.AddForce(0, thrust, 0, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("CheckPoint"))
        {
            m_isGrounded = true;
        }
    }
}
