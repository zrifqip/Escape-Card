using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UnlockCardPanel : MonoBehaviour
{
    public TMP_InputField inputText;

    private void OnEnable()
    {
        GameManager.Instance.activePanel = ActivePanel.unlock;
    }

    public void UnlockCardSubmit()
    {
        if (GameManager.Instance.selectedCard.unlockCardAnswer == inputText.text && inputText.text != "0")
        {
            if(GameManager.Instance.GetCardByID(GameManager.Instance.selectedCard.unlockCardID) != null)
            {
                Debug.Log("Udah pernah keunlock");
                return;
            }

            Debug.Log("benar");
            var generatedCard = Instantiate(GameResource.Instance.card, GameManager.Instance.cardListHolder.transform);
            generatedCard.transform.GetComponent<Card>().cardDetail = GameManager.Instance.GetCardDetailByID(GameManager.Instance.selectedCard.unlockCardID);

            // Misal terunlock, maka kartu akan hilang
            //Destroy(GameManager.Instance.GetCardByID(GameManager.Instance.selectedCard.cardID));
        }
        else
        {
            Debug.Log("Salah");
        }
    }

    public void SelectCardChoice()
    {
        GameManager.Instance.panelChoiceCard.SetActive(true);
    }

    public void OpenPanelUnlock()
    {
        GameManager.Instance.CloseAllPanel();
        this.gameObject.SetActive(true);
    }
}
