using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardChoice : MonoBehaviour
{
    public CardDetailSO cardDetail;
    private ReferenceManager referenceManager;
    
    public void SelectCard()
    {
        referenceManager = FindObjectOfType<ReferenceManager>();
        referenceManager.selectedCard = cardDetail;
        referenceManager.panelChoiceCard.SetActive(false);
        referenceManager.hiddenCardImageSelected.GetComponent<Image>().sprite = cardDetail.cardSprite;
        referenceManager.hiddenCardPanel.SetActive(true);
    }
}
