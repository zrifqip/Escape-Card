using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class GameManager : SingletonMonobehaviour<GameManager>
{
    // Dependencies References
    public GameObject cardListHolder;
    public CardDetailSO selectedCard;
    public GameObject panelChoiceCard;
    public GameObject hiddenCardImageSelected;
    public GameObject hiddenCardPanel;
}
