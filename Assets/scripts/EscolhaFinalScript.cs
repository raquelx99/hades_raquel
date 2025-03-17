using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscolhaFinalScript : MonoBehaviour
{

    public EstadoDoJogo estadoDoJogo;

    public void escolherSim()
    {
        estadoDoJogo.maquinaDestruida = true;
        carregarCena();
    }

    public void escolherNao()
    {
        estadoDoJogo.maquinaDestruida = false;
        carregarCena();
    }

    private void carregarCena()
    {
        SceneManager.LoadScene("Tela Final");
    }
}
