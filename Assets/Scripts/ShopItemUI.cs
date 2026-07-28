using UnityEngine;
using UnityEngine.UI; // Necessário para usar o componente de Imagem
using TMPro; // Necessário para os textos

public class ShopItemUI : MonoBehaviour
{
    [Header("UI Elements")]
    public Image iconDisplay;
    public TextMeshProUGUI nameDisplay;
    public TextMeshProUGUI priceDisplay;
    
    [Header("Data & Manager")]
    public ItemData item; // O arquivo do item (Espada, Escudo, etc)
    public ShopManager shopManager; // O gerente da loja

    void Start()
    {
        // Assim que o jogo começar, ele pega os dados do item e coloca na tela
        if (item != null)
        {
            iconDisplay.sprite = item.itemIcon;
            nameDisplay.text = item.itemName;
            priceDisplay.text = item.itemPrice.ToString() + " Ouro";
        }
    }

    // Esse método será ativado quando o jogador clicar no botão de "Comprar"
    public void OnBuyButtonPressed()
    {
        if (shopManager != null && item != null)
        {
            shopManager.BuyItem(item); // Avisa o gerente qual item queremos comprar
        }
    }
}