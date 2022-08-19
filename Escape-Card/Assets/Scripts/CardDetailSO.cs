using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CardDetail_", menuName = "Scriptable Objects/Card Detail")]
public class CardDetailSO : ScriptableObject
{
    // Card detail
    public Sprite cardSprite;
    public string cardDescription;
    public string cardID;

    // Combine Cards detail, misal card tidak bisa dicombine, isi value dengan 0
    public string combineCardsProducesID;

    // Hidden card detail, misal card tidak ada hiddennya, isi value dengan 0
    public string hiddenCardID;

    // Unlock card detail, misal card tidak ada unlocknya, isi value dengan 0
    public string unlockCardAnswer;
    public string unlockCardID;
}

