using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDelJoc : MonoBehaviour
{
    const string PUNTUACIO_MAXIMA = "PuntuacioMax";
    [HideInInspector]
    int puntuacio = 0;
    int puntuacioMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.GetInt(PUNTUACIO_MAXIMA,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumaPuntuacio(int quantita)
    {
        puntuacio += quantita;
        if (puntuacio > puntuacioMax)
        {
            puntuacioMax = puntuacio;
            PlayerPrefs.SetInt(PUNTUACIO_MAXIMA, puntuacio);
        }
    }

    public int ObtenPuntacio()
    {
        return puntuacio;
    }

    public void CarregaEscena(int nEscena)
    {
        SceneManager.LoadScene(nEscena, LoadSceneMode.Single);
    }
    
    public void Surt()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
