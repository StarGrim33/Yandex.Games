using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riffle : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        var bullet = Instantiate(RiffleBullet, shootPoint.position, Quaternion.identity);
        var finalPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bullet._direction = (finalPosition - shootPoint.position).normalized;
        Debug.DrawLine(shootPoint.position, bullet._direction * 10, Color.red, 3);
        Debug.DrawLine(shootPoint.position, finalPosition, Color.green, 3);
    }
}
