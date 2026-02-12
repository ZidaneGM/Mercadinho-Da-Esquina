using UnityEngine;
using UnityEngine.EventSystems;

public class plant : MonoBehaviour
{
    [SerializeField] private SpriteRenderer plantStatus;
    [SerializeField] private Sprite noPlant;

    public float plantDay = 0; //startando o dia atua da platação em 0, provavelmente é melhor dar essa atribuição em outro lugar, mas ainda n sei 
    public float seedPlant = 0; //guardando qual a planta desse slot //no momento so funciona a usando a cenoura
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
        if(seedPlant == 1) //cenoura
        {
            plantDaySprites = carrotSprites;
        }
        else if(seedPlant == 2) //milho
        {
            plantDaySprites = cornSprites;
        }
        else if(seedPlant == 3) //berinjela
        {
            plantDaySprites = eggplantSprites;
        }
        else if(seedPlant == 4) //trigo
        {
            plantDaySprites = wheatSprites;
        }
        else if(seedPlant == 5) //abobora
        {
            plantDaySprites = pumpkinSprites;
        }

        plantSwitch(); // chama o switch pra escolher o sprite baseado no dia atual da planta
        
    }
    public void closeDisplay() //função para fechar a tela de seleção de semente, chamada por um botão na tela de seleção
    {
        selectDisplay.SetActive(false);
    }
    public void plantation() //chamando a função diretamente com um componente button que acessa essa função
    {
        if(plantDay == 0) //se o slot n tem plantação
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
            if(plantDay < 4)
            {
                plantDay = plantDay + 1;
            }
            
        }
        // parte ate o comentario acima sera retirada no futuro

        if(plantDay == 4)
        {
            //aqui vai entrar a logica de colher
            Debug.Log("pode colher");
        }

    }
    private void plantSwitch()
    {
        switch (plantDay)
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
            case 5:
                
                plantStatus.sprite = plantDaySprites[4];
                break;
            default:
                //"Não conseguiu ler o dia da planta ou passou do dia 4"
                break;
        }       
    }
}
