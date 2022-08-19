using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HiddenCardPanel : MonoBehaviour
{
    public TMP_InputField inputText;

    private void OnEnable()
    {
        GameManager.Instance.activePanel = ActivePanel.hidden;
    }

    public void HiddenCardSubmit()
    {
        if(GameManager.Instance.selectedCard.hiddenCardID == inputText.text && inputText.text != "0")
        {
            Debug.Log("Ketemu hiddennya");
            var generatedCard = Instantiate(GameResource.Instance.card, GameManager.Instance.cardListHolder.transform);
            generatedCard.transform.GetComponent<Card>().cardDetail = GameManager.Instance.GetCardDetailByID(inputText.text);
        }
        else
        {
            Debug.Log("ga nemu");
        }
    }

    public void SelectCardChoice()
    {
        this.gameObject.SetActive(false);
        GameManager.Instance.panelChoiceCard.SetActive(true);
    }

    public void OpenPanelHidden()
    {
        GameManager.Instance.CloseAllPanel();
        this.gameObject.SetActive(true);
    }
}
