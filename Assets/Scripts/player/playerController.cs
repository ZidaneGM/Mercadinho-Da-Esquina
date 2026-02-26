using UnityEngine;
using TMPro;

public class playerController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI money; // texto onde é exibido o dinheiro do jogador, para atualizar o valor na UI
    [SerializeField] public int totalMoney; //dinheiro total do jogador, pode ser acessado por outros scripts para verificar se o jogador tem a quantidade necessária para comprar ou vender
    [SerializeField] public int dayCount; // dias atuais do jogo, pode ser acessado por outros scripts para verificar o dia atual e fazer eventos baseados nisso
    //adicionar um lugar pra mostgrar o dia atual na UI

    //quantidade de sementes e plantas que o jogador tem, pode ser acessada por outros scripts para verificar se o jogador tem a quantidade necessária para plantar ou vender
    [SerializeField] public TextMeshProUGUI []seeds; //array com o texto de cada semente para atualizar a quantidade na UI
    
    
    [SerializeField] public int carrotSeed;
    [SerializeField] public int cornSeed;
    [SerializeField] public int eggplantSeed;
    [SerializeField] public int wheatSeed;
    [SerializeField] public int pumpkinSeed;

    [SerializeField] public int []seedCount; //array com a quantidade de cada semente que o jogador tem
    int seedCountLength = 5; //quantidade de tipos de sementes, para definir o tamanho do array
    void Start()
    {
        seedCount = new int[seedCountLength];
        seedCount[0] = carrotSeed;
        seedCount[1] = cornSeed;  
        seedCount[2] = eggplantSeed;
        seedCount[3] = wheatSeed;
        seedCount[4] = pumpkinSeed;
    }

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
        //texto na ui da mochila
        seeds[0].text = carrotSeed.ToString();
        seeds[1].text = cornSeed.ToString();
        seeds[2].text = eggplantSeed.ToString();
        seeds[3].text = wheatSeed.ToString();
        seeds[4].text = pumpkinSeed.ToString();
        //texto na ui da plantação
        seeds[5].text = carrotSeed.ToString();
        seeds[6].text = cornSeed.ToString();
        seeds[7].text = eggplantSeed.ToString();
        seeds[8].text = wheatSeed.ToString();
        seeds[9].text = pumpkinSeed.ToString();

        plants[0].text = carrot.ToString();
        plants[1].text = corn.ToString();
        plants[2].text = eggplant.ToString();
        plants[3].text = wheat.ToString();
        plants[4].text = pumpkin.ToString();

        money.text = totalMoney.ToString();

        //variavel com valor de semente recebe o valor atualizado do array
        carrotSeed = seedCount[0];
        cornSeed = seedCount[1];            
        eggplantSeed = seedCount[2];
        wheatSeed = seedCount[3];
        pumpkinSeed = seedCount[4];
    
    }

}
