using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HiddenCardPanel : MonoBehaviour
{
    public ReferenceManager referenceManager;
    public TMP_InputField inputText;

    public void HiddenCardSubmit()
    {
        if(referenceManager.selectedCard.hiddenCardID == inputText.text)
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
        referenceManager.panelChoiceCard.SetActive(true);
    }
}
