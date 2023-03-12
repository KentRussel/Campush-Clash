using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public Transform[] cardslots; 
    public bool[] availableCardSlots; 

    public Text deckSizeText;

    public void DrawCard()
    {
        if(deck.Count >= 1){
            Card ranCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i = availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true){
                    ranCard.GameObject.SetActive(true);
                    ranCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(ranCard);
                    return;
                }
            }

        }
    }

    private void Update()
    {
        deckSizeText.text = deck.Count.ToString();
    }
}
