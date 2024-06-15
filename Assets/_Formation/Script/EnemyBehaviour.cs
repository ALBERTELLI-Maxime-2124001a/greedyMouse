using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    bool uTurn = false;

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.z >= 8.60)
        {
            uTurn = true;
        }
        else if (gameObject.transform.position.z <= 4.30)
        {
            uTurn = false;
        }
        if(Time.timeScale != 0f)
        {
            if (uTurn)
            {
                transform.position -= new Vector3(0, 0, 0.01f);
            }
            else if (!uTurn)
            {
                transform.position += new Vector3(0, 0, 0.01f);
            }
        }
    }
}
