using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UziBullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    public GameObject Impact02;
    public Vector3 _direction;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            Instantiate(Impact02, transform.position, transform.rotation);
            enemy.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
