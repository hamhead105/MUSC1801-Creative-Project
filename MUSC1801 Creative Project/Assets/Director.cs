using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    [SerializeField] private int movieState;
    private Animator stateAnimator;

    // Start is called before the first frame update
    void Start()
    {
        stateAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
