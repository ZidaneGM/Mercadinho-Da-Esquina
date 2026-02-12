using UnityEngine;
using TMPro;

public class playerController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI money; // texto onde é exibido o dinheiro do jogador, para atualizar o valor na UI
    [SerializeField] public int totalMoney; //dinheiro total do jogador, pode ser acessado por outros scripts para verificar se o jogador tem a quantidade necessária para comprar ou vender
    [SerializeField] public int dayCount; // dias atuais do jogo, pode ser acessado por outros scripts para verificar o dia atual e fazer eventos baseados nisso

    //quantidade de sementes e plantas que o jogador tem, pode ser acessada por outros scripts para verificar se o jogador tem a quantidade necessária para plantar ou vender
    [SerializeField] public TextMeshProUGUI []seeds; //array com o texto de cada semente para atualizar a quantidade na UI
    [SerializeField] public int carrotSeed;
    [SerializeField] public int cornSeed;
    [SerializeField] public int eggplantSeed;
    [SerializeField] public int wheatSeed;
    [SerializeField] public int pumpkinSeed;

    //quantidade de plantas que o jogador tem, pode ser acessada por outros scripts para verificar se o jogador tem a quantidade necessária para vender
    [SerializeField] public TextMeshProUGUI []plants; //array com o texto de cada planta para atualizar a quantidade na UI
    [SerializeField] public int carrot;
    [SerializeField] public int corn;
    [SerializeField] public int eggplant;
    [SerializeField] public int wheat;
    [SerializeField] public int pumpkin;



    // Update is called once per frame
    void Update()
    {
        seeds[0].text = carrotSeed.ToString();
        seeds[1].text = cornSeed.ToString();
        seeds[2].text = eggplantSeed.ToString();
        seeds[3].text = wheatSeed.ToString();
        seeds[4].text = pumpkinSeed.ToString();

        plants[0].text = carrot.ToString();
        plants[1].text = corn.ToString();
        plants[2].text = eggplant.ToString();
        plants[3].text = wheat.ToString();
        plants[4].text = pumpkin.ToString();

        money.text = totalMoney.ToString();
        
    
    }

}
