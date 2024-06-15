using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnKey : MonoBehaviour
{
    int collectCoinNbr;
    public bool HasKey = false;
    bool KeyPresent = false;
    public GameObject key;
    public TMP_Text alert;
    public Image keySprite;

    private void Start()
    {
        alert.enabled = false;
        key.SetActive(false);
        keySprite.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        collectCoinNbr = GameObject.Find("Player").GetComponent<CollectCoin>().coinNbr;

        if(collectCoinNbr == 9 && !HasKey && !KeyPresent)
        {
            key.SetActive(true);
            KeyPresent = true;
            StartCoroutine(AlertPlayer());
        }
    }

    IEnumerator AlertPlayer()
    {
        alert.enabled=true;
        yield return new WaitForSeconds(3);
        alert.enabled=false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            other.gameObject.SetActive(false);
            keySprite.enabled = true;
            HasKey = true;
        }
    }
}
