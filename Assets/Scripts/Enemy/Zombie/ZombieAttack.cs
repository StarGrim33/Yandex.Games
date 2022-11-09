using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ZombieAttack : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;
    private Animator _animator;
    private float _lastAttackTime;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (_lastAttackTime <= 0)
        {
            Attack(Target);
            _lastAttackTime = _delay;
        }
        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack(Player target)
    {
        _animator.Play("Zombie attack");
        target.ApplyDamage(_damage);
    }
}
