using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugScale : MonoBehaviour
{
    [SerializeField] private Transform _slugTransform;
    [SerializeField] private float _scale;
    [SerializeField] private Color _color;
    [SerializeField] private float _speedScale;
    [SerializeField] private float _maxScale;

    void Update()
    {
        _slugTransform.localScale += Vector3.one * _speedScale * Time.deltaTime;

        if(_slugTransform.localScale.x >= _maxScale)
        {
            enabled = false;
        }
    }
}
