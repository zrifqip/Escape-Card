using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineCardPanel : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.Instance.activePanel = ActivePanel.combine;
    }

    public void CombineCardSubmit()
    {
        if (GameManager.Instance.selectedCombineCard1.combineCardsProducesID == GameManager.Instance.selectedCombineCard2.combineCardsProducesID && GameManager.Instance.selectedCombineCard1.combineCardsProducesID != "0" && 
            GameManager.Instance.selectedCombineCard1.cardID != GameManager.Instance.selectedCombineCard2.cardID)
        {
            if(GameManager.Instance.GetCardByID(GameManager.Instance.selectedCombineCard1.combineCardsProducesID) != null)
            {
                Debug.Log("Udah pernah kecombine");
                return;
            }

            Debug.Log("tercombine");
            var generatedCard = Instantiate(GameResource.Instance.card, GameManager.Instance.cardListHolder.transform);
            generatedCard.transform.GetComponent<Card>().cardDetail = GameManager.Instance.GetCardDetailByID(GameManager.Instance.selectedCombineCard1.combineCardsProducesID);

            // Misal dicombine, kartu yg tercombine akan hilang
            //Destroy(GameManager.Instance.GetCardByID(GameManager.Instance.selectedCombineCard1.cardID));
            //Destroy(GameManager.Instance.GetCardByID(GameManager.Instance.selectedCombineCard2.cardID));
        }
        else
        {
            Debug.Log("tidak combine");
        }
    }

    public void SelectCardChoice1()
    {
        GameManager.Instance.panelChoiceCard.SetActive(true);
        GameManager.Instance.choiceCombineCard1 = true;
        GameManager.Instance.choiceCombineCard2 = false;
    }

    public void SelectCardChoice2()
    {
        GameManager.Instance.panelChoiceCard.SetActive(true);
        GameManager.Instance.choiceCombineCard2 = true;
        GameManager.Instance.choiceCombineCard1 = false;
    }

    public void OpenPanelCombine()
    {
        GameManager.Instance.CloseAllPanel();
        this.gameObject.SetActive(true);
    }
}
