using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddCoin : MonoBehaviour
{
    public int coinNbr = 0;

    public void UpdateCoin(TMP_Text text)
    {
        coinNbr = coinNbr + 1;
        writeInText(text);
    }

    void writeInText(TMP_Text text)
    {
        text.text = coinNbr.ToString();
    }
}
