using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int _health;
    [SerializeField] private int _reward;
    private float _delay = 1f;
    private Player _target;
    public int Reward => _reward;

    public event UnityAction<Enemy> Dying;
    public Player Target => _target;
    public void Init(Player target)
    {
        _target = target;
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;

        if(_health <= 0)
        {
            Dying?.Invoke(this);
            Destroy(gameObject);
        }
    }
}
