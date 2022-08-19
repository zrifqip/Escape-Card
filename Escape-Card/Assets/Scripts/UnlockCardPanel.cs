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
            Debug.Log("benar");
            var generatedCard = Instantiate(GameResource.Instance.card, GameManager.Instance.cardListHolder.transform);
            generatedCard.transform.GetComponent<Card>().cardDetail = GameManager.Instance.GetCardDetailByID(GameManager.Instance.selectedCard.unlockCardID);
            // Ini berhasil, cuma kurang diadjust spawn positionnya
        }
        else
        {
            Debug.Log("Salah");
            this.gameObject.SetActive(false);
            GameManager.Instance.activePanel = ActivePanel.main;
        }
    }

    public void SelectCardChoice()
    {
        this.gameObject.SetActive(false);
        GameManager.Instance.panelChoiceCard.SetActive(true);
    }
}
