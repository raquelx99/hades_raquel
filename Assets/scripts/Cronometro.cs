using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public float tempoTotal = 600f;
    private float tempoRestante;
    public TextMeshProUGUI textoCronometro;
    public EstadoDoJogo estadoDoJogo;

    void Start()
    {
        tempoRestante = tempoTotal;
    }

    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
            int minutos = Mathf.FloorToInt(tempoRestante / 60);
            int segundos = Mathf.FloorToInt(tempoRestante % 60);
            textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
            estadoDoJogo.tempoFinal = tempoRestante;
        }
        else
        {
            estadoDoJogo.tempoEsgotado = true;
            FimDeJogo();
        }
    }

    void FimDeJogo()
    {
        SceneManager.LoadScene("Tela final");
    }
}