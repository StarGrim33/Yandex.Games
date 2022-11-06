using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBuyed = false;
    [SerializeField] protected Bullet Bullet;
    [SerializeField] protected ShotgunBullet ShotgunBullet;
    [SerializeField] protected UziBullet UziBullet;
    [SerializeField] protected RiffleBullet RiffleBullet;

    public int Damage;

    public string Label => _label;
    public int Price => _price;
    public Sprite Icon => _icon;
    public bool IsBuyed => _isBuyed;

    public abstract void Shoot(Transform shootPoint);

    protected void Awake()
    {
        
    }

    public void Buy()
    {
        _isBuyed = true;
    }
}
