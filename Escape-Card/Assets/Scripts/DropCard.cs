using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropCard : MonoBehaviour, IDropHandler
{
    [SerializeField] private bool isCombineCardLeft = false;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Droped");
        if(eventData.pointerDrag != null)
        {
            CardDetailSO cardDetail = eventData.pointerDrag.GetComponent<Card>().cardDetail;
            if (GameManager.Instance.activePanel != ActivePanel.combine)
            {
                GameManager.Instance.selectedCard = cardDetail;

                switch (GameManager.Instance.activePanel)
                {
                    case ActivePanel.hidden:
                        GameManager.Instance.hiddenCardImageSelected.GetComponent<Image>().sprite = cardDetail.cardSprite;
                        break;

                    case ActivePanel.unlock:
                        GameManager.Instance.unlockCardImageSelected.GetComponent<Image>().sprite = cardDetail.cardSprite;
                        break;

                }
            }
            else
            {
                if (isCombineCardLeft)
                {
                    GameManager.Instance.selectedCombineCard1 = cardDetail;

                    GameManager.Instance.combineCardImageSelected1.GetComponent<Image>().sprite = cardDetail.cardSprite;
                }
                else
                {
                    GameManager.Instance.selectedCombineCard2 = cardDetail;

                    GameManager.Instance.combineCardImageSelected2.GetComponent<Image>().sprite = cardDetail.cardSprite;
                }
            }
        }
    }
}
