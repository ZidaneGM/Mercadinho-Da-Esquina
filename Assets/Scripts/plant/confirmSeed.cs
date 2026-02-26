using UnityEngine;

public class confirmSeed : MonoBehaviour
{
    [SerializeField] public GameObject selectSlot;
    [SerializeField] public int thisSeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void SetSlot(GameObject slot)
    {
        selectSlot = slot;
    }

    public void sendSeed() //função chamada quando clica na semente
    {
        if(GameObject.FindWithTag("GameController").GetComponent<playerController>().seedCount[thisSeed-1] >= 1) //verifica se o jogador tem a semente selecionada, se não tiver, a função é cancelada
        {   
            selectSlot.GetComponent<plant>().seedPlant = thisSeed; // passa o valor int da semente selecionada
            selectSlot.GetComponent<plant>().plantDay = GameObject.FindWithTag("GameController").GetComponent<playerController>().dayCount; // joga o dia que a semente foi plantada para o script da planta, para depois comparar com o dia atual do jogo e fazer a planta crescer
            selectSlot.GetComponent<plant>().nowDay = GameObject.FindWithTag("GameController").GetComponent<playerController>().dayCount; // joga o dia atual do jogo para o script da planta, para comparar com o dia que a planta foi plantada
            selectSlot.GetComponent<plant>().glowDay = 1; //define o dia de crescimento da planta como 1, para que ela apareça no sprite correto
            transform.parent.gameObject.SetActive(false); //desativa a tela de seleção de semente, o objeto pai a esse
            GameObject.FindWithTag("GameController").GetComponent<playerController>().seedCount[thisSeed-1]--; //remove uma semente do jogador
        }
        else
        {
            // se n tiver semente
        }
    }
}
