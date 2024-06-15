using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenChest : MonoBehaviour
{
    bool m_interactPressed;
    bool HasKey;
    bool chestOpened = false;
    public TMP_Text pressA;
    public TMP_Text NECoin;
    public Canvas WinMenu;

    public bool interactPressed { set => m_interactPressed = value; get => m_interactPressed; }

    private void Start()
    {
        WinMenu.GetComponent<Canvas>().enabled = false;
    }

    private void Update()
    {
        HasKey = GameObject.Find("Player").GetComponent<SpawnKey>().HasKey;
    }

    public void OnTriggerStay(Collider other)
    {

        if (chestOpened) //Le coffre est d�j� ouvert
        {
            pressA.enabled = false; //On affiche pas le texte
            NECoin.enabled = false;
        }

        //Condition d'ouverture du coffre
        if (m_interactPressed && HasKey && !chestOpened) //Interaction press�, nombre de piece atteint, coffre ferm�
        {
            chestOpened = true; //On ouvre le coffre
            WinMenu.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if(m_interactPressed && !HasKey && !chestOpened) //Interaction pr�ss� mais pas assez de pi�ce
        {
            pressA.enabled = true;  //On continue d'afficher le texte d'interaction et on rajoute le texte d'alerte
            NECoin.enabled = true;
        }
        else if(!chestOpened) //Le coffre n'est pas ouvert aucune int�raction n'a �t� effectu�e
        {
            pressA.enabled = true; //On affiche le texte d'int�raction
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pressA.enabled = false;
        NECoin.enabled = false;
    }

    public void IsPlayerInteract(InputAction.CallbackContext _context)
    {
        interactPressed = _context.started || _context.performed;
    }

}
