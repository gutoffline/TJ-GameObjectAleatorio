using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] listaDeBolas;
    private int bolaAtual = 0;
    float tempoPassado = 0f;
    float tempoTroca = 5f; 
    
    public void NovoObjetoAleatorio()
    {
        int novaBola = Random.Range(0, listaDeBolas.Length);
        listaDeBolas[bolaAtual].SetActive(false);
        bolaAtual = novaBola;
        listaDeBolas[bolaAtual].SetActive(true);
    }

    void Update()
    {
        tempoPassado += Time.deltaTime;
        if (tempoPassado >= tempoTroca)
        {
            NovoObjetoAleatorio();
            tempoPassado -= tempoTroca;
        }
    }
}
