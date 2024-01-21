using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extensions;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField] 
    private float _speed;

    [SerializeField] 
    private float _speedChangeValue;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _speed += _speedChangeValue;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _speed -= _speedChangeValue;
        }
        
        _animator.SetFloat(GlobalConstants.Speed, _speed);
    }
}
