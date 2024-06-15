using BUT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStepSound : MonoBehaviour
{
    public AudioSource stepDirt1;
    public AudioSource stepDirt2;
    public ParticleSystem dustParticle;
    bool isMoving;
    bool isGrounded;

    private void Update()
    {
        isMoving = GameObject.Find("Player").GetComponent<PlayerMovement>().m_IsMoving;
        isGrounded = GameObject.Find("Player").GetComponent<PlayerMovement>().m_IsGrounded;
        if (isMoving && isGrounded)
        {
            dustParticle.enableEmission = true;
            stepDirt1.enabled = true;
        }
        else
        {
            dustParticle.enableEmission = false;
            stepDirt1.enabled = false;
        }
    }
}
