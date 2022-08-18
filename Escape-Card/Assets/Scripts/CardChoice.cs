using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardChoice : MonoBehaviour
{
    public CardDetailSO cardDetail;
    
    public void SelectCard()
    {
        GameManager.Instance.selectedCard = cardDetail;
        GameManager.Instance.panelChoiceCard.SetActive(false);
        GameManager.Instance.hiddenCardImageSelected.GetComponent<Image>().sprite = cardDetail.cardSprite;
        GameManager.Instance.hiddenCardPanel.SetActive(true);
    }
}
