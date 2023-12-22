using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndeadExecutionerHandler : MonoBehaviour, Damageable
{
    [SerializeField]
    private float _health;
    private UndeadExecutionerMovement _movement;
    public bool IsAlive => _health > 0;

    public void TakeDamage(float damage)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        _movement = GetComponent<UndeadExecutionerMovement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void InterruptAttackAnimation()
    {
        if (_movement.animator.GetInteger("State") == 0)
            _movement.animator.Play("Idle");
    }
}
