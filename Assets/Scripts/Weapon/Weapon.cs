using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBuyed = false;
    [SerializeField] protected Bullet Bullet;
    [SerializeField] protected ShotgunBullet ShotgunBullet;
    [SerializeField] protected UziBullet UziBullet;
    [SerializeField] protected RiffleBullet RiffleBullet;

    public abstract void Shoot(Transform shootPoint);
}
