# Exibindo GameObjects Aleatoriamente

![GameDev](icones/game1.png)
![Unity](icones/unity1.png)
![Git](icones/git.png)
![cSharp](icones/csharp.png)

___

Exemplo de como exibir GameObjects de forma aleatório a cada 10 (ou 5) segundos.

```
public GameObject[] listaDeBolas;
private int bolaAtual = 0;

public void NovoObjetoAleatorio(){
    int novaBola = Random.Range(0, listaDeBolas.Length);
    listaDeBolas[bolaAtual].SetActive(false);
    bolaAtual = novaBola;
    listaDeBolas[bolaAtual].SetActive(true);
}
```
Na função `NovoObjetoAleatorio()` é selecionado aleatoriamente uma posição de `listaDeBolas` e guardado na variável **novaBola**. Depois esconde-se a **bolaAtual** e se atribui o valor de **novaBola** para **bolaAtual**. Por fim

> “Se é uma boa ideia, vá em frente e faça porque é muito mais fácil pedir desculpas do que obter permissão.” ***Grace Hopper***.


