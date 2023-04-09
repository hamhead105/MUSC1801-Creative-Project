using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GushHandler : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private int style;

    private void Start()
    {
        animator = GetComponent<Animator>();
        StartGush();
    }

    private void OnEnable()
    {
        animator = GetComponent<Animator>();
        StartGush();
    }

    public void StartGush()
    {
        animator.SetInteger("Style", style);
        animator.SetBool("Enable", true);
    }

    public void Stop()
    {
        animator.SetBool("Enable", false);
    }
}
