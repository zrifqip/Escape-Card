using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HiddenCardPanel : MonoBehaviour
{
    public TMP_InputField inputText;

    public void HiddenCardSubmit()
    {
        if(GameManager.Instance.selectedCard.hiddenCardID == inputText.text)
        {
            Debug.Log("berhasil");
        }
        else
        {
            Debug.Log("Salah");
        }
    }

    public void SelectCardChoice()
    {
        this.gameObject.SetActive(false);
        GameManager.Instance.panelChoiceCard.SetActive(true);
    }
}
