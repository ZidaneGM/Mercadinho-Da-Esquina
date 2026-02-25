using UnityEngine;
using UnityEngine.EventSystems;

public class plant : MonoBehaviour
{
    [SerializeField] private SpriteRenderer plantStatus;
    [SerializeField] private Sprite noPlant;

    public float plantDay = 0; //startando o dia atua da platação em 0, provavelmente é melhor dar essa atribuição em outro lugar, mas ainda n sei 
    public float seedPlant = 0; //guardando qual a planta desse slot //no momento so funciona a usando a cenoura
    public float nowDay = 0; //variável para guardar o dia atual do jogo, para comparar com o dia da planta e fazer ela crescer, essa variável provavelmente vai ser retirada e o dia atual do jogo vai ser pego diretamente de outro script
    public float glowDay = 0; //variavel pra ver qual dia esta o crescimento da planta
    [SerializeField] private GameObject selectDisplay;
    
    [SerializeField] private Sprite[] carrotSprites;
    [SerializeField] private Sprite[] cornSprites;
    [SerializeField] private Sprite[] eggplantSprites;
    [SerializeField] private Sprite[] wheatSprites;
    [SerializeField] private Sprite[] pumpkinSprites;

    [SerializeField] private Sprite[] plantDaySprites;
    
    

    // Update is called once per frame
    void Update()
    {
        whatSeed(); //chama o switch para escolher a array de sprites baseado na semente plantada

        if(seedPlant != 0)
        {
            plantSwitch(); // chama o switch pra escolher o sprite baseado no dia atual da planta
            lookGrow(); //chama a função que calcula o dia de crescimento da planta, comparando o dia atual do jogo com o dia que a planta foi plantada
        }        
    }
    public void closeDisplay() //função para fechar a tela de seleção de semente, chamada por um botão na tela de seleção
    {
        selectDisplay.SetActive(false);
    }
    public void plantation() //chamando a função diretamente com um componente button que acessa essa função
    {
        if(glowDay == 0) //se o slot n tem plantação
        {
            
            selectDisplay.SetActive(true); //ativa a tela de seleção de sement
            var path = selectDisplay.GetComponent<plantationPath>();//passa slot pro script da tela de seleção de semente
            var pathTwo = selectDisplay.GetComponentsInChildren<confirmSeed>();//passa o slot pro script de cada semnte
            path.SetSlot(gameObject); //passando slot como parametro para tela de seleção de semente
            foreach (confirmSeed seed in pathTwo) //fazendo um loop em cada semente
            {
                seed.SetSlot(gameObject); //passando slot como parametro para cada semente
            }
             //manda o slot atual para o script plantationPath
            
        }

        //aumentar os dias da planta para testar ela passar pelos estagio de crescimento, esse função será excluida e os dias;estagio da planta seram mudadas automaticamente quando passar os dias no jogo
        else
        {   
            if(glowDay < 4)
            {
                glowDay = glowDay + 1;
            }
            
        }
        // parte ate o comentario acima sera retirada no futuro

        if(glowDay == 4)
        {
            //aqui vai entrar a logica de colher
            Debug.Log("pode colher");
        }

    }
    private void plantSwitch()
    {
        switch (glowDay)
        {
            case 0:
                
                plantStatus.sprite = noPlant;
                break;
                
            case 1:
                
                plantStatus.sprite = plantDaySprites[0];
                break;
            case 2:
                
                plantStatus.sprite = plantDaySprites[1];
                break;
            case 3:
                
                plantStatus.sprite = plantDaySprites[2];
                break;
            case 4:
                
                plantStatus.sprite = plantDaySprites[3];
                break;
            default:
                //"Não conseguiu ler o dia da planta ou passou do dia 4"
                break;
        }       
    }
    private void whatSeed()
    {
        switch (seedPlant)
        {
            case 0:
                //sem planta
                break;
            case 1:
                plantDaySprites = carrotSprites;
                break;
            case 2:
                plantDaySprites = cornSprites;
                break;
            case 3:
                plantDaySprites = eggplantSprites;
                break;
            case 4:
                plantDaySprites = wheatSprites;
                break;
            case 5:
                plantDaySprites = pumpkinSprites;
                break;
            default:
                //"Não conseguiu ler a semente"
                break;
        }
    }
    private void lookGrow()
    {
        
        
        glowDay = (GameObject.FindWithTag("GameController").GetComponent<playerController>().dayCount - plantDay) + 1;  //calcula o dia atual do jogo menos o dia que a planta foi plantada, para saber quantos dias ela tem
        
        
    }
}
