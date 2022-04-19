using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerHand : MonoBehaviour
{
    public List<Card> playerHand = new List<Card>();
    public GameObject[] cardsUI;
    PlayerDeck playerDeckScript;
    public TextMeshProUGUI text;
    public Image imagemzinha;


    void Start()
    {
        playerDeckScript = gameObject.GetComponent<PlayerDeck>();
        for (int i = 0; i < 5; i++)
        {
            int randomizer = Random.Range(0, playerDeckScript.playerDeck.Count);
            playerHand.Add(playerDeckScript.playerDeck[randomizer]);
            playerDeckScript.playerDeck.RemoveAt(randomizer);
        }
        UpdateHand();
    }


    void UpdateHand()
    {

        int handPosition = 0;
        foreach (Card carta in playerHand)
        {
            cardsUI[handPosition].GetComponent<Image>().sprite = carta.icon;
            handPosition++;
        }
    }

    public void PlayCard(int position)
    {
        string texto = "O Player  jogou a carta :";
        text.text = texto;
        imagemzinha.sprite = playerHand[position].icon;

    }
}
