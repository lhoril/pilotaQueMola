using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDelJugador : MonoBehaviour
{
    public TextMeshProUGUI txtMarcador;

    public float velocitat = 5;
    public GameObject objecteControladorDelJoc;
    public ControladorDelJoc scriptControladorDelJoc;
    public int nEscena = 1;
    int puntsTotals = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        objecteControladorDelJoc = 
            GameObject.FindGameObjectWithTag("GameController");
        scriptControladorDelJoc = 
            objecteControladorDelJoc.GetComponent<ControladorDelJoc>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float movimentHoritzontal = Input.GetAxis("Horizontal");
        float movimentVertical = Input.GetAxis("Vertical");

        Vector3 moviment = new Vector3(movimentHoritzontal, 0f, movimentVertical);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(moviment * velocitat * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cubo")
        {
            Destroy(other.gameObject);
            scriptControladorDelJoc.SumaPuntuacio(1);
            txtMarcador.text = $"Punts: {scriptControladorDelJoc.ObtenPuntacio()}";
            if (scriptControladorDelJoc.ObtenPuntacio() == puntsTotals)
            {
                nEscena++;
                Final();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Final"))
        {
            if (nEscena != 3) nEscena++;
            else nEscena = 0;
            Final();
        }
    }

    private void Final()
    {
        SceneManager.LoadScene(nEscena, LoadSceneMode.Single);
    }
}
