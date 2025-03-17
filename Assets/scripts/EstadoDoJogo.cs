using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "estadoDoJogo", menuName = "EstadoDoJogo")]
public class EstadoDoJogo : ScriptableObject
{
    public bool tempoEsgotado;
    public bool maquinaDestruida;
    public float tempoFinal;
}   
