using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    [SerializeField] private Transform panelTransform;
    public CardDetailSO cardDetail;

    private void Start()
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cardDetail.cardSprite;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }
            Debug.Log("klik");
            var cardPanel = Instantiate(GameResource.Instance.detailPanel, panelTransform);
            cardPanel.transform.GetChild(0).transform.GetChild(1).GetComponent<Image>().sprite = cardDetail.cardSprite;
            cardPanel.transform.GetChild(0).transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = cardDetail.cardDescription;
        }
    }

}
