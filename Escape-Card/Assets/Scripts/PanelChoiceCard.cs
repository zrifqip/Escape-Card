using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelChoiceCard : MonoBehaviour
{
    public Transform cardListParent;

    private void OnEnable()
    {
        foreach (Transform child in GameManager.Instance.cardListHolder.transform)
        {
            var cardChoice = Instantiate(GameResource.Instance.cardChoice, cardListParent);
            cardChoice.GetComponent<Image>().sprite = child.GetComponent<Card>().cardDetail.cardSprite;
            cardChoice.GetComponent<CardChoice>().cardDetail = child.GetComponent<Card>().cardDetail;
        }
    }

    private void OnDisable()
    {
        foreach(Transform child in cardListParent.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void ExitPanel()
    {
        this.gameObject.SetActive(false);
    }
}
