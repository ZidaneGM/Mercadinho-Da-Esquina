using UnityEngine;
using TMPro;

public class addDay : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI nowDay;

    private void Update() {
        nowDay.text ="Dia " + GameObject.FindWithTag("GameController").GetComponent<playerController>().dayCount.ToString(); //atualiza o texto do display do dia atual, pegando o valor do dia atual do jogo no script do playerController
    }


    public void addxDay(int dayToAdd) //função chamada quando clica no botão de avançar dia
    {
        GameObject.FindWithTag("GameController").GetComponent<playerController>().dayCount += dayToAdd; //adiciona o valor do dia passado como parâmetro ao dia atual do jogo, acessando o script do playerController que tem a variável do dia atual do jogo
        gameObject.SetActive(false); //desativa a tela de seleção de semente, o objeto pai a esse
        //adicionar algum retorno visual pra dizer que adicionou os dias, ao invez se so sumir o display
    }


}
