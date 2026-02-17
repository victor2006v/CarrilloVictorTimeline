using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void Idle() {
        if (animator != null) animator.SetBool("Idle", true);
    }

    public void Die() {
        if (animator != null) animator.SetBool("Die", true);
    }
}
