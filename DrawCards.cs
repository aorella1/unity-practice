using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
  public GameObject Card1;
  public GameObject Card2;
  public GameObject Card3;

  public GameObject PlayerArea;
  public GameObject EnemyArea;
  // Start is called before the first frame update
  List<GameObject> cards = new List<GameObject>();
  void Start()
  {
    cards.Add(Card1);
    cards.Add(Card2);
    cards.Add(Card3);
  }
  public void OnClick()
  {
    //Quaternion.identiy - no rotation
    for (int cardIndex = 0; cardIndex < 5; cardIndex++)
    {
      GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
      //transform - where the card lives 
      playerCard.transform.SetParent(PlayerArea.transform, false);
      GameObject enemyCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
      enemyCard.transform.SetParent(EnemyArea.transform, false);

    }

  }
}
