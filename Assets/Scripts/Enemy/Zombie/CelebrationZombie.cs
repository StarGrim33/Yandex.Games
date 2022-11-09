using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelebrationZombie : State
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play("Zombie celebration");
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}
