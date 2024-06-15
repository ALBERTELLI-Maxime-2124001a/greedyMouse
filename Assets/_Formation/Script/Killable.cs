using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.Events;

public class Killable : MonoBehaviour
{
    public UnityEvent OnDie;
    public Canvas DefMenu;

    public void Start()
    {
        DefMenu.GetComponent<Canvas>().enabled = false;
    }

    public void Die()
    {
        if(gameObject.tag == "Player")
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        DefMenu.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void DebugDie()
    {
        Debug.Log("Je meurs");
    }
}
