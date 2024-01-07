using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private PlayerMovement _playerMovement;
    [SerializeField]
    private Animator _animator;
    private Rigidbody2D _rb;
    internal float speed { get { return _speed; } set { _speed = value; } }
    internal Animator animator { get { return _animator; } }
    protected Rigidbody2D Rigidbody { get { return _rb; } }

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        FollowPlayer();
        RotatePlayer();
    }

    protected void RotatePlayer()
    {
        float distance = _playerMovement.transform.position.x - transform.position.x;
        transform.rotation = Quaternion.Euler(0, distance >= 0 ? 0 : -180, 0);
    }

    protected void FollowPlayer()
    {
        Vector3 toTranslate = _playerMovement.transform.position - transform.position;
        _rb.velocity = toTranslate.normalized * _speed * Time.deltaTime;
    }
}
