using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public Animator animator; 
    void Start()
    {
        animator.SetTrigger("FadeIn");
    }

}
