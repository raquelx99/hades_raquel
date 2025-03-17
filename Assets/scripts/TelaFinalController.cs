using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaFinalController : MonoBehaviour
{
    public GameObject mainMenu;
    public Button startButton;
    public Button menuButton;
    public TextMeshPro textoPontuacao;

    public EstadoDoJogo estadoDoJogo;

    public AudioClip somFinal1;
    public AudioClip somFinal2;

    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        startButton.onClick.AddListener(StartGame);
        menuButton.onClick.AddListener(BackToMenu);
        float tempoGasto = estadoDoJogo.tempoFinal;
        int pontuacao = (tempoGasto >= 600f) ? 0 : Mathf.Max(0, Mathf.FloorToInt(1000 - tempoGasto));
        textoPontuacao.text = "Pontuação: " + pontuacao.ToString();
        TocarSomFinal();      
    }

    public void TocarSomFinal()
    {
        if(estadoDoJogo.maquinaDestruida)
        {
            audioSource.clip = somFinal1;
        }else if(estadoDoJogo.tempoEsgotado)
        {
            audioSource.clip = somFinal1;
        }else
        {
            audioSource.clip = somFinal2;
        }

        audioSource.Play();
    }

    public void HideAll()
    {
        mainMenu.SetActive(false);
    }

    public void StartGame()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("1 Start Scene");
    }
}
