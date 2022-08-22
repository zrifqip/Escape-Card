using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class GameManager : SingletonMonobehaviour<GameManager>
{
    // Dependencies References

    // General reference
    public GameObject cardListHolder;
    public CardDetailSO selectedCard;
    public GameObject panelChoiceCard;
    public CardDetailSO selectedCombineCard1;
    public CardDetailSO selectedCombineCard2;
    public bool choiceCombineCard1 = false;
    public bool choiceCombineCard2 = false;
    public Canvas canvas;

    // Each Panel reference
    public GameObject hiddenCardImageSelected;
    public GameObject hiddenCardPanel;
    public GameObject unlockCardImageSelected;
    public GameObject unlockCardPanel;
    public GameObject combineCardImageSelected1;
    public GameObject combineCardImageSelected2;
    public GameObject combineCardPanel;

    // Keeps track which panel open
    public ActivePanel activePanel = ActivePanel.main;

    public List<CardDetailSO> allCardDetailList;
    public Transform panelTransform;

    public CardDetailSO GetCardDetailByID(string cardID)
    {
        foreach(CardDetailSO cardDetail in allCardDetailList)
        {
            if(cardDetail.cardID == cardID)
            {
                return cardDetail;
            }
        }

        return null;
    }

    // Existing Card
    public GameObject GetCardByID(string cardID)
    {
        foreach(Transform child in cardListHolder.transform)
        {
            if(child.GetComponent<Card>().cardDetail.cardID == cardID)
            {
                return child.gameObject;
            }
        }
        return null;
    }

    public void CloseAllPanel()
    {
        hiddenCardPanel.SetActive(false);
        unlockCardPanel.SetActive(false);
        combineCardPanel.SetActive(false);
    }
}
