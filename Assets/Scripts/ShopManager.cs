using UnityEngine;
using System.Collections.Generic;

public class ShopManager : MonoBehaviour
{
    [Header("Referências")]
    public PlayerInventory playerInventory;
    public UIManager uiManager;

    [Header("Áudio da Loja")]
    public AudioSource audioSource;
    public AudioClip somCompra;
    // 1. Nova variável para o som de erro
    public AudioClip somErro; 

    [Header("Catálogo")]
    public List<ItemData> shopItems;

    public void BuyItem(ItemData itemToBuy)
    {
        // Se o jogador TEM ouro...
        if (playerInventory.HasEnoughGold(itemToBuy.itemPrice))
        {
            playerInventory.DeductGold(itemToBuy.itemPrice);
            playerInventory.AddItem(itemToBuy);

            if (uiManager != null)
            {
                uiManager.UpdateGoldDisplay();
                uiManager.UpdateInventoryDisplay(itemToBuy.itemName);
            }

            // Toca o som de sucesso
            if (audioSource != null && somCompra != null)
            {
                audioSource.PlayOneShot(somCompra);
            }

            Debug.Log("Compra realizada: " + itemToBuy.itemName);
        }
        // Se o jogador NÃO TEM ouro...
        else
        {
            if (uiManager != null)
            {
                uiManager.ShowWarning("Ouro insuficiente!");
            }

            // 2. Toca o som de erro AQUI!
            if (audioSource != null && somErro != null)
            {
                audioSource.PlayOneShot(somErro);
            }

            Debug.LogWarning("Ouro insuficiente para comprar: " + itemToBuy.itemName);
        }
    }
}