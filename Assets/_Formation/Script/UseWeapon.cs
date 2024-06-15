using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class UseWeapon : MonoBehaviour
{
    public TMP_Text alertWeapon;
    bool m_firePressed;
    float cooldown = 0f;
    public bool HasWeapon = false;
    public GameObject weapon;
    public bool firePressed { set => m_firePressed = value; get => m_firePressed; }

    private void Start()
    {
        weapon.SetActive(false);
        alertWeapon.enabled = false;
    }

    public void IsPlayerFire(InputAction.CallbackContext _context)
    {
        firePressed = _context.started || _context.performed;
        
    }

    private void Update()
    {
        if (firePressed && HasWeapon && cooldown + 1 < Time.time)
        {
            cooldown = Time.time;
            GameObject projectile = Instantiate(weapon);
            projectile.SetActive(true);
            projectile.transform.position = weapon.transform.position;
            projectile.AddComponent<Rigidbody>();
            projectile.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, 45));
            Physics.IgnoreCollision(projectile.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
            StartCoroutine(destroyProjectile(projectile));
        }
    }

    public void coroutineAlertLaunch()
    {
        StartCoroutine(cooldownAlert());
    }

    IEnumerator destroyProjectile(GameObject projectile)
    {
        yield return new WaitForSeconds(1);
        Destroy(projectile);
    }

    IEnumerator cooldownAlert()
    {
        alertWeapon.enabled = true;
        yield return new WaitForSeconds(3);
        alertWeapon.enabled = false;
    }
}
