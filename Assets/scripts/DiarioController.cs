using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DiarioController : MonoBehaviour
{
    public List<string> paginasDiario = new List<string>();
    public TextMeshProUGUI textoDiario;
    private int paginaAtual = 0;

    void Start()
    {

        paginasDiario.Add(@"Ethan costumava me perguntar sobre meus experimentos. Ele era tão curioso… tão inteligente para a idade.
Ele gostava de ouvir sobre minhas teorias, sobre como o tempo e o espaço são apenas ilusões criadas pela mente.
Mas e se… e se ele não tiver partido? E se eu apenas não estiver mais na mesma frequência que ele?");

        paginasDiario.Add(@"7 de Novembro, 2147. Funcionou. O primeiro teste foi um sucesso. Pelo menos… parcialmente. O rato desapareceu da gaiola e não voltou. Mas por um instante, eu juro que vi uma sombra piscando no vidro da câmara.

Não foi destruição. Não foi morte. Foi transição. Ele simplesmente não estava mais aqui. Mas se foi para outro lugar, significa que há um caminho de volta. Preciso ajustar os cálculos.");

    paginasDiario.Add(@"A noite passada foi estranha. Meu reflexo no vidro… ele se moveu antes de mim.

Eu ouvi algo. Como um chiado baixo, como se estivesse tentando se ajustar… como um rádio fora de sintonia.

Ethan? Eu juro que ouvi sua voz.");

    paginasDiario.Add(@"Eu fiz algo terrível.

Era para ser apenas um experimento. Apenas um pequeno ajuste na frequência, um pequeno salto de uma realidade para outra. Mas… algo puxou de volta. Algo que não deveria estar lá.

A máquina ligou sozinha. Os monitores começaram a exibir rostos que eu não reconhecia. Mas um deles… Deus, um deles…");

    paginasDiario.Add(@"Era Ethan. Mas seus olhos estavam riscados. Como se alguém quisesse apagar sua identidade.

Ele disse algo, mas o som estava distorcido. E então… tudo apagou.");

    paginasDiario.Add(@"Eu sei o que aconteceu. Não perdi Ethan. Eu o expus à frequência errada. Ele ainda está aqui, mas fora de fase, preso entre camadas da realidade.

E agora, eu também estou.

Se você está lendo isto... significa que também faz parte disso.

A máquina ainda pode ser ajustada. Mas há um preço. Sempre há um preço.");


        AtualizarPagina();
    }

    public void ProximaPagina()
    {
        if (paginaAtual < paginasDiario.Count - 1)
        {
            paginaAtual++;
            AtualizarPagina();
        }
    }

    public void PaginaAnterior()
    {
        if (paginaAtual > 0)
        {
            paginaAtual--;
            AtualizarPagina();
        }
    }

    private void AtualizarPagina()
    {
        textoDiario.text = paginasDiario[paginaAtual];
    }
}
