using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenoura : MonoBehaviour
{
    Animator animator;

    void Start ()
    {
        animator = GetComponent<Animator>();
    }
	
	void Update () {
        animator.SetInteger("LutaVar", 2);
    }
}
