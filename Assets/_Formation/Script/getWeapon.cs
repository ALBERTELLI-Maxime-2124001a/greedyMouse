using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class getWeapon : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<UseWeapon>().HasWeapon = true;
            GameObject.Find("Player").GetComponent<UseWeapon>().coroutineAlertLaunch();
            gameObject.SetActive(false);
            
        }
    }

    
}
