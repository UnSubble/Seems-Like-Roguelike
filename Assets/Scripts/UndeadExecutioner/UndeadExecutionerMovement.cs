using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndeadExecutionerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private PlayerMovement _playerMovement;
    [SerializeField]
    private Animator _animator;
    internal Animator animator { get { return _animator; } }
    private Rigidbody2D _rb;
    internal float speed { get { return _speed; } set { _speed = value; } }
    internal bool triggered { get; set; }
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    bool GetAttackingEnd()
    {
        return _animator.GetInteger("State") == 0;
    }

    void FixedUpdate()
    {
        if (GetAttackingEnd())
        {
            if (!triggered)
            {
                FollowPlayer();
            }
            RotatePlayer();
        }
        else
        {
            _rb.velocity = Vector3.zero;
        }
    }


    void FollowPlayer()
    {
        
        Vector3 toTranslate = _playerMovement.transform.position - transform.position;
        _rb.velocity = toTranslate.normalized * _speed * Time.deltaTime;
        
    }

    void RotatePlayer()
    {
        float distance = _playerMovement.transform.position.x - transform.position.x;
        transform.rotation = Quaternion.Euler(0, distance >= 0 ? 0 : -180, 0);
    }
}
