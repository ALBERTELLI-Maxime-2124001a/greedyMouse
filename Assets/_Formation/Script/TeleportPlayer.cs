using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform TargetObject;
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = TargetObject.transform.position;
    }
}