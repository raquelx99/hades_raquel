using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class PuzzleAlavancaController : MonoBehaviour
{
    public XRLever alavanca1;
    public XRLever alavanca2;
    public XRLever alavanca3;

    public Animator portaEsquerda;
    public Animator portaDireita;

    private bool[] correctSequence = {true, true, false};

    void Start()
    {
        alavanca1.onLeverActivate.AddListener(CheckPuzzle);
        alavanca1.onLeverDeactivate.AddListener(CheckPuzzle);

        alavanca2.onLeverActivate.AddListener(CheckPuzzle);
        alavanca2.onLeverDeactivate.AddListener(CheckPuzzle);

        alavanca3.onLeverActivate.AddListener(CheckPuzzle);
        alavanca3.onLeverDeactivate.AddListener(CheckPuzzle);
    }

    private void CheckPuzzle()
    {

        bool[] currentSequence = {
            alavanca1.value,
            alavanca2.value,
            alavanca3.value,
        };

        for (int i = 0; i < correctSequence.Length; i++)
        {
            if (currentSequence[i] != correctSequence[i])
            {
                return;
            }
        }

        portaEsquerda.Play("CaixaAbrirEsquerda");
        portaDireita.Play("CaixaAbrirDireita");
    }
}