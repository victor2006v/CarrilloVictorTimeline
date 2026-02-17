using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void Guard_Attack(){ 
        if(animator != null) animator.SetBool("Attack", true);
    }
}
