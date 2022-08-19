using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Class ini gabung sama UnlockCardPanel, soalnya fungsinya bnyk yg sama
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
            Debug.Log("berhasil");
            var generatedCard = Instantiate(GameResource.Instance.card, GameManager.Instance.cardListHolder.transform);
            generatedCard.transform.GetComponent<Card>().cardDetail = GameManager.Instance.GetCardDetailByID(inputText.text);
            // Ini berhasil, cuma kurang diadjust spawn positionnya
        }
        else
        {
            Debug.Log("gagal");
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
