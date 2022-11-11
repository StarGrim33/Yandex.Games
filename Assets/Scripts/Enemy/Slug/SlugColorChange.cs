using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugColorChange : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _speed = 0.1f;

    private void Update()
    {
        var currentColor = _spriteRenderer.color;
        currentColor = currentColor - new Color(0,1,1,0) * _speed;
     
        if(currentColor.g == 0 || currentColor.b == 0)
        {
            enabled = false;
        }

        _spriteRenderer.color = currentColor;
       
    }
}
