using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Obrigatório para controlar os textos do TextMeshPro

public class UIManager : MonoBehaviour
{
    [Header("Referências Principais")]
    public PlayerInventory playerInventory; // Para o UI saber quanto de ouro o jogador tem

    [Header("Displays da Interface")]
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI inventoryText;

    [Header("Sistema de Avisos")]
    public GameObject warningPanel; 
    public TextMeshProUGUI warningText; 

    private void Start()
    {
        // Garante que o painel de aviso comece desligado quando o jogo rodar
        if (warningPanel != null)
        {
            warningPanel.SetActive(false);
        }
        
        // Atualiza o ouro logo que o jogo começa
        UpdateGoldDisplay();
    }

    // Função chamada pelo ShopManager quando o jogador compra algo com sucesso
    public void UpdateGoldDisplay()
    {
        if (playerInventory != null && goldText != null)
        {
            goldText.text = "Ouro: " + playerInventory.currentGold.ToString();
        }
    }

    // Função chamada pelo ShopManager para adicionar o item na lista da tela
    public void UpdateInventoryDisplay(string itemName)
    {
        if (inventoryText != null)
        {
            // O "\n" serve para pular uma linha, colocando um item embaixo do outro
            inventoryText.text += "\n- " + itemName; 
        }
    }

    // Função chamada pelo ShopManager quando falta ouro
    public void ShowWarning(string mensagem)
    {
        if (warningPanel != null && warningText != null)
        {
            warningText.text = mensagem;
            
            // Interrompe qualquer aviso anterior (para não bugar se o jogador clicar rápido)
            StopAllCoroutines(); 
            
            // Inicia o cronômetro do novo aviso
            StartCoroutine(RotinaAviso());
        }
    }

    // A rotina mágica que liga o painel, espera e desliga
    private IEnumerator RotinaAviso()
    {
        warningPanel.SetActive(true);

        yield return new WaitForSeconds(2f); // Tempo que o painel fica na tela

        warningPanel.SetActive(false);
    }
}