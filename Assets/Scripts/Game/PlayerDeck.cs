using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDeck : MonoBehaviour
{
    public List<Card> basicDeck1 = new List<Card>();
    public List<Card> basicDeck2 = new List<Card>();
    public List<Card> basicDeck3 = new List<Card>();

    public List<Card> playerDeck = new List<Card>();


    void Start()
    {

        List<List<Card>> randomizer= new List<List<Card>>();
        randomizer.Add(basicDeck1);
        randomizer.Add(basicDeck2);
        randomizer.Add(basicDeck3);
        int randomIndex = Random.Range(0, randomizer.Count);
        playerDeck = randomizer[randomIndex];

    }
}
