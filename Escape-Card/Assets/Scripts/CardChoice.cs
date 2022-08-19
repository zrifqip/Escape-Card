using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardChoice : MonoBehaviour
{
    public CardDetailSO cardDetail;
    
    public void SelectCard()
    {
        if(GameManager.Instance.activePanel != ActivePanel.combine)
        {
            GameManager.Instance.selectedCard = cardDetail;
            GameManager.Instance.panelChoiceCard.SetActive(false);

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
            if(GameManager.Instance.choiceCombineCard1 && !GameManager.Instance.choiceCombineCard2)
            {
                GameManager.Instance.selectedCombineCard1 = cardDetail;
                GameManager.Instance.panelChoiceCard.SetActive(false);

                GameManager.Instance.combineCardImageSelected1.GetComponent<Image>().sprite = cardDetail.cardSprite;
            }
            else
            {
                GameManager.Instance.selectedCombineCard2 = cardDetail;
                GameManager.Instance.panelChoiceCard.SetActive(false);

                GameManager.Instance.combineCardImageSelected2.GetComponent<Image>().sprite = cardDetail.cardSprite;
            }
        }
        
        
    }
}
