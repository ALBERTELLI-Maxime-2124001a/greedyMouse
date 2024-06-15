using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !gameObject.CompareTag("Projectile"))
        {
            Killable playerKillable = other.GetComponent<Killable>();
            if(playerKillable != null)
            {
                playerKillable.Die();
            }
            else
            {
                Debug.Log("Can't kill player");
            }
        }
    }
}
