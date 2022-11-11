using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelebrationFrankenstein : State
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play("Spider celebration");
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}
