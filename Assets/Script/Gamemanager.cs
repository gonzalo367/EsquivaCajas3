using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    private float tiempoTranscurrido = 0f;
    private bool juegoActivo = true;

    void Update()
    {
        if (juegoActivo)
        {
            tiempoTranscurrido += Time.deltaTime;
            textoCronometro.text = "Tiempo: " + tiempoTranscurrido.ToString("F1");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void DetenerReloj()
    {
        juegoActivo = false;
    }
}