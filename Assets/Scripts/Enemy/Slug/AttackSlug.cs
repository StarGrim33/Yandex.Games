using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class AttackSlug : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;
    [SerializeField] private SlugScale _slugScale;
    [SerializeField] private SlugColorChange _colorChange;

    private bool _isColorChange = false;
    private Animator _animator;
    private float _lastAttackTime;
    private bool _isScale = false;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (_lastAttackTime <= 0)
        {

            if(!_isScale)
            {
                _slugScale.enabled = true;
                _isScale = true;
            }

            if(!_isColorChange)
            {
                _colorChange.enabled = true;
                _isScale = false;
            }
            Attack(Target);
            _lastAttackTime = _delay;
        }
        _lastAttackTime -= Time.deltaTime;
    }
   
    private void Attack(Player target)
    {
        _animator.Play("Slug attack");
        target.ApplyDamage(_damage);
    }
}

