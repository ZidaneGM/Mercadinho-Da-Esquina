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
        
        selectSlot.GetComponent<plant>().seedPlant = thisSeed; // passa o valor int da semente selecionada
        selectSlot.GetComponent<plant>().plantDay = 1; // inicia o dia da planta em 1
        transform.parent.gameObject.SetActive(false); //desativa a tela de seleção de semente, o objeto pai a esse
    }
}
