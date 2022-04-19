using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Card", menuName = "Deck/Cards")]
public class Card : ScriptableObject
{
    public bool fire, water, snow;
    public string color = "";
    public int power = 0;
    public Sprite icon = null;

    public virtual void UseCard()
    {
        
    }
}