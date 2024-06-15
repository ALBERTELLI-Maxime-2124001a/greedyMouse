using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public TMP_Text text;
    public int coinNbr = 0;
    public AudioSource coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            Destroy(other.gameObject);
            coinNbr = coinNbr + 1;
            writeInText(text);
            coinSound.Play();
        }
    }

    void writeInText(TMP_Text text)
    {
        text.text = coinNbr.ToString();
    }
}
