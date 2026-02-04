using UnityEngine;
using UnityEngine.EventSystems;

public class plant : MonoBehaviour
{
    [SerializeField] private SpriteRenderer plantStatus;
    [SerializeField] private Sprite noPlant;
    [SerializeField] private Sprite plantDay1;
    [SerializeField] private Sprite plantDay2;
    [SerializeField] private Sprite plantDay3;
    [SerializeField] private Sprite plantDay4;
    public float plantDay = 0; //startando o dia atua da platação em 0, provavelmente é melhor dar essa atribuição em outro lugar, mas ainda n sei 
    public float seedPlant = 0; //guardando qual a planta desse slot //no momento so funciona a usando a cenoura
    [SerializeField] private GameObject selectDisplay;
 
    

    // Update is called once per frame
    void Update()
    {
        plantSwitch(); // chama o switch pra escolher o sprite baseado no dia atual da planta
        
    }

    public void OnMouseDown() //função chamada quando clica no slot
    {
        plantation();
    }
    
    public void plantation() //chamando a função diretamente com um componente button que acessa essa função
    {
        if(plantDay == 0) //se o slot n tem plantação
        {
            
            selectDisplay.SetActive(true); //ativa a tela de seleção de sement
            var path = selectDisplay.GetComponent<plantationPath>();
            path.SetSlot(gameObject); //passando slot como parametro
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
                
                plantStatus.sprite = plantDay1;
                break;
            case 2:
                
                plantStatus.sprite = plantDay2;
                break;
            case 3:
                
                plantStatus.sprite = plantDay3;
                break;
            case 4:
                
                plantStatus.sprite = plantDay4;
                break;
            default:
                //"Não conseguiu ler o dia da planta ou passou do dia 4"
                break;
        }       
    }
}
