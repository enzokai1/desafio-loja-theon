using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [Header("Economy")]
    public int currentGold = 100;

    [Header("Inventory")]
    public List<ItemData> acquiredItems = new List<ItemData>();

    // Verifica se o jogador tem ouro suficiente
    public bool HasEnoughGold(int amount)
    {
        return currentGold >= amount;
    }

    // Subtrai o ouro do saldo
    public void DeductGold(int amount)
    {
        currentGold -= amount;
    }

    // Adiciona o item à lista de itens adquiridos
    public void AddItem(ItemData item)
    {
        acquiredItems.Add(item);
    }
}