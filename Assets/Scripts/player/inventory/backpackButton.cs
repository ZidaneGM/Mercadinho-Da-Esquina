using UnityEngine;

public class backpackButton : MonoBehaviour
{
    [SerializeField] private GameObject backpackDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void switchBackpack() //chamando a função diretamente com um componente button que acessa essa função
    {
        if (backpackDisplay.activeSelf) //se o display da mochila estiver aberto
        {
            backpackDisplay.SetActive(false); //fecha o display da mochila
        }
        else
        {
            backpackDisplay.SetActive(true); //abre o display da mochila
        }
    }
    
}
