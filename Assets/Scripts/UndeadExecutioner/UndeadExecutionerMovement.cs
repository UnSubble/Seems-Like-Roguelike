using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndeadExecutionerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private PlayerMovement _playerMovement;
    private Rigidbody2D _rb;
    internal float speed { get { return _speed; } set { _speed = value; } }
    

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        Vector3 toTranslate = _playerMovement.transform.position - transform.position;
        _rb.velocity = toTranslate.normalized * _speed * Time.deltaTime;
        float distance = _playerMovement.transform.position.x - transform.position.x;
        transform.rotation = Quaternion.Euler(0, distance >= 0 ? 0 : -180, 0);
    }

}
