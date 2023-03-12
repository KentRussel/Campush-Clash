using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Card : MonoBehaviour
{
    public List<GameObject> cardsInDeck = new List<GameObject>(); // the list of cards in the deck
    public Transform drawCardPosition; // the position where the drawn card will be placed
    public int numCardsToDraw = 1; // the number of cards to draw each time the player clicks

    private void Start()
    {
        // shuffle the deck
        ShuffleDeck();
    }

    public void DrawCards()
    {
        // draw the specified number of cards
        for (int i = 0; i < numCardsToDraw; i++)
        {
            if (cardsInDeck.Count > 0)
            {
                // remove the top card from the deck
                GameObject drawnCard = cardsInDeck[0];
                cardsInDeck.RemoveAt(0);

                // move the card to the draw position
                drawnCard.transform.position = drawCardPosition.position;

                // enable the card's game object
                drawnCard.SetActive(true);
            }
            else
            {
                // there are no more cards in the deck
                Debug.Log("The deck is empty!");
                break;
            }
        }
    }

    private void ShuffleDeck()
    {
        // shuffle the deck using Fisher-Yates shuffle algorithm
        for (int i = cardsInDeck.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            GameObject temp = cardsInDeck[i];
            cardsInDeck[i] = cardsInDeck[j];
            cardsInDeck[j] = temp;
        }
    }
}

