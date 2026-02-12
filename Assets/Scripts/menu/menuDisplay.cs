using UnityEngine;

public class menuDisplay : MonoBehaviour
{
    [SerializeField] private GameObject []menuButtons; //array com os botões do menu para ativar e desativar
    
    public void switchDisplay(int buttonIndex) //chamando a função diretamente com um componente button que acessa essa função
    {
        if (menuButtons[buttonIndex].activeSelf) //se o display da mochila estiver aberto
        {
            menuButtons[buttonIndex].SetActive(false); //fecha o display da mochila
        }
        else
        {
            menuButtons[buttonIndex].SetActive(true); //abre o display da mochila
        }
    }

    
}
